using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pinger2
{
    public class Pinger2
    {

        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        bool resolveNames = true;
        public static List<string> foundIps = new List<string>();

        public void go()
        {
            countdown = new CountdownEvent(1);
            List<string> ipBases = new List<string>
            { "192.168.1.", "192.168.0." };
            foreach (string ipBase in ipBases)
            {
                for (int i = 1; i < 255; i++)
                {
                    string ip = ipBase + i.ToString();

                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    countdown.AddCount();
                    p.SendAsync(ip, 250, ip);
                    Console.WriteLine("sent ping {0}, signal je na {1}", ip, countdown.CurrentCount);
                }
            }

            countdown.Signal();
            Console.WriteLine("sad je izmedju signal i wait");
            countdown.Wait();
            Console.WriteLine("zavrsio se wait");
            Console.WriteLine("{0} hosts active.", upCount);
            Console.ReadLine();
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            Console.WriteLine("scanning {0}", ip);

            if(e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                Console.WriteLine("found one --> {0}", ip);
                lock (lockObj)
                {
                    upCount++;
                }
                
            }
            countdown.Signal();

            Console.WriteLine("signal je spusten na {0}", countdown.CurrentCount);
        }
    }

    class Mainn
    {
        static void Main()
        {
            Pinger2 pinger = new Pinger2();
            pinger.go();
        }
    }
}

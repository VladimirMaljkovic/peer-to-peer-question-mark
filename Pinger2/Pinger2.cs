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
            Stopwatch sw = new Stopwatch();
            sw.Start();
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
                }
            }

            countdown.Signal();
            countdown.Wait();
            sw.Stop();
            TimeSpan span = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
            Console.ReadLine();
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            /*string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                foundIps.Add(ip);
                if (resolveNames)
                {
                    string name;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException ex)
                    {
                        name = "?";
                    }
                    Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                }
                else
                {
                    Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                }
                lock (lockObj)
                {
                    upCount++;
                }
            }
            else if (e.Reply == null)
            {
                Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
            }
            countdown.Signal();*/
            Console.WriteLine("peepee {0}", (string)e.UserState);
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

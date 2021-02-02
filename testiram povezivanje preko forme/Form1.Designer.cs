
namespace testiram_povezivanje_preko_forme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnConnect = new System.Windows.Forms.Button();
            this.txtWaitForConnection = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.richTxtSend = new System.Windows.Forms.RichTextBox();
            this.richTxtRecieved = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMyIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnConnect
            // 
            this.bttnConnect.Location = new System.Drawing.Point(11, 76);
            this.bttnConnect.Name = "bttnConnect";
            this.bttnConnect.Size = new System.Drawing.Size(96, 47);
            this.bttnConnect.TabIndex = 0;
            this.bttnConnect.Text = "connect to device";
            this.bttnConnect.UseVisualStyleBackColor = true;
            this.bttnConnect.Click += new System.EventHandler(this.bttnConnect_Click);
            // 
            // txtWaitForConnection
            // 
            this.txtWaitForConnection.Location = new System.Drawing.Point(12, 199);
            this.txtWaitForConnection.Name = "txtWaitForConnection";
            this.txtWaitForConnection.Size = new System.Drawing.Size(96, 35);
            this.txtWaitForConnection.TabIndex = 1;
            this.txtWaitForConnection.Text = "wait for connection";
            this.txtWaitForConnection.UseVisualStyleBackColor = true;
            this.txtWaitForConnection.Click += new System.EventHandler(this.txtWaitForConnection_Click);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.txtConnectionStatus.Enabled = false;
            this.txtConnectionStatus.Location = new System.Drawing.Point(11, 277);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(100, 20);
            this.txtConnectionStatus.TabIndex = 2;
            // 
            // richTxtSend
            // 
            this.richTxtSend.Location = new System.Drawing.Point(176, 42);
            this.richTxtSend.Name = "richTxtSend";
            this.richTxtSend.Size = new System.Drawing.Size(143, 220);
            this.richTxtSend.TabIndex = 3;
            this.richTxtSend.Text = "";
            // 
            // richTxtRecieved
            // 
            this.richTxtRecieved.Location = new System.Drawing.Point(340, 42);
            this.richTxtRecieved.Name = "richTxtRecieved";
            this.richTxtRecieved.Size = new System.Drawing.Size(143, 220);
            this.richTxtRecieved.TabIndex = 4;
            this.richTxtRecieved.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "send message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "recieved message:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(12, 42);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 7;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(11, 261);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(76, 13);
            this.lblConnectionStatus.TabIndex = 8;
            this.lblConnectionStatus.Text = "not connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connection status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connect to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "My ip address:";
            // 
            // lblMyIp
            // 
            this.lblMyIp.AutoSize = true;
            this.lblMyIp.Location = new System.Drawing.Point(14, 167);
            this.lblMyIp.Name = "lblMyIp";
            this.lblMyIp.Size = new System.Drawing.Size(35, 13);
            this.lblMyIp.TabIndex = 12;
            this.lblMyIp.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMyIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtRecieved);
            this.Controls.Add(this.richTxtSend);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.txtWaitForConnection);
            this.Controls.Add(this.bttnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnConnect;
        private System.Windows.Forms.Button txtWaitForConnection;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.RichTextBox richTxtSend;
        private System.Windows.Forms.RichTextBox richTxtRecieved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMyIp;
    }
}


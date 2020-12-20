
namespace Main_connecting_form
{
    partial class MainForm
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
            this.lblPrivateIP = new System.Windows.Forms.Label();
            this.rtxtSendMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtRecieveMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnConnectToSelected = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnScan = new System.Windows.Forms.Button();
            this.listBoxAvailableDevicesLocal = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnWaitForConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrivateIP
            // 
            this.lblPrivateIP.AutoSize = true;
            this.lblPrivateIP.Location = new System.Drawing.Point(12, 91);
            this.lblPrivateIP.Name = "lblPrivateIP";
            this.lblPrivateIP.Size = new System.Drawing.Size(50, 13);
            this.lblPrivateIP.TabIndex = 0;
            this.lblPrivateIP.Text = "private ip";
            // 
            // rtxtSendMessage
            // 
            this.rtxtSendMessage.Location = new System.Drawing.Point(12, 204);
            this.rtxtSendMessage.Name = "rtxtSendMessage";
            this.rtxtSendMessage.Size = new System.Drawing.Size(348, 96);
            this.rtxtSendMessage.TabIndex = 2;
            this.rtxtSendMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your message:";
            // 
            // rtxtRecieveMessage
            // 
            this.rtxtRecieveMessage.Location = new System.Drawing.Point(12, 338);
            this.rtxtRecieveMessage.Name = "rtxtRecieveMessage";
            this.rtxtRecieveMessage.Size = new System.Drawing.Size(348, 96);
            this.rtxtRecieveMessage.TabIndex = 4;
            this.rtxtRecieveMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recieved message:";
            // 
            // bttnConnectToSelected
            // 
            this.bttnConnectToSelected.Location = new System.Drawing.Point(379, 41);
            this.bttnConnectToSelected.Name = "bttnConnectToSelected";
            this.bttnConnectToSelected.Size = new System.Drawing.Size(128, 45);
            this.bttnConnectToSelected.TabIndex = 8;
            this.bttnConnectToSelected.Text = "Connect to chosen device";
            this.bttnConnectToSelected.UseVisualStyleBackColor = true;
            this.bttnConnectToSelected.Click += new System.EventHandler(this.bttnConnectToSelected_Click);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.txtConnectionStatus.Enabled = false;
            this.txtConnectionStatus.Location = new System.Drawing.Point(379, 147);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(128, 20);
            this.txtConnectionStatus.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connection status";
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(415, 411);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(139, 23);
            this.bttnExit.TabIndex = 11;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnScan
            // 
            this.bttnScan.Location = new System.Drawing.Point(12, 12);
            this.bttnScan.Name = "bttnScan";
            this.bttnScan.Size = new System.Drawing.Size(75, 38);
            this.bttnScan.TabIndex = 12;
            this.bttnScan.Text = "Scan network";
            this.bttnScan.UseVisualStyleBackColor = true;
            this.bttnScan.Click += new System.EventHandler(this.bttnScan_Click);
            // 
            // listBoxAvailableDevicesLocal
            // 
            this.listBoxAvailableDevicesLocal.FormattingEnabled = true;
            this.listBoxAvailableDevicesLocal.Location = new System.Drawing.Point(147, 41);
            this.listBoxAvailableDevicesLocal.Name = "listBoxAvailableDevicesLocal";
            this.listBoxAvailableDevicesLocal.Size = new System.Drawing.Size(213, 147);
            this.listBoxAvailableDevicesLocal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Local IPs found:\r\n(maybe)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Your private IP (I think):";
            // 
            // bttnWaitForConnection
            // 
            this.bttnWaitForConnection.Location = new System.Drawing.Point(379, 204);
            this.bttnWaitForConnection.Name = "bttnWaitForConnection";
            this.bttnWaitForConnection.Size = new System.Drawing.Size(128, 42);
            this.bttnWaitForConnection.TabIndex = 16;
            this.bttnWaitForConnection.Text = "Wait for connection";
            this.bttnWaitForConnection.UseVisualStyleBackColor = true;
            this.bttnWaitForConnection.Click += new System.EventHandler(this.bttnWaitForConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 444);
            this.Controls.Add(this.bttnWaitForConnection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxAvailableDevicesLocal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnScan);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.bttnConnectToSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtRecieveMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtSendMessage);
            this.Controls.Add(this.lblPrivateIP);
            this.Name = "MainForm";
            this.Text = "Shittin ass chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrivateIP;
        private System.Windows.Forms.RichTextBox rtxtSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtRecieveMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnConnectToSelected;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnScan;
        private System.Windows.Forms.ListBox listBoxAvailableDevicesLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnWaitForConnection;
    }
}


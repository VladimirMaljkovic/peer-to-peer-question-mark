
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
            this.bttnIdentifyNetwork = new System.Windows.Forms.Button();
            this.rtxtSendMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtRecieveMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAvailableDevices = new System.Windows.Forms.ListBox();
            this.bttnConnectToSelected = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrivateIP
            // 
            this.lblPrivateIP.AutoSize = true;
            this.lblPrivateIP.Location = new System.Drawing.Point(25, 97);
            this.lblPrivateIP.Name = "lblPrivateIP";
            this.lblPrivateIP.Size = new System.Drawing.Size(50, 13);
            this.lblPrivateIP.TabIndex = 0;
            this.lblPrivateIP.Text = "private ip";
            // 
            // bttnIdentifyNetwork
            // 
            this.bttnIdentifyNetwork.Location = new System.Drawing.Point(25, 31);
            this.bttnIdentifyNetwork.Name = "bttnIdentifyNetwork";
            this.bttnIdentifyNetwork.Size = new System.Drawing.Size(76, 38);
            this.bttnIdentifyNetwork.TabIndex = 1;
            this.bttnIdentifyNetwork.Text = "Identify network";
            this.bttnIdentifyNetwork.UseVisualStyleBackColor = true;
            this.bttnIdentifyNetwork.Click += new System.EventHandler(this.bttnIdentifyNetwork_Click);
            // 
            // rtxtSendMessage
            // 
            this.rtxtSendMessage.Location = new System.Drawing.Point(25, 215);
            this.rtxtSendMessage.Name = "rtxtSendMessage";
            this.rtxtSendMessage.Size = new System.Drawing.Size(348, 96);
            this.rtxtSendMessage.TabIndex = 2;
            this.rtxtSendMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your message:";
            // 
            // rtxtRecieveMessage
            // 
            this.rtxtRecieveMessage.Location = new System.Drawing.Point(28, 342);
            this.rtxtRecieveMessage.Name = "rtxtRecieveMessage";
            this.rtxtRecieveMessage.Size = new System.Drawing.Size(348, 96);
            this.rtxtRecieveMessage.TabIndex = 4;
            this.rtxtRecieveMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recieved message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Devices on this network:";
            // 
            // listBoxAvailableDevices
            // 
            this.listBoxAvailableDevices.FormattingEnabled = true;
            this.listBoxAvailableDevices.Location = new System.Drawing.Point(415, 62);
            this.listBoxAvailableDevices.Name = "listBoxAvailableDevices";
            this.listBoxAvailableDevices.Size = new System.Drawing.Size(128, 186);
            this.listBoxAvailableDevices.TabIndex = 7;
            // 
            // bttnConnectToSelected
            // 
            this.bttnConnectToSelected.Location = new System.Drawing.Point(415, 255);
            this.bttnConnectToSelected.Name = "bttnConnectToSelected";
            this.bttnConnectToSelected.Size = new System.Drawing.Size(128, 45);
            this.bttnConnectToSelected.TabIndex = 8;
            this.bttnConnectToSelected.Text = "Connect to chosen device";
            this.bttnConnectToSelected.UseVisualStyleBackColor = true;
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.txtConnectionStatus.Enabled = false;
            this.txtConnectionStatus.Location = new System.Drawing.Point(415, 324);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(128, 20);
            this.txtConnectionStatus.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 305);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 446);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.bttnConnectToSelected);
            this.Controls.Add(this.listBoxAvailableDevices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtRecieveMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtSendMessage);
            this.Controls.Add(this.bttnIdentifyNetwork);
            this.Controls.Add(this.lblPrivateIP);
            this.Name = "MainForm";
            this.Text = "Shittin ass chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrivateIP;
        private System.Windows.Forms.Button bttnIdentifyNetwork;
        private System.Windows.Forms.RichTextBox rtxtSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtRecieveMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAvailableDevices;
        private System.Windows.Forms.Button bttnConnectToSelected;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnExit;
    }
}


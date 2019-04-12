namespace RemoteDesktop
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Se7en.UI.ColorFadeItem colorFadeItem7 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem8 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem9 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem10 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem11 = new Se7en.UI.ColorFadeItem();
            Se7en.UI.ColorFadeItem colorFadeItem12 = new Se7en.UI.ColorFadeItem();
            this.TbRemotePort = new Se7en.UI.TextBox();
            this.TbRemoteHost = new Se7en.UI.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smoothLine2 = new Se7en.UI.SmoothLine();
            this.smoothLine3 = new Se7en.UI.SmoothLine();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbHostname = new System.Windows.Forms.Label();
            this.BtConnectToClient = new System.Windows.Forms.Button();
            this.TbServerPort = new Se7en.UI.TextBox();
            this.BtSetServerPort = new System.Windows.Forms.Button();
            this.TbbServerStatus = new Se7en.UI.ToggleButton();
            this.SuspendLayout();
            // 
            // TbRemotePort
            // 
            this.TbRemotePort.AutoScaleByText = false;
            this.TbRemotePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TbRemotePort.CompareWith = null;
            this.TbRemotePort.CueText = "Port";
            this.TbRemotePort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TbRemotePort.IsntInput = null;
            this.TbRemotePort.LineColor = System.Drawing.Color.DodgerBlue;
            this.TbRemotePort.LineHeight = 2;
            this.TbRemotePort.LineMarginHorizontal = 0;
            this.TbRemotePort.LineMarginLeft = 0;
            this.TbRemotePort.LineMarginRight = 0;
            this.TbRemotePort.LineMarginToText = 1;
            this.TbRemotePort.Location = new System.Drawing.Point(82, 82);
            this.TbRemotePort.Multiline = false;
            this.TbRemotePort.Name = "TbRemotePort";
            this.TbRemotePort.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TbRemotePort.PasswortChar = '\0';
            this.TbRemotePort.Patter = "^\\d{1,5}$";
            this.TbRemotePort.PatterError = System.Drawing.Color.Red;
            this.TbRemotePort.Size = new System.Drawing.Size(247, 17);
            this.TbRemotePort.TabIndex = 0;
            this.TbRemotePort.Text = null;
            this.TbRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbRemotePort.UseSystemPasswordChar = false;
            // 
            // TbRemoteHost
            // 
            this.TbRemoteHost.AutoScaleByText = false;
            this.TbRemoteHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TbRemoteHost.CompareWith = null;
            this.TbRemoteHost.CueText = "Host";
            this.TbRemoteHost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TbRemoteHost.IsntInput = null;
            this.TbRemoteHost.LineColor = System.Drawing.Color.DodgerBlue;
            this.TbRemoteHost.LineHeight = 2;
            this.TbRemoteHost.LineMarginHorizontal = 0;
            this.TbRemoteHost.LineMarginLeft = 0;
            this.TbRemoteHost.LineMarginRight = 0;
            this.TbRemoteHost.LineMarginToText = 1;
            this.TbRemoteHost.Location = new System.Drawing.Point(82, 59);
            this.TbRemoteHost.Multiline = false;
            this.TbRemoteHost.Name = "TbRemoteHost";
            this.TbRemoteHost.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TbRemoteHost.PasswortChar = '\0';
            this.TbRemoteHost.Patter = "^(\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}|[\\w\\d]*)$";
            this.TbRemoteHost.PatterError = System.Drawing.Color.Red;
            this.TbRemoteHost.Size = new System.Drawing.Size(247, 17);
            this.TbRemoteHost.TabIndex = 1;
            this.TbRemoteHost.Text = null;
            this.TbRemoteHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbRemoteHost.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // smoothLine2
            // 
            colorFadeItem7.Color = System.Drawing.Color.DodgerBlue;
            colorFadeItem7.Position = 0F;
            colorFadeItem8.Color = System.Drawing.Color.DeepSkyBlue;
            colorFadeItem8.Position = 0.5F;
            colorFadeItem9.Color = System.Drawing.Color.Transparent;
            colorFadeItem9.Position = 1F;
            this.smoothLine2.Colors = new Se7en.UI.ColorFadeItem[] {
        colorFadeItem7,
        colorFadeItem8,
        colorFadeItem9};
            this.smoothLine2.Location = new System.Drawing.Point(69, 44);
            this.smoothLine2.Name = "smoothLine2";
            this.smoothLine2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.smoothLine2.Size = new System.Drawing.Size(270, 2);
            this.smoothLine2.TabIndex = 5;
            // 
            // smoothLine3
            // 
            colorFadeItem10.Color = System.Drawing.Color.DodgerBlue;
            colorFadeItem10.Position = 0F;
            colorFadeItem11.Color = System.Drawing.Color.DeepSkyBlue;
            colorFadeItem11.Position = 0.5F;
            colorFadeItem12.Color = System.Drawing.Color.Transparent;
            colorFadeItem12.Position = 1F;
            this.smoothLine3.Colors = new Se7en.UI.ColorFadeItem[] {
        colorFadeItem10,
        colorFadeItem11,
        colorFadeItem12};
            this.smoothLine3.Location = new System.Drawing.Point(69, 143);
            this.smoothLine3.Name = "smoothLine3";
            this.smoothLine3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.smoothLine3.Size = new System.Drawing.Size(270, 2);
            this.smoothLine3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(7, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(18, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Host:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port:";
            // 
            // LbHostname
            // 
            this.LbHostname.AutoSize = true;
            this.LbHostname.ForeColor = System.Drawing.Color.GhostWhite;
            this.LbHostname.Location = new System.Drawing.Point(79, 162);
            this.LbHostname.Name = "LbHostname";
            this.LbHostname.Size = new System.Drawing.Size(112, 13);
            this.LbHostname.TabIndex = 10;
            this.LbHostname.Text = "xxx.xxx.xxx.xxx";
            // 
            // BtConnectToClient
            // 
            this.BtConnectToClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtConnectToClient.FlatAppearance.BorderSize = 0;
            this.BtConnectToClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConnectToClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtConnectToClient.Location = new System.Drawing.Point(228, 108);
            this.BtConnectToClient.Name = "BtConnectToClient";
            this.BtConnectToClient.Size = new System.Drawing.Size(101, 23);
            this.BtConnectToClient.TabIndex = 12;
            this.BtConnectToClient.Text = "Connect";
            this.BtConnectToClient.UseVisualStyleBackColor = false;
            this.BtConnectToClient.Click += new System.EventHandler(this.BtConnectToClient_Click);
            // 
            // TbServerPort
            // 
            this.TbServerPort.AutoScaleByText = false;
            this.TbServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TbServerPort.CompareWith = null;
            this.TbServerPort.CueText = "Port";
            this.TbServerPort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TbServerPort.IsntInput = null;
            this.TbServerPort.LineColor = System.Drawing.Color.DodgerBlue;
            this.TbServerPort.LineHeight = 2;
            this.TbServerPort.LineMarginHorizontal = 0;
            this.TbServerPort.LineMarginLeft = 0;
            this.TbServerPort.LineMarginRight = 0;
            this.TbServerPort.LineMarginToText = 1;
            this.TbServerPort.Location = new System.Drawing.Point(82, 179);
            this.TbServerPort.Multiline = false;
            this.TbServerPort.Name = "TbServerPort";
            this.TbServerPort.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TbServerPort.PasswortChar = '\0';
            this.TbServerPort.Patter = "^\\d{1,5}$";
            this.TbServerPort.PatterError = System.Drawing.Color.Red;
            this.TbServerPort.Size = new System.Drawing.Size(180, 17);
            this.TbServerPort.TabIndex = 13;
            this.TbServerPort.Text = null;
            this.TbServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbServerPort.UseSystemPasswordChar = false;
            // 
            // BtSetServerPort
            // 
            this.BtSetServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtSetServerPort.FlatAppearance.BorderSize = 0;
            this.BtSetServerPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSetServerPort.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtSetServerPort.Location = new System.Drawing.Point(268, 173);
            this.BtSetServerPort.Name = "BtSetServerPort";
            this.BtSetServerPort.Size = new System.Drawing.Size(61, 23);
            this.BtSetServerPort.TabIndex = 14;
            this.BtSetServerPort.Text = "Set";
            this.BtSetServerPort.UseVisualStyleBackColor = false;
            this.BtSetServerPort.Click += new System.EventHandler(this.BtSetServerPort_Click);
            // 
            // TbbServerStatus
            // 
            this.TbbServerStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TbbServerStatus.Enabled = false;
            this.TbbServerStatus.Location = new System.Drawing.Point(333, 199);
            this.TbbServerStatus.Name = "TbbServerStatus";
            this.TbbServerStatus.OffColor = System.Drawing.Color.OrangeRed;
            this.TbbServerStatus.OnColor = System.Drawing.Color.SpringGreen;
            this.TbbServerStatus.Size = new System.Drawing.Size(10, 10);
            this.TbbServerStatus.TabIndex = 15;
            this.TbbServerStatus.ToggleColor = System.Drawing.Color.Transparent;
            this.TbbServerStatus.ToggleState = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 217);
            this.Controls.Add(this.TbbServerStatus);
            this.Controls.Add(this.BtSetServerPort);
            this.Controls.Add(this.TbServerPort);
            this.Controls.Add(this.BtConnectToClient);
            this.Controls.Add(this.LbHostname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smoothLine3);
            this.Controls.Add(this.smoothLine2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbRemoteHost);
            this.Controls.Add(this.TbRemotePort);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "ConnectModel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.TbRemotePort, 0);
            this.Controls.SetChildIndex(this.TbRemoteHost, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.smoothLine2, 0);
            this.Controls.SetChildIndex(this.smoothLine3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.LbHostname, 0);
            this.Controls.SetChildIndex(this.BtConnectToClient, 0);
            this.Controls.SetChildIndex(this.TbServerPort, 0);
            this.Controls.SetChildIndex(this.BtSetServerPort, 0);
            this.Controls.SetChildIndex(this.TbbServerStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Se7en.UI.TextBox TbRemotePort;
        private Se7en.UI.TextBox TbRemoteHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Se7en.UI.SmoothLine smoothLine2;
        private Se7en.UI.SmoothLine smoothLine3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbHostname;
        private System.Windows.Forms.Button BtConnectToClient;
        private Se7en.UI.TextBox TbServerPort;
        private System.Windows.Forms.Button BtSetServerPort;
        private Se7en.UI.ToggleButton TbbServerStatus;
    }
}


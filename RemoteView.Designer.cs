namespace RemoteDesktop
{
    partial class RemoteView
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
            this.PnRemoteDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnRemoteDisplay
            // 
            this.PnRemoteDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnRemoteDisplay.Location = new System.Drawing.Point(0, 28);
            this.PnRemoteDisplay.Name = "PnRemoteDisplay";
            this.PnRemoteDisplay.Size = new System.Drawing.Size(800, 422);
            this.PnRemoteDisplay.TabIndex = 2;
            // 
            // RemoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnRemoteDisplay);
            this.Name = "RemoteView";
            this.Text = "RemoteView";
            this.Controls.SetChildIndex(this.PnRemoteDisplay, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnRemoteDisplay;
    }
}
namespace DNS_Changer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Wifi = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.lbl_LocalIp = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.combo_setServer = new System.Windows.Forms.ComboBox();
            this.lbl_dnsServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Wifi
            // 
            this.lbl_Wifi.AutoSize = true;
            this.lbl_Wifi.Location = new System.Drawing.Point(12, 15);
            this.lbl_Wifi.Name = "lbl_Wifi";
            this.lbl_Wifi.Size = new System.Drawing.Size(54, 15);
            this.lbl_Wifi.TabIndex = 2;
            this.lbl_Wifi.Text = "Local ip :";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 203);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(260, 46);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Connected";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lbl_LocalIp
            // 
            this.lbl_LocalIp.AutoSize = true;
            this.lbl_LocalIp.Location = new System.Drawing.Point(72, 15);
            this.lbl_LocalIp.Name = "lbl_LocalIp";
            this.lbl_LocalIp.Size = new System.Drawing.Size(12, 15);
            this.lbl_LocalIp.TabIndex = 3;
            this.lbl_LocalIp.Text = "-";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(12, 64);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(260, 136);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "InActive";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_setServer
            // 
            this.combo_setServer.FormattingEnabled = true;
            this.combo_setServer.Items.AddRange(new object[] {
            "Shecan",
            "Radar (Game)",
            "Cloudflare",
            "Google",
            "403",
            "Begzar"});
            this.combo_setServer.Location = new System.Drawing.Point(86, 38);
            this.combo_setServer.Name = "combo_setServer";
            this.combo_setServer.Size = new System.Drawing.Size(186, 23);
            this.combo_setServer.TabIndex = 5;
            this.combo_setServer.Text = "Shecan";
            // 
            // lbl_dnsServer
            // 
            this.lbl_dnsServer.AutoSize = true;
            this.lbl_dnsServer.Location = new System.Drawing.Point(12, 41);
            this.lbl_dnsServer.Name = "lbl_dnsServer";
            this.lbl_dnsServer.Size = new System.Drawing.Size(68, 15);
            this.lbl_dnsServer.TabIndex = 6;
            this.lbl_dnsServer.Text = "Dns Server :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_dnsServer);
            this.Controls.Add(this.combo_setServer);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_LocalIp);
            this.Controls.Add(this.lbl_Wifi);
            this.Controls.Add(this.btnAction);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Main";
            this.Text = "DNS Changer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Wifi;
        private Button btnAction;
        private Label lbl_LocalIp;
        private Label lbl_status;
        private ComboBox combo_setServer;
        private Label lbl_dnsServer;
    }
}
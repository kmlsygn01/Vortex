namespace Vortex
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.main_page = new MetroFramework.Controls.MetroTextBox();
            this.main_page_toplam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.main_security_ip = new MetroFramework.Controls.MetroLabel();
            this.Back_panel = new MetroFramework.Controls.MetroPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.main_security_button = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.main_sonra = new MetroFramework.Controls.MetroButton();
            this.main_once = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_sec_state = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_page
            // 
            this.main_page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.main_page.CustomButton.Image = null;
            this.main_page.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.main_page.CustomButton.Name = "";
            this.main_page.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.main_page.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.main_page.CustomButton.TabIndex = 1;
            this.main_page.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.main_page.CustomButton.UseSelectable = true;
            this.main_page.CustomButton.Visible = false;
            this.main_page.Lines = new string[] {
        "1"};
            this.main_page.Location = new System.Drawing.Point(522, 863);
            this.main_page.MaxLength = 32767;
            this.main_page.Name = "main_page";
            this.main_page.PasswordChar = '\0';
            this.main_page.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.main_page.SelectedText = "";
            this.main_page.SelectionLength = 0;
            this.main_page.SelectionStart = 0;
            this.main_page.ShortcutsEnabled = true;
            this.main_page.Size = new System.Drawing.Size(35, 23);
            this.main_page.TabIndex = 16;
            this.main_page.Text = "1";
            this.main_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.main_page.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.main_page, "Şuan ki sayfa.");
            this.main_page.UseSelectable = true;
            this.main_page.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.main_page.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.main_page.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_page_KeyDown);
            // 
            // main_page_toplam
            // 
            this.main_page_toplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_page_toplam.AutoSize = true;
            this.main_page_toplam.Location = new System.Drawing.Point(587, 865);
            this.main_page_toplam.Name = "main_page_toplam";
            this.main_page_toplam.Size = new System.Drawing.Size(14, 19);
            this.main_page_toplam.TabIndex = 17;
            this.main_page_toplam.Text = "1";
            this.main_page_toplam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.main_page_toplam, "Toplam sayfa sayısı.");
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(563, 865);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(14, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "/";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // main_security_ip
            // 
            this.main_security_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_security_ip.AutoSize = true;
            this.main_security_ip.FontSize = MetroFramework.MetroLabelSize.Small;
            this.main_security_ip.Location = new System.Drawing.Point(75, 875);
            this.main_security_ip.Name = "main_security_ip";
            this.main_security_ip.Size = new System.Drawing.Size(88, 15);
            this.main_security_ip.TabIndex = 21;
            this.main_security_ip.Text = "256.256.256.256";
            this.main_security_ip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Back_panel
            // 
            this.Back_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_panel.BackColor = System.Drawing.Color.Transparent;
            this.Back_panel.ContextMenuStrip = this.contextMenuStrip1;
            this.Back_panel.HorizontalScrollbarBarColor = true;
            this.Back_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Back_panel.HorizontalScrollbarSize = 10;
            this.Back_panel.Location = new System.Drawing.Point(7, 33);
            this.Back_panel.Name = "Back_panel";
            this.Back_panel.Size = new System.Drawing.Size(1185, 803);
            this.Back_panel.TabIndex = 29;
            this.Back_panel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Back_panel.VerticalScrollbarBarColor = true;
            this.Back_panel.VerticalScrollbarHighlightOnWheel = false;
            this.Back_panel.VerticalScrollbarSize = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Bilgi";
            // 
            // main_security_button
            // 
            this.main_security_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_security_button.BackgroundImage = global::Vortex.Properties.Resources.icons8_shield_26px;
            this.main_security_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_security_button.Location = new System.Drawing.Point(7, 857);
            this.main_security_button.Name = "main_security_button";
            this.main_security_button.Size = new System.Drawing.Size(35, 35);
            this.main_security_button.TabIndex = 23;
            this.main_security_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.main_security_button, "Vpn aktif ve deaktifleştirme.");
            this.main_security_button.UseSelectable = true;
            this.main_security_button.Click += new System.EventHandler(this.main_security_button_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.BackgroundImage = global::Vortex.Properties.Resources.icons8_info_26px;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(1116, 857);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(35, 35);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.metroButton2, "Hakkında.");
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackgroundImage = global::Vortex.Properties.Resources.icons8_settings_26px;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(1157, 857);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 35);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.metroButton1, "Ayarlar.");
            this.metroButton1.UseSelectable = true;
            // 
            // main_sonra
            // 
            this.main_sonra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_sonra.BackgroundImage = global::Vortex.Properties.Resources.icons8_forward_26px;
            this.main_sonra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_sonra.Location = new System.Drawing.Point(609, 857);
            this.main_sonra.Name = "main_sonra";
            this.main_sonra.Size = new System.Drawing.Size(35, 35);
            this.main_sonra.TabIndex = 15;
            this.main_sonra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.main_sonra, "Sonraki sayfa.");
            this.main_sonra.UseSelectable = true;
            this.main_sonra.Click += new System.EventHandler(this.main_sonra_Click);
            // 
            // main_once
            // 
            this.main_once.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_once.BackgroundImage = global::Vortex.Properties.Resources.icons8_back_26px_2;
            this.main_once.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_once.Location = new System.Drawing.Point(472, 857);
            this.main_once.Name = "main_once";
            this.main_once.Size = new System.Drawing.Size(35, 35);
            this.main_once.TabIndex = 14;
            this.main_once.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.main_once, "Önceki sayfa.");
            this.main_once.UseSelectable = true;
            this.main_once.Click += new System.EventHandler(this.main_once_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Vortex.Properties.Resources.icons8_ip_address_26px;
            this.pictureBox1.Location = new System.Drawing.Point(50, 862);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // main_sec_state
            // 
            this.main_sec_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_sec_state.AutoSize = true;
            this.main_sec_state.FontSize = MetroFramework.MetroLabelSize.Small;
            this.main_sec_state.Location = new System.Drawing.Point(75, 860);
            this.main_sec_state.Name = "main_sec_state";
            this.main_sec_state.Size = new System.Drawing.Size(38, 15);
            this.main_sec_state.TabIndex = 30;
            this.main_sec_state.Text = "Vpn ...";
            this.main_sec_state.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 5;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.main_sec_state);
            this.Controls.Add(this.main_security_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.main_security_ip);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.main_page_toplam);
            this.Controls.Add(this.main_page);
            this.Controls.Add(this.main_sonra);
            this.Controls.Add(this.main_once);
            this.Controls.Add(this.Back_panel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana sayfa";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroButton main_once;
        public MetroFramework.Controls.MetroButton main_sonra;
        private MetroFramework.Controls.MetroTextBox main_page;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel main_page_toplam;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroLabel main_security_ip;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroButton main_security_button;
        public MetroFramework.Controls.MetroPanel Back_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        public MetroFramework.Controls.MetroLabel main_sec_state;
        private System.Windows.Forms.Timer timer1;
    }
}
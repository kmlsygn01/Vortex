namespace Vortex
{
    partial class Launcher
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
            this.progress_login = new MetroFramework.Controls.MetroProgressSpinner();
            this.chk_remember = new MetroFramework.Controls.MetroCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_sign = new MetroFramework.Controls.MetroButton();
            this.bildirimLB = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.launch_api = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress_login
            // 
            this.progress_login.Enabled = false;
            this.progress_login.Location = new System.Drawing.Point(437, 33);
            this.progress_login.Maximum = 100;
            this.progress_login.Name = "progress_login";
            this.progress_login.Size = new System.Drawing.Size(40, 40);
            this.progress_login.TabIndex = 0;
            this.progress_login.UseSelectable = true;
            this.progress_login.Visible = false;
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Location = new System.Drawing.Point(31, 281);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(58, 15);
            this.chk_remember.TabIndex = 5;
            this.chk_remember.Text = "Hatırla";
            this.chk_remember.UseSelectable = true;
            this.chk_remember.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "VORTEX";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(169, 273);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(95, 273);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(68, 23);
            this.btn_sign.TabIndex = 9;
            this.btn_sign.Text = "Kayıt Ol";
            this.btn_sign.UseSelectable = true;
            this.btn_sign.Visible = false;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // bildirimLB
            // 
            this.bildirimLB.AutoSize = true;
            this.bildirimLB.ForeColor = System.Drawing.Color.White;
            this.bildirimLB.Location = new System.Drawing.Point(9, 5);
            this.bildirimLB.Name = "bildirimLB";
            this.bildirimLB.Size = new System.Drawing.Size(54, 19);
            this.bildirimLB.TabIndex = 10;
            this.bildirimLB.Text = "Bildirim";
            this.bildirimLB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bildirimLB.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.bildirimLB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(31, 226);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(213, 31);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Api Anahtarı :";
            // 
            // launch_api
            // 
            // 
            // 
            // 
            this.launch_api.CustomButton.Image = null;
            this.launch_api.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.launch_api.CustomButton.Name = "";
            this.launch_api.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.launch_api.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.launch_api.CustomButton.TabIndex = 1;
            this.launch_api.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.launch_api.CustomButton.UseSelectable = true;
            this.launch_api.CustomButton.Visible = false;
            this.launch_api.Enabled = false;
            this.launch_api.Lines = new string[] {
        "10f2d34d"};
            this.launch_api.Location = new System.Drawing.Point(32, 197);
            this.launch_api.MaxLength = 32767;
            this.launch_api.Name = "launch_api";
            this.launch_api.PasswordChar = '\0';
            this.launch_api.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.launch_api.SelectedText = "";
            this.launch_api.SelectionLength = 0;
            this.launch_api.SelectionStart = 0;
            this.launch_api.ShortcutsEnabled = true;
            this.launch_api.Size = new System.Drawing.Size(212, 23);
            this.launch_api.TabIndex = 12;
            this.launch_api.Text = "10f2d34d";
            this.launch_api.UseSelectable = true;
            this.launch_api.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.launch_api.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Vortex.Properties.Resources.logo_vortex_main;
            this.pictureBox1.Location = new System.Drawing.Point(276, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.launch_api);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.progress_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_remember);
            this.DisplayHeader = false;
            this.Name = "Launcher";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner progress_login;
        private MetroFramework.Controls.MetroCheckBox chk_remember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_sign;
        private MetroFramework.Controls.MetroLabel bildirimLB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox launch_api;
    }
}
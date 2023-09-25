namespace Vortex
{
    partial class LBO
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
            this.item_Hd_Lab = new MetroFramework.Controls.MetroLabel();
            this.item_Hd_Toggle = new MetroFramework.Controls.MetroToggle();
            this.item_Trailer = new MetroFramework.Controls.MetroButton();
            this.item_propertis = new MetroFramework.Controls.MetroLabel();
            this.item_Watch = new MetroFramework.Controls.MetroButton();
            this.item_Name = new MetroFramework.Controls.MetroLabel();
            this.item_Desc = new MetroFramework.Controls.MetroLabel();
            this.item_hash = new MetroFramework.Controls.MetroLabel();
            this.item_youtube = new MetroFramework.Controls.MetroLabel();
            this.item_altyaz = new MetroFramework.Controls.MetroLabel();
            this.item_imdb = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.item_geri = new MetroFramework.Controls.MetroButton();
            this.hd_pic = new System.Windows.Forms.PictureBox();
            this.item_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hd_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // item_Hd_Lab
            // 
            this.item_Hd_Lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Hd_Lab.AutoSize = true;
            this.item_Hd_Lab.Location = new System.Drawing.Point(433, 457);
            this.item_Hd_Lab.Name = "item_Hd_Lab";
            this.item_Hd_Lab.Size = new System.Drawing.Size(35, 19);
            this.item_Hd_Lab.TabIndex = 28;
            this.item_Hd_Lab.Text = "1080";
            this.item_Hd_Lab.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // item_Hd_Toggle
            // 
            this.item_Hd_Toggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Hd_Toggle.AutoSize = true;
            this.item_Hd_Toggle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_Hd_Toggle.Checked = true;
            this.item_Hd_Toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.item_Hd_Toggle.DisplayStatus = false;
            this.item_Hd_Toggle.Location = new System.Drawing.Point(474, 458);
            this.item_Hd_Toggle.Name = "item_Hd_Toggle";
            this.item_Hd_Toggle.Size = new System.Drawing.Size(50, 17);
            this.item_Hd_Toggle.TabIndex = 27;
            this.item_Hd_Toggle.Text = "On";
            this.item_Hd_Toggle.UseSelectable = true;
            this.item_Hd_Toggle.CheckedChanged += new System.EventHandler(this.item_Hd_Toggle_CheckedChanged);
            // 
            // item_Trailer
            // 
            this.item_Trailer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Trailer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.item_Trailer.Location = new System.Drawing.Point(542, 443);
            this.item_Trailer.Name = "item_Trailer";
            this.item_Trailer.Size = new System.Drawing.Size(102, 42);
            this.item_Trailer.TabIndex = 26;
            this.item_Trailer.Text = "Fragman";
            this.item_Trailer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_Trailer.UseSelectable = true;
            this.item_Trailer.Click += new System.EventHandler(this.item_Trailer_Click);
            // 
            // item_propertis
            // 
            this.item_propertis.AutoSize = true;
            this.item_propertis.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.item_propertis.ForeColor = System.Drawing.Color.White;
            this.item_propertis.Location = new System.Drawing.Point(23, 37);
            this.item_propertis.Name = "item_propertis";
            this.item_propertis.Size = new System.Drawing.Size(138, 19);
            this.item_propertis.TabIndex = 23;
            this.item_propertis.Text = "2019   •   118 Dk   • ";
            this.item_propertis.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_propertis.UseCustomForeColor = true;
            this.item_propertis.WrapToLine = true;
            // 
            // item_Watch
            // 
            this.item_Watch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Watch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.item_Watch.Location = new System.Drawing.Point(650, 443);
            this.item_Watch.Name = "item_Watch";
            this.item_Watch.Size = new System.Drawing.Size(102, 42);
            this.item_Watch.TabIndex = 22;
            this.item_Watch.Text = "İzle";
            this.item_Watch.UseSelectable = true;
            this.item_Watch.Click += new System.EventHandler(this.item_Watch_Click);
            // 
            // item_Name
            // 
            this.item_Name.AutoSize = true;
            this.item_Name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.item_Name.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.item_Name.ForeColor = System.Drawing.Color.White;
            this.item_Name.Location = new System.Drawing.Point(20, 13);
            this.item_Name.Name = "item_Name";
            this.item_Name.Size = new System.Drawing.Size(101, 25);
            this.item_Name.TabIndex = 21;
            this.item_Name.Text = "Test Name";
            this.item_Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.item_Name, "Imdb yönlendirme.");
            this.item_Name.UseCustomForeColor = true;
            this.item_Name.Click += new System.EventHandler(this.item_Name_Click);
            this.item_Name.MouseLeave += new System.EventHandler(this.item_Name_MouseLeave);
            this.item_Name.MouseHover += new System.EventHandler(this.item_Name_MouseHover);
            // 
            // item_Desc
            // 
            this.item_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_Desc.ForeColor = System.Drawing.Color.White;
            this.item_Desc.Location = new System.Drawing.Point(308, 59);
            this.item_Desc.Name = "item_Desc";
            this.item_Desc.Size = new System.Drawing.Size(444, 372);
            this.item_Desc.TabIndex = 24;
            this.item_Desc.Text = "metroLabel2";
            this.item_Desc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_Desc.UseCustomForeColor = true;
            this.item_Desc.WrapToLine = true;
            // 
            // item_hash
            // 
            this.item_hash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.item_hash.AutoSize = true;
            this.item_hash.Location = new System.Drawing.Point(6, 479);
            this.item_hash.Name = "item_hash";
            this.item_hash.Size = new System.Drawing.Size(35, 19);
            this.item_hash.TabIndex = 29;
            this.item_hash.Text = "hash";
            this.item_hash.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_hash.Visible = false;
            // 
            // item_youtube
            // 
            this.item_youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.item_youtube.AutoSize = true;
            this.item_youtube.Location = new System.Drawing.Point(82, 479);
            this.item_youtube.Name = "item_youtube";
            this.item_youtube.Size = new System.Drawing.Size(56, 19);
            this.item_youtube.TabIndex = 31;
            this.item_youtube.Text = "youtube";
            this.item_youtube.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_youtube.Visible = false;
            // 
            // item_altyaz
            // 
            this.item_altyaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.item_altyaz.AutoSize = true;
            this.item_altyaz.Location = new System.Drawing.Point(182, 479);
            this.item_altyaz.Name = "item_altyaz";
            this.item_altyaz.Size = new System.Drawing.Size(45, 19);
            this.item_altyaz.TabIndex = 32;
            this.item_altyaz.Text = "altyazi";
            this.item_altyaz.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_altyaz.Visible = false;
            // 
            // item_imdb
            // 
            this.item_imdb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.item_imdb.AutoSize = true;
            this.item_imdb.Location = new System.Drawing.Point(6, 464);
            this.item_imdb.Name = "item_imdb";
            this.item_imdb.Size = new System.Drawing.Size(40, 19);
            this.item_imdb.TabIndex = 34;
            this.item_imdb.Text = "imdb";
            this.item_imdb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_imdb.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bilgi";
            // 
            // item_geri
            // 
            this.item_geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.item_geri.BackgroundImage = global::Vortex.Properties.Resources.icons8_back_26px_2;
            this.item_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.item_geri.Location = new System.Drawing.Point(717, 13);
            this.item_geri.Name = "item_geri";
            this.item_geri.Size = new System.Drawing.Size(35, 35);
            this.item_geri.TabIndex = 33;
            this.item_geri.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.item_geri.UseSelectable = true;
            this.item_geri.Click += new System.EventHandler(this.item_geri_Click);
            // 
            // hd_pic
            // 
            this.hd_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hd_pic.BackgroundImage = global::Vortex.Properties.Resources.icons8_hdtv_26px;
            this.hd_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hd_pic.Location = new System.Drawing.Point(407, 453);
            this.hd_pic.Name = "hd_pic";
            this.hd_pic.Size = new System.Drawing.Size(25, 25);
            this.hd_pic.TabIndex = 30;
            this.hd_pic.TabStop = false;
            this.toolTip1.SetToolTip(this.hd_pic, "1080p Kalite");
            // 
            // item_Pic
            // 
            this.item_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.item_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.item_Pic.ErrorImage = null;
            this.item_Pic.InitialImage = global::Vortex.Properties.Resources.preloader;
            this.item_Pic.Location = new System.Drawing.Point(20, 59);
            this.item_Pic.Name = "item_Pic";
            this.item_Pic.Size = new System.Drawing.Size(275, 409);
            this.item_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.item_Pic.TabIndex = 20;
            this.item_Pic.TabStop = false;
            this.toolTip1.SetToolTip(this.item_Pic, "Resim adresi.");
            this.item_Pic.Click += new System.EventHandler(this.item_Pic_Click);
            // 
            // LBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 500);
            this.ControlBox = false;
            this.Controls.Add(this.item_imdb);
            this.Controls.Add(this.item_geri);
            this.Controls.Add(this.item_altyaz);
            this.Controls.Add(this.item_youtube);
            this.Controls.Add(this.hd_pic);
            this.Controls.Add(this.item_hash);
            this.Controls.Add(this.item_Hd_Lab);
            this.Controls.Add(this.item_Hd_Toggle);
            this.Controls.Add(this.item_Trailer);
            this.Controls.Add(this.item_Desc);
            this.Controls.Add(this.item_propertis);
            this.Controls.Add(this.item_Watch);
            this.Controls.Add(this.item_Name);
            this.Controls.Add(this.item_Pic);
            this.DisplayHeader = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(775, 500);
            this.Name = "LBO";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "LBO";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LBO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hd_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel item_Hd_Lab;
        public MetroFramework.Controls.MetroToggle item_Hd_Toggle;
        public MetroFramework.Controls.MetroButton item_Trailer;
        public MetroFramework.Controls.MetroLabel item_propertis;
        public MetroFramework.Controls.MetroButton item_Watch;
        public MetroFramework.Controls.MetroLabel item_Name;
        public System.Windows.Forms.PictureBox item_Pic;
        public MetroFramework.Controls.MetroLabel item_Desc;
        public MetroFramework.Controls.MetroLabel item_hash;
        private System.Windows.Forms.PictureBox hd_pic;
        public MetroFramework.Controls.MetroLabel item_youtube;
        public MetroFramework.Controls.MetroLabel item_altyaz;
        private MetroFramework.Controls.MetroButton item_geri;
        public MetroFramework.Controls.MetroLabel item_imdb;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}
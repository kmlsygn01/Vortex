namespace Vortex
{
    partial class Buton_list
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buton_list));
            this.buton_yili = new MetroFramework.Controls.MetroLabel();
            this.buton_isim = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buton_yili
            // 
            this.buton_yili.AutoSize = true;
            this.animator1.SetDecoration(this.buton_yili, AnimatorNS.DecorationType.None);
            this.buton_yili.FontSize = MetroFramework.MetroLabelSize.Small;
            this.buton_yili.ForeColor = System.Drawing.Color.White;
            this.buton_yili.Location = new System.Drawing.Point(1, 19);
            this.buton_yili.Name = "buton_yili";
            this.buton_yili.Size = new System.Drawing.Size(16, 15);
            this.buton_yili.TabIndex = 29;
            this.buton_yili.Text = "yıl";
            this.buton_yili.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buton_yili.UseCustomForeColor = true;
            this.buton_yili.Click += new System.EventHandler(this.pictureBox_Click);
            this.buton_yili.MouseHover += new System.EventHandler(this.buton_isim_MouseHover);
            // 
            // buton_isim
            // 
            this.buton_isim.AutoSize = true;
            this.animator1.SetDecoration(this.buton_isim, AnimatorNS.DecorationType.None);
            this.buton_isim.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.buton_isim.ForeColor = System.Drawing.Color.White;
            this.buton_isim.Location = new System.Drawing.Point(-3, 2);
            this.buton_isim.Name = "buton_isim";
            this.buton_isim.Size = new System.Drawing.Size(36, 19);
            this.buton_isim.TabIndex = 28;
            this.buton_isim.Text = "isim";
            this.buton_isim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buton_isim.UseCustomForeColor = true;
            this.buton_isim.WrapToLine = true;
            this.buton_isim.Click += new System.EventHandler(this.pictureBox_Click);
            this.buton_isim.MouseLeave += new System.EventHandler(this.buton_isim_MouseLeave);
            this.buton_isim.MouseHover += new System.EventHandler(this.buton_isim_MouseHover);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.buton_yili);
            this.metroPanel1.Controls.Add(this.buton_isim);
            this.animator1.SetDecoration(this.metroPanel1, AnimatorNS.DecorationType.None);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 223);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(150, 42);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Particles;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.MaxAnimationTime = 1200;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.animator1.SetDecoration(this.pictureBox, AnimatorNS.DecorationType.None);
            this.pictureBox.ErrorImage = global::Vortex.Properties.Resources.icons8_broken_link_26px;
            this.pictureBox.InitialImage = global::Vortex.Properties.Resources.preloader;
            this.pictureBox.Location = new System.Drawing.Point(20, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 202);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // Buton_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "Buton_list";
            this.Size = new System.Drawing.Size(187, 270);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Buton_list_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public MetroFramework.Controls.MetroLabel buton_yili;
        public MetroFramework.Controls.MetroLabel buton_isim;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private AnimatorNS.Animator animator1;
    }
}

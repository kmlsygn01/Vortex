using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex
{
    public partial class LBO : MetroFramework.Forms.MetroForm
    {
        public LBO()
        {
            InitializeComponent();
        }
        private void LBO_Load(object sender, EventArgs e)
        {
            item_Pic.SizeMode = PictureBoxSizeMode.Zoom;//resme zum
        }

        private void item_Watch_Click(object sender, EventArgs e)
        {
            if(item_hash.Text != "hash")
            {                

                Player ps = new Player();//form yaratma
                ps.vlc_hash = item_hash.Text;//diğer forma hash kodu yollama
                ps.ShowDialog();//formu öncü aç arkakiler erişimsiz

            }
             //MessageBox.Show("Dosya hatası! Film indirme sorunu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void item_Trailer_Click(object sender, EventArgs e)
        {
            if (item_youtube.Text != "youtube")
            {
                Player ps = new Player();//form yaratma
                ps.vlc_youtube = item_youtube.Text;//tanıtım video yollama
                ps.ShowDialog();//formu öncü aç arkakiler erişimsiz
            }
        }

        private void item_Hd_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (item_Hd_Toggle.Checked)//hd kontrolü
            {
                item_Hd_Lab.Text = "1080";
                hd_pic.Visible = true;
            }
            else
            {
                item_Hd_Lab.Text = "720";
                hd_pic.Visible = false;
            }
        }

        private void item_geri_Click(object sender, EventArgs e)
        {
            this.Visible = false;//formu gizle
        }

        private void item_Pic_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(item_Pic.ImageLocation);//resim adres sayfası
            }
            catch
            {; }
        }

        private void item_Name_MouseHover(object sender, EventArgs e)
        {
            item_Name.ForeColor = Color.Turquoise;//yazıya ışık efekt
            item_Name.Refresh();
        }

        private void item_Name_MouseLeave(object sender, EventArgs e)
        {
            item_Name.ForeColor = Color.White;
            item_Name.Refresh();
        }

        private void item_Name_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(item_imdb.Text);//isme tıklayınca imdb sayfası
            }
            catch
            {; }
        }
    }
}

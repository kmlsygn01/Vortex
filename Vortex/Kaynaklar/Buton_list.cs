using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatorNS;
using System.IO;
using System.Diagnostics;

namespace Vortex
{
    public partial class Buton_list : MetroFramework.Controls.MetroUserControl
    {
        public Buton_list()
        {
            InitializeComponent();
        }
        
        public string v1 { get; set; }//hash
        public string v2 { get; set; }//id imdb
        public string v3 { get; set; }//video
        public string v4 { get; set; }//altyazı
        public string v5 { get; set; }//boş
        public string v6 { get; set; }//boş
        public string v7 { get; set; }//boş

        LBO bilgiler = new LBO();//form yaratma
        public void pictureBox_Click(object sender, EventArgs e)
        {
            imdb xml = new imdb();//class yaratma
            xml.xmlokuma(v2);//imdb gelen veriyi okuma
            bilgiler.item_Name.Text = xml.title;//adı
            bilgiler.item_Desc.Text = xml.description;//açıklama
            bilgiler.item_propertis.Text = xml.year + " • "/*yılı*/
                + xml.runtime + " • "/*süresi*/
                + xml.genre + " • Meta = "/*türü*/
                + xml.metascore + " • Imdb = "/*meta puanı*/
                + xml.imdbRating;/*imdb yılı*/
            bilgiler.item_Pic.ImageLocation = xml.poster;//resim
            bilgiler.item_hash.Text = v1;//hash
            bilgiler.item_youtube.Text = v3;//tanıtım videosu
            bilgiler.item_altyaz.Text = v4;//altyazı
            bilgiler.item_imdb.Text = "https://www.imdb.com/title/"+v2+"/";//imdb adresi
            bilgiler.Visible = true;//form görünürlük

            animator1.HideSync(pictureBox);//animasyon
        }

        private void buton_isim_MouseHover(object sender, EventArgs e)
        {
            buton_isim.ForeColor = Color.Turquoise;//yazıya ışık efekt
            buton_yili.ForeColor = Color.Turquoise;
            buton_isim.Refresh();//içerik yenile
            buton_yili.Refresh();
        }
        

        private void buton_isim_MouseLeave(object sender, EventArgs e)
        {
            buton_isim.ForeColor = Color.White;
            buton_yili.ForeColor = Color.White;
            buton_isim.Refresh();
            buton_yili.Refresh();
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            animator1.ShowSync(pictureBox);//animasyon
            //animator1.EndUpdate(pictureBox);
        }

        private void Buton_list_Load(object sender, EventArgs e)
        {
            // animator1.ShowSync(pictureBox);
            animator1.BeginUpdate(pictureBox);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace Vortex
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }


        public bool baglanti = false;//vpn için açık kapalı değişkeni
        Vpn baglan = new Vpn();//vpn sınıf oluşturma
        private void main_security_button_Click(object sender, EventArgs e)
        {//vpn buton aktif 
            if (baglanti == true)
            {
                main_security_button.BackgroundImage = Properties.Resources.icons8_restriction_shield_26px;//hatalı
                baglan.Kapat();
                baglanti = false;
                main_sec_state.Text = "Vpn kapalı!"; 
            }
            else
            {
                main_security_button.BackgroundImage = Properties.Resources.icons8_security_checked_26px;//doğru    
                baglan.Ac();
                baglanti = true;
                main_sec_state.Text = "Vpn aktif!";
                timer1.Start();
            }
           }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               main_security_ip.Text = new WebClient().DownloadString("https://api.ipify.org/");/*https://ipinfo.io/ip*/
            }
            catch
            {; }
        }
        public LBO bilgiler = new LBO();//form tanımlama
        private void Main_Load(object sender, EventArgs e)
        {            
            buton_olustur("1");//ilk sayfa
            if (baglanti == true)//vpn bağlantı kontrol
            {
                main_security_button.BackgroundImage = Properties.Resources.icons8_security_checked_26px;//doğru    
                main_sec_state.Text = "Vpn aktif!";
            }
            else
            {
                main_security_button.BackgroundImage = Properties.Resources.icons8_restriction_shield_26px;//hatalı
                main_sec_state.Text = "Vpn kapalı!";
            }
            main_security_ip.Text = new WebClient().DownloadString("https://api.ipify.org/");
            timer1.Enabled = true;
            bilgiler.Show();//formu aç
            bilgiler.Visible = false;//formu gizle
        }

        public void buton_olustur(string sayfa)
        {
            try
            {
                int sol = 10, yuk = 0;//butonlar için ilk lokasyon
                string line;
                int buton_num = 0;//oluşacak buton sayısı
                StreamReader file = new StreamReader(Application.StartupPath + @"\\depo\\alt" + sayfa);//istenen sayfayı dosyadan oku
                while ((line = file.ReadLine()) != null)//Eğer okunan satırda veri varsa line'a aktar
                {
                    //Buton oluşturma ve özellikler
                    Buton_list newbuton = new Buton_list();
                    {
                        newbuton.BackColor = Color.Transparent;//arka renk saydam
                        newbuton.Location = new Point(sol, yuk);//lokasyon
                        newbuton.Name = "buton_list" + buton_num;//oluşan butona isim verme ve numaralandırma
                        newbuton.Size = new Size(187, 270);//boyut
                        newbuton.Theme = MetroFramework.MetroThemeStyle.Dark;//tema
                        newbuton.UseSelectable = true;//seçilebilirlik
                        newbuton.Visible = true;//görünürlük
                        if (newbuton.Location.X >= 900)//900 lokasyonundan geniş ise
                        {
                            //Lokasyonu alt satır ekleme
                            sol = 10;//en başa getir
                            yuk = yuk + 270;//270 piksel alta geç
                        }
                        else
                        {
                            //Yanyana ekleme
                            sol = newbuton.Location.X + newbuton.Size.Width + 10;
                        }
                        Back_panel.Controls.Add(newbuton);//butonu ekle
                        Satiroku(line);//satırı ayıklamak için yolla

                        //customcontrol butonuna değerleri aktar
                        newbuton.v1 = butonv1;//hash
                        newbuton.v2 = butonv2;//imdb id
                        newbuton.v3 = butonv3;//tanıtım video
                        newbuton.v4 = butonv4;//altyazı
                        newbuton.v5 = butonv5;//boş
                        newbuton.v6 = butonv6;//boş
                        newbuton.v7 = butonv7;//boş
                        newbuton.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;//resmi genişlet
                        newbuton.pictureBox.ImageLocation = pic_loc;//resim adresi yolu
                        newbuton.buton_isim.Text = butonisim;//buton başlığı - isim
                        newbuton.buton_yili.Text = butonyili;//buton alt başlığı - yıl
                        buton_num++;//buton numarasını 1 arttır
                    }
                }
                file.Close();//okunan dosya kullanımı kapat

            }
            catch
            {
                buton_olustur("1");//sorun oluşursa kodu başa sar
                MessageBox.Show("Sayfa ve buton oluşturma sorunu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refresh()
        {
            Back_panel.Refresh();//paneli yenile
        }
        public void temizle(int k)
        {//panel içi buton temizleme
            for (int i = 0; i <= k; i++)//i'kadar çalıştır
            {
                foreach (Control item in Back_panel.Controls.OfType<Buton_list>())//paneldeki butonları bul
                {
                    Back_panel.Controls.Remove(item);//bulunan butonları kaldır
                    refresh();
                }
            }
        }
        private void main_sonra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(main_page.Text) != Convert.ToInt32(main_page_toplam.Text))//eğer son sayfa değilse
            {
                try
                {
                    temizle(5);//panel içi buton temizleme
                }
                finally
                {
                    main_page.Text = Convert.ToString(Convert.ToInt32(main_page.Text) + 1);//sayfa değerini arttır
                    buton_olustur(main_page.Text);//butonları baştan yarat
                }
            }
        }
        private void main_once_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(main_page.Text) != 1)//eğer ilk sayfa değilse
            {
                try
                {
                    temizle(5);//panel içi buton temizleme
                }
                finally
                {
                    main_page.Text = Convert.ToString(Convert.ToInt32(main_page.Text) - 1);//sayfa değerini eksilt
                    buton_olustur(main_page.Text);//butonları baştan yarat
                }
            }
        }
        
        
        private void main_page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//entere basınca
            {
                buton_olustur(main_page.Text);
            }
        }

        public string pic_loc { get; set; } //aktarılabilir değer oluşturma
        public string butonisim { get; set; }
        public string butonyili { get; set; }
        public string butonv1 { get; set; }
        public string butonv2 { get; set; }
        public string butonv3 { get; set; }
        public string butonv4 { get; set; }
        public string butonv5 { get; set; }
        public string butonv6 { get; set; }
        public string butonv7 { get; set; }
        private void Satiroku(string veri)
        {//değerlere veri aktarma
            string[] split;
            split = veri.Split('•');// • işareti ile böl ve oku
            butonv1 = split[0].ToString();//filehash
            butonv2 = split[1].ToString();//imdbID
            butonv3 = split[2].ToString();//fragman
            butonv4 = split[3].ToString();//altyazı
            //butonv5 = split[4].ToString();//boş
            //butonv6 = split[5].ToString();//boş
            //butonv7 = split[6].ToString();//boş

            imdb xml = new imdb();
            try
            {
                xml.xmlokuma(butonv2);//id ile oku ve veri çek
                pic_loc = xml.poster;//pictureBox.ImageLocation adresi
                butonisim = xml.title;//başlık
                butonyili = xml.year;//yıl
            }
            catch
            {
                try
                {
                    MessageBox.Show("Bağlantı sorunu VPN aktifleştiriliyor. Kapatmak için, program sol alt köşesinde buton bulunmakta!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); Application.Exit();

                    baglan.Ac();
                    xml.xmlokuma(butonv2);
                    baglanti = true;
                    MessageBox.Show("Program kapatılıyor, tekrar açınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); Application.Exit();
                    Application.Exit();
                }
                catch
                {
                    ;// MessageBox.Show("Api anahtar kullanımı dolmuştur program sahibi ile görüşünüz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); Application.Exit();
                }
            }

           

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {//verileri yenile
            Refresh();
            refresh();
        }

        public static void DeleteDirectory(string target_dir)
        {//zorla klasör içeriği kaldırma kodu
            try
            { 
            string[] files = Directory.GetFiles(target_dir);//dosyalar
            string[] dirs = Directory.GetDirectories(target_dir);//klasörler

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);//dosya özelliğini normalleştir
                File.Delete(file);//dosya sil
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);//klasörü sil
            }

            Directory.Delete(target_dir, false);//klasörü sil
            }
            catch
            { ; }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string UygulamaKonum = Application.StartupPath + @"\\depo";
            try
            {
                DeleteDirectory(UygulamaKonum);//dosyaları kaldır
            }
            catch
            {
                Directory.CreateDirectory(UygulamaKonum);//eğer bulamazsa ve hata alırsa oluştur
            }
            Application.Exit();// :) Uygulamayı kapat
        }

    }
}

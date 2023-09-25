using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Vortex
{

    public partial class Launcher : MetroFramework.Forms.MetroForm
    {
        public Launcher()
        {
            InitializeComponent();
        }
        //sayfaların olduğu adres, inecek dosya adı, uygulama adresi ve indirme konumu
        public string anaURL = "https://raw.githubusercontent.com/kmlsygn01/ArcHive/master/vortex/ana", DosyaAdi = "ana", UygulamaKonum = Application.StartupPath + "\\depo";
        private void Launcher_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(UygulamaKonum))//klasör yoksa
                Directory.CreateDirectory(UygulamaKonum);//klasör oluştur
        }
        Uri yol, yol2;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string anahtar = launch_api.Text;

            string apikey = new WebClient().DownloadString("https://raw.githubusercontent.com/kmlsygn01/ArcHive/master/vortex/apikey");//anahtar al
            if (anahtar != apikey)//anahtar kontrolü doğru ise   /********  Şuanlık sorunlu sistem  ********/
            {
                

                WebClient indirrrr = new WebClient();//bağlantı oluşturma
                yol = new Uri(anaURL);//url tanımlama
                indirrrr.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DosyaIndir);//indirme sırasında oluşan değişim
                indirrrr.DownloadFileCompleted += new AsyncCompletedEventHandler(Indirildi);//indirme tamamlanınca
                indirrrr.DownloadFileAsync(yol, UygulamaKonum + "\\" + DosyaAdi);//dosyayı konuma indir
                progress_login.Visible = true;
            }
            else
            {
                metroPanel1.Visible = true;//bildirim panelini göster
                bildirimLB.Text = "Api anahtarı hatalı!";//"Api anahtarı hatalı";
            }
        }
        private void DosyaIndir(object sender, DownloadProgressChangedEventArgs e)
        {
            progress_login.Value = e.ProgressPercentage;//loading animasyonuna indirme değerini aktar
        }

        int filenum = 1;//dosya numarası
        private void Indirildi(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == false)//iptal edilmediyse
            {
                string line;
                StreamReader file = new StreamReader(UygulamaKonum + "\\" + DosyaAdi);//dosya oku
                while ((line = file.ReadLine()) != null)//satırdaki değer boş değilse
                {
                    WebClient test = new WebClient();//bağlantı oluşturma
                    yol2 = new Uri(line);//url tanımlama
                    test.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DosyaIndir);//indirme sırasında oluşan değişim
                    test.DownloadFileCompleted += new AsyncCompletedEventHandler(finitto);//indirme tamamlanınca
                    test.DownloadFileAsync(yol2, UygulamaKonum + "\\alt" + Convert.ToString(filenum));//dosyayı konuma indir

                    filenum++;//dosya ismini arttır
                }
                file.Close();//dosya kullanımı kapat
            }
            else
            {
                ;//İşlem iptal edildi
            }
        }

        Main mm = new Main();//form tanımlama
        private void finitto(object sender, AsyncCompletedEventArgs e)
        {
            progress_login.Visible = true;//animasyonu oynat
            this.Visible = false;
            Wait(8);//veri ile işlemlerin bitmesi için uygulamayı dinlendir
            mm.main_page_toplam.Text = Convert.ToString(filenum - 1); //fazla gelen sayfa değerini eksilt ve aktar
            mm.Show();//formu öncü aç arkakiler erişimsiz
            //MessageBox.Show("test");
        }
        private void btn_sign_Click(object sender, EventArgs e)
        {//kayıt butonu şuanlık yok
            Main mm = new Main();//form tanımlama
            mm.ShowDialog();//formu öncü aç arkakiler erişimsiz

        }

        public void Wait(int milliseconds)
        {//uygulama dinlendirme
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();//olayları çalıştır
            }
        }
    }
}

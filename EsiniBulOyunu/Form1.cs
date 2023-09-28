namespace EsiniBulOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int boyut = 2;
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();
        List<PictureBox> aciklar = new List<PictureBox>();
        int yokEdilenAdet = 0;
        public Form1()
        {
            ResimleriYukle();
            InitializeComponent();
        }

        private void KartlariDiz()
        {
            int bosluk = 4;
            int gen = (pnlKartlar.Width - ((boyut - 1) * bosluk)) / boyut;
            int yuk = (pnlKartlar.Height - ((boyut - 1) * bosluk)) / boyut;

            int i = 0;
            for (int y = 0; y < boyut; y++)
            {
                for (int x = 0; x < boyut; x++)
                {
                    PictureBox resimKutusu = new PictureBox();
                    resimKutusu.Tag = i;
                    resimKutusu.BackColor = Color.Bisque;
                    resimKutusu.Size = new Size(gen, yuk);
                    resimKutusu.Left = x * (resimKutusu.Width + bosluk); // x * 50
                    resimKutusu.Top = y * (resimKutusu.Height + bosluk); // y * 50
                    resimKutusu.ImageLocation = "back.jpg";
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    resimKutusu.Click += ResimKutusu_Click;
                    pnlKartlar.Controls.Add(resimKutusu);
                    i++;
                }
            }

        }

        //sender: týklanan resim kutusunu taþýr.
        private void ResimKutusu_Click(object sender, EventArgs e)
        {
            PictureBox tiklanan = (PictureBox)sender;
            // eðer ayný karta 2.kez týklandýysa bir þey yapmadan çýk
            if (aciklar.Count == 1 && aciklar[0] == tiklanan)
                return;

            if (aciklar.Count == 2)
                AciklariKapat();


            aciklar.Add(tiklanan);
            int kartIndeks = (int)tiklanan.Tag;
            string resim = kartlar[kartIndeks];
            tiklanan.ImageLocation = resim;

            //tiklanan.Hide();

            // 2. kart açýnca yapýlacak eþ kontrol
            if (aciklar.Count == 2 && aciklar[0].ImageLocation == aciklar[1].ImageLocation)
            {
                Application.DoEvents();
                AciklariGecikmeliYoket();
                AciklariKapat();

                //Oyun Bitti Mi
                if (yokEdilenAdet == kartlar.Count)
                {
                    MessageBox.Show("Oyun bitti.");
                    OyunuSifirla();
                }

            }

        }

        private void OyunuSifirla()
        {
            pnlKartlar.Controls.Clear();
            yokEdilenAdet = 0;
            kartlar.Clear();
            aciklar.Clear();
            panel1.Show();
        }

        private void AciklariGecikmeliYoket()
        {
            Thread.Sleep(500);
            foreach (var kutu in aciklar)
            {
                pnlKartlar.Controls.Remove(kutu);
                yokEdilenAdet++;
            }
        }

        private void AciklariKapat()
        {
            foreach (var kutu in aciklar)
            {
                kutu.ImageLocation = "back.jpg";
            }
            aciklar.Clear();
        }

        private void KartlariSec()
        {
            int ciftAdet = boyut * boyut / 2;
            while (kartlar.Count < ciftAdet)
            {
                string resim = resimler[rnd.Next(resimler.Count)];
                if (!kartlar.Contains(resim))
                    kartlar.Add(resim);
            }
            kartlar.AddRange(kartlar);
            KartlariKaristir();
        }

        private void KartlariKaristir()
        {
            string yedek;
            int talihliIndeks;
            for (int i = 0; i < kartlar.Count - 1; i++)
            {
                talihliIndeks = rnd.Next(i, kartlar.Count);
                yedek = kartlar[i];
                kartlar[i] = kartlar[talihliIndeks];
                kartlar[talihliIndeks] = yedek;
            }
        }

        private void ResimleriYukle()
        {
            DirectoryInfo klasor = new DirectoryInfo("img");
            FileInfo[] dosyalar = klasor.GetFiles();

            foreach (FileInfo dosya in dosyalar)
                resimler.Add("img\\" + dosya.Name);

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            SeviyeyeKararVer();
            panel1.Hide();
            KartlariSec();
            KartlariDiz();
        }

        private void SeviyeyeKararVer()
        {
            if (rb1.Checked) boyut = 2;
            if (rb2.Checked) boyut = 4;
            if (rb3.Checked) boyut = 6;
            if (rb4.Checked) boyut = 8;
            if (rb5.Checked) boyut = 10;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
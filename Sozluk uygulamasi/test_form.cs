using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace yazilim_yapimi
{
    public partial class test_form : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=WordBox; Trusted_Connection=True;");
        Random random = new Random();
        string DoğruCevap, Cevap;
        int kelimesayisi;
        int Sıra;
        int DoğruSayısı=0, YanlışSayısı=0;


        public test_form()
        {
            InitializeComponent();
        }
        private void KelimeSayisiAl() 
        {
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Ezberlenecek", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                kelimesayisi = Convert.ToInt32(dr[0]);

               
            }
            baglanti.Close();
        }

        private string YanlışCevapVer(int sira)
        {
            int sayaç = 0;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT trim(Turkish) from Ezberlenecek", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            int rastgeleSayi = random.Next(0, kelimesayisi); // 0-kelimesayisi arasında bir sayı çeker (0 ve kelimesayisi dahil)

            while(rastgeleSayi==sira)
                rastgeleSayi = random.Next(0, kelimesayisi); // küçük bir şanslada olsa doğru şıkkı verirse tekrardan çeksin.


            string kelime = "";
            while (dr.Read())
            {
                if (rastgeleSayi == sayaç) //rasgelesayi, sayacıma eşitse bu kelimeyi döndür eğer değilse başka kelimeye geç, böylece rasgele kelime seçilmiş olur.
                {
                    kelime = dr[0].ToString();
                    break;    
                }
                sayaç++;
            }
            baglanti.Close();
            return kelime;
        }
        private string SoruSor(int Sira) 
        {
            int sayaç = 0;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT trim(English),trim(Turkish) from Ezberlenecek", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            string kelime = "";
            while (dr.Read())
            {
                if (Sira == sayaç) //Sira, sayacıma eşitse bu kelimeyi döndür eğer değilse başka kelimeye geç, böylece istenilen kelimeye geçilir.
                {
                    kelime = dr[0].ToString();
                    DoğruCevap = dr[1].ToString(); //burada doğru cevabı da alıyor.
                    break;

                }
                sayaç++;
            }
            baglanti.Close();

            return  (kelime + " kelimesinin Türkçe karşılığı nedir?");
        }

        private void DoğrubilinmeSayisiKontrol(string Kelime)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT DogruBilinmeSayısı from Ezberlenecek where trim(Turkish)=@p1 ", baglanti);
            cmd.Parameters.AddWithValue("@p1", Kelime);
            SqlDataReader dr = cmd.ExecuteReader();

            int sayi=-1;

            while (dr.Read())
            {
                sayi = Convert.ToInt16(dr[0]);                  
            }
            baglanti.Close();

    


            if (sayi +1!=4) //4 kere bilmediyse sayıyı +1 yapacak şekilde güncelle
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE Ezberlenecek SET DogruBilinmeSayısı=@p1 where trim(Turkish)=@p2", baglanti);
                cmd1.Parameters.AddWithValue("@p1", sayi+1);
                cmd1.Parameters.AddWithValue("@p2", Kelime);
                cmd1.ExecuteNonQuery();
            }
            else // 4 kere bildiyse tablolar arası geçiş yap
            {
                Geçiş(Kelime);
            }
            baglanti.Close();

        }

        private void Geçiş(string Kelime)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT trim(English)from Ezberlenecek where trim(Turkish)=@p1 ", baglanti); //kelimenin ingilizcesini al
            cmd.Parameters.AddWithValue("@p1", Kelime);
            SqlDataReader dr = cmd.ExecuteReader();
            string Ing = ""; 
            while(dr.Read())
            {
                Ing = dr[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();

            SqlCommand cmd1 = new SqlCommand("DELETE Ezberlenecek where trim(Turkish)=@p1", baglanti); //Öncekinden sil
            cmd1.Parameters.AddWithValue("@p1", Kelime);
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO Ögrenilenler(Turkish,English) VALUES('"+Kelime+"','"+Ing+"')", baglanti); //sonrakine ekle
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            
        }
       

        private void YanlışŞıkAta()
        {
            a_button.Text = YanlışCevapVer(Sıra);
            b_button.Text = YanlışCevapVer(Sıra);
            c_button.Text = YanlışCevapVer(Sıra);
            d_button.Text = YanlışCevapVer(Sıra);
        }

        private void DoğruŞıkAta() //Doğru şık her zaman aynı yerde olmasın diye gelen sayıya göre atıyoruz.
        {
            int rastgeleDoğruYeri = random.Next(1, 5);


            if (rastgeleDoğruYeri == 1)
                a_button.Text = DoğruCevap;
            else if (rastgeleDoğruYeri == 2)
                b_button.Text = DoğruCevap;
            else if (rastgeleDoğruYeri == 3)
                c_button.Text = DoğruCevap;
            else if (rastgeleDoğruYeri == 4)
                d_button.Text = DoğruCevap;

        }


        private void testgeri_button_Click(object sender, EventArgs e)
        {
            ana_form ana_form = new ana_form();

            this.Hide();

            ana_form.ShowDialog();

            this.Close();
        }

        private void başla_button_Click(object sender, EventArgs e)
        {
            testgeri_button.Enabled = false;
            test_timer.Interval = 1000;
            test_timer.Start();
            basla_button.Hide();
            bitir_button.Show();


            YanlışŞıkAta();
            testkelime_label.Text = SoruSor(Sıra);
            DoğruŞıkAta();
           


        }

        private void test_form_Load(object sender, EventArgs e)
        {
            KelimeSayisiAl();
            bitir_button.Hide();
            Sıra = 0; 
        }

        private void bitir_button_Click(object sender, EventArgs e)
        {
            test_timer.Stop();

            bitir_button.Text = "TEST BİTTİ";

            bitir_button.Enabled = false;

            testgeri_button.Enabled = true;

            testkelime_label.Text = "";

            testgeri_button.Enabled = true;

            a_button.Text = "";
            b_button.Text = "";
            c_button.Text = "";
            d_button.Text = "";

            MessageBox.Show("TESTİ BİTİRME SÜRENİZ :" + timer_label.Text + " Saniye" + "\n" + lblDogru.Text+ "\n" + lblYanlis.Text);
        }

        int sayac = 0;

        private void test_timer_Tick(object sender, EventArgs e)
        {
            sayac++;
            timer_label.Text = sayac.ToString();
        }


        private void SonrakiSoruHazırla()
        {
            YanlışŞıkAta();
            testkelime_label.Text = SoruSor(++Sıra);
            DoğruŞıkAta();
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            Cevap = a_button.Text;
            CevapVer(Cevap);

        }

        private void B_button_Click(object sender, EventArgs e)
        {
            Cevap = b_button.Text;
            CevapVer(Cevap);
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            Cevap = c_button.Text;
            CevapVer(Cevap);
        }

        private void D_button_Click(object sender, EventArgs e)
        {
            Cevap = d_button.Text;
            CevapVer(Cevap);
        }

        private void CevapVer(string Cevap)
        {
            if (Cevap == DoğruCevap)
            {
                DoğrubilinmeSayisiKontrol(Cevap);
                DoğruSayısı++;
            }
            else
                YanlışSayısı++;

            lblDogru.Text = "DOĞRU SAYISI : " + DoğruSayısı;
            lblYanlis.Text = "YANLIŞ SAYISI : " + YanlışSayısı;

            SonrakiSoruHazırla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YanlışŞıkAta();
          
        }

       

        private void testkelime_label_Click(object sender, EventArgs e)
        {
           
        }
    }
}

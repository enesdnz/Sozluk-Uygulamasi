using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yazilim_yapimi
{
    public partial class kelime_form : Form
    {

        public kelime_form()
        {
            InitializeComponent();
        }

        private void Veri()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=WordBox; Trusted_Connection=True;");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * from sözlük ORDER BY NEWID()", baglanti);

            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                ingkelime_label.Text = dr[1].ToString();
                trkelime_label.Text = dr[0].ToString();
            }
        }

        

        private void geri_button_Click(object sender, EventArgs e)
        {
     
            ana_form ana = new ana_form();

            this.Hide();

            ana.ShowDialog();

            this.Close();

        }

        private void kelime_form_Load(object sender, EventArgs e)
        {
            Veri();

        }

        private void atla_button_Click(object sender, EventArgs e)
        {
            Veri();
        }

        private void kelimeekleme_button_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=WordBox; Trusted_Connection=True;");

            try
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Ezberlenecek (Turkish, English,Date,DogruBilinmeSayısı) values(@turkish, @english,@date,@dogrubilinmesayısı);", baglanti);
                ekle.Parameters.AddWithValue("@turkish", trkelime_label.Text);
                ekle.Parameters.AddWithValue("@english", ingkelime_label.Text);
                ekle.Parameters.AddWithValue("@date", DateTime.Now);
                ekle.Parameters.AddWithValue("@dogrubilinmesayısı",0 );

                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
                if (sonuc != null)
                    MessageBox.Show("Havuza başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Havuza eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Veri();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


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
    public partial class kelimeekle_form : Form
    {
        public kelimeekle_form()
        {
            InitializeComponent();
        }

        private void kelimeeklegeri_button_Click(object sender, EventArgs e)
        {
            ana_form ana = new ana_form();

            this.Hide();

            ana.ShowDialog();

            this.Close();
        }

        private void kelimeekle_form_Load(object sender, EventArgs e)
        {

        }

        private void kelimeekle_button_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=WordBox; Trusted_Connection=True;");
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Sözlük (Turkish,English) values (@turkish,@english)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@turkish", turkceekle_textbox.Text);
                komut.Parameters.AddWithValue("@english", ingekle_textbox.Text);


                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Yeni Kelimeler Sisteme Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            turkceekle_textbox.Clear();
            ingekle_textbox.Clear();
}

        
    }
}

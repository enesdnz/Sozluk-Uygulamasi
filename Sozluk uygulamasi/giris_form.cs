using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace yazilim_yapimi
{
    public partial class giris_form : Form
    {

        public giris_form()
        {
            InitializeComponent();
        }

        

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Programa dönülüyor..");
            }

        }

        List<string> eposta = new List<string>();
        List<string> sifre = new List<string>();

        

        private void giris_button_Click(object sender, EventArgs e)
        {
            if (eposta.Contains(eposta_textbox.Text) && sifre.Contains(sifre_textbox.Text) && Array.IndexOf(eposta.ToArray(), eposta_textbox.Text) == Array.IndexOf(sifre.ToArray(), sifre_textbox.Text))
            {
                this.Hide();
                ana_form frm2 = new ana_form();
                frm2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış!");
           
        }

        private void giris_form_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("giris.txt");
            string kelime = "";
            while ((kelime = sr.ReadLine()) != null)
            {
                string[] öge = kelime.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                eposta.Add(öge[0]);
                sifre.Add(öge[1]);
            }
        }

    }  
}

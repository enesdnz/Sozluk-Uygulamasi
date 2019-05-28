using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_yapimi
{
    public partial class ana_form : Form
    {
        public ana_form()
        {
            InitializeComponent();
        }

        private void kelimeogren_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            kelime_form kelime_form = new kelime_form();

            kelime_form.ShowDialog();

            this.Close();
        }

        private void oturumukapat_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            giris_form grs = new giris_form();

            grs.ShowDialog();
            this.Close();
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            test_form test_form = new test_form();

            this.Hide();

            test_form.ShowDialog();
            this.Close();
        }

        private void kelimeeklebtn_Click(object sender, EventArgs e)
        {
            kelimeekle_form ekle = new kelimeekle_form();

            this.Hide();

            ekle.ShowDialog();

            this.Close();
        }

       

        private void ana_form_Load(object sender, EventArgs e)
        {

        }

        private void istatistik_button_Click(object sender, EventArgs e)
        { 
            istatistik_form frm = new istatistik_form();

            this.Hide();

            frm.ShowDialog();

            
        }
    }
}

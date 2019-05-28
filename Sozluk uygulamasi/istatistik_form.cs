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
    public partial class istatistik_form : Form
    {
        public istatistik_form()
        {
            InitializeComponent();
        }

        private void geri_button_Click(object sender, EventArgs e)
        {
            ana_form ana = new ana_form();
            this.Hide();
            ana.ShowDialog();
        }

        private void ogrenmekte_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void istatistik_form_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=WordBox; Trusted_Connection=True;");
            baglanti.Open();
            string kayit = "SELECT * from Ezberlenecek";
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            ogrenmekte_datagrid.DataSource = dt;

            ogrenmekte_datagrid.Columns[0].Visible = false;
            ogrenmekte_datagrid.Columns[3].Visible = false;

            string veri = "SELECT * from Ögrenilenler";

            SqlCommand cmd = new SqlCommand(veri, baglanti);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dtt = new DataTable();

            sda.Fill(dtt);

            ogrendigim_datagrid.DataSource = dtt;


            
        }
    }
}

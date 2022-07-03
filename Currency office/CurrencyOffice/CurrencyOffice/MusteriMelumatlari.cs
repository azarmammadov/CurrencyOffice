using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CurrencyOffice
{
    public partial class MusteriMelumatlari : Form
    {
        public MusteriMelumatlari()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";


        private void Goster_Click(object sender, EventArgs e)
        {
            SqlConnection elaqe_yarat = new SqlConnection(conString);
            elaqe_yarat.Open();
            SqlCommand burdangotur = new SqlCommand("Select * from iclaslar", elaqe_yarat);

            SqlDataAdapter da = new SqlDataAdapter(burdangotur);
            DataTable melumatcedveli = new DataTable();
            da.Fill(melumatcedveli);
            dataGridView1.DataSource = melumatcedveli;
        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminP admp = new adminP();

            admp.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriMD musmd = new MusteriMD();

            musmd.Show();

            this.Hide();
        }
    }
}

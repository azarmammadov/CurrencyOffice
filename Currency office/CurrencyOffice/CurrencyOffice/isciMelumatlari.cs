using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CurrencyOffice
{
    public partial class isciMelumatlari : Form
    {
        public isciMelumatlari()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";


        private void back_Click(object sender, EventArgs e)
        {
            adminP ap = new adminP();

            ap.Show();

            this.Hide();
        }



        private void Goster_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from isci", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void isciMelumatlari_Load(object sender, EventArgs e)
        {

        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isciD isd = new isciD();

            isd.Show();

            this.Hide();
        }
    }
}

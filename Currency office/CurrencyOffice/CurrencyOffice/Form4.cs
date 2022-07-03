using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CurrencyOffice
{
    public partial class adminP : Form
    {
        public adminP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();

            entry.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isciQeydiyyati rgs = new isciQeydiyyati();

            rgs.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mezenne1 mzn = new mezenne1();

            mzn.Show();

            this.Hide();
        }

        private void adminP_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            isciMelumatlari ism = new isciMelumatlari();

            ism.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriMD musmd = new MusteriMD();

            musmd.Show();

            this.Hide();
        }
    }
}

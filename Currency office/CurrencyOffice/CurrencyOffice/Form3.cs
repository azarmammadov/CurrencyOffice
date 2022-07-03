using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyOffice
{
    public partial class admL : Form
    {
        public admL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();

            entry.Show();

            this.Hide();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (istfad.Text ==  "adminp" && sifr.Text =="Currency1" )
            {
                adminP admin = new adminP();

                admin.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa yenidən cəhd edin və yaxud məsul şəxsə yaxınlaşaraq şikayətinizi bildirin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }
        }

        private void sifren_CheckedChanged(object sender, EventArgs e)
        {
            if (sifren.Checked)
            {
                sifr.UseSystemPasswordChar = true;
            }
            else
            {
                sifr.UseSystemPasswordChar = false;
            }
        }
    }
}

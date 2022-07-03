using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CurrencyOffice
{
    public partial class kalkulyator : Form
    {
        public kalkulyator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(d1.Text);
            double txt2 = Convert.ToDouble(d2.Text);

            double sum = txt1+txt2;

            netice.Text = sum.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(d1.Text);
            double txt2 = Convert.ToDouble(d2.Text);

            double sum = txt1 - txt2;

            netice.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(d1.Text);
            double txt2 = Convert.ToDouble(d2.Text);

            double sum = txt1 * txt2;

            netice.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(d1.Text);
            double txt2 = Convert.ToDouble(d2.Text);

            double sum = txt1 / txt2;

            netice.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Action < Control.ControlCollection > func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
        }

        private void back_Click(object sender, EventArgs e)
        {
            emeliyyat eml = new emeliyyat();

            eml.Show();

            this.Hide();
        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void d1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

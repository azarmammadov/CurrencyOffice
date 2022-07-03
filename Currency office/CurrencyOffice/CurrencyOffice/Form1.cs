using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CurrencyOffice
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminButt_Click(object sender, EventArgs e)
        {
            admL admnL = new admL();

            admnL.Show();

            this.Hide();
        }

        private void workerM_Click(object sender, EventArgs e)
        {
            workerL wrkL = new workerL();

            wrkL.Show();

            this.Hide();
        }
    }
}

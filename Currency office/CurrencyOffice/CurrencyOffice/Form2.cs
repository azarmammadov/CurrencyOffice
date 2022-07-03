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

namespace CurrencyOffice
{
    public partial class workerL : Form
    {
        public workerL()
        {
            InitializeComponent();
        }

        
         
        SqlConnection constring = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True");
        SqlConnection connect = new SqlConnection();
        bool isthere;

         

        private void Form2_Load(object sender, EventArgs e)
        {

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

            
            string istfad = textBox1.Text;
            string sifreee = sifr.Text;
            constring.Open();
            SqlCommand command = new SqlCommand("Select *from dbo.melumatlar", constring);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                    if (istfad == reader["IstifadeciAdi"].ToString().TrimEnd() && sifreee == reader["Sifre"].ToString().TrimEnd())
                    {
                        isthere = true;
                        break;
                    }
                    else
                    {
                        isthere = false;

                    }
                
            }
            if (isthere==true)
            {
               
                new emeliyyat().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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


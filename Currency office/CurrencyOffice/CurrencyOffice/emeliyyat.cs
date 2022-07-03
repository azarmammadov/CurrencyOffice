using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Accessibility;
using System.Globalization;


namespace CurrencyOffice
{
    public partial class emeliyyat : Form
    {
        public emeliyyat()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";


        private void button2_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();

            entry.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kalkulyator kal = new kalkulyator();

            kal.Show();

            this.Hide();
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ataAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void finKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void seriyaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Table_1", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
             
             Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isvalid = regex.IsMatch(dogumT.Text.Trim());
            DateTime dt;
            isvalid = DateTime.TryParseExact(dogumT.Text, "dd/MM/yyyy", new CultureInfo("en-GB"),DateTimeStyles.None ,out dt);

            if (!isvalid)
            {
                MessageBox.Show("Doğum tarixini düzgün yazın.\n(məsələn: 02/11/2022 )", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }
            else
            { 

                if (ad.Text != "" && soyad.Text != "" && ataAdi.Text != "" && dogumT.Text != "" && finKod.Text != "" && finKod.Text.Length == 7 && seriyaN.Text != "" && telnom.Text != "" && Alvahid.Text != "" && Almiqdar.Text != "" && SatVahid.Text != "" && Satmiqdar.Text != "" || Alvahid.Text == "AZN" || Alvahid.Text == "USD" || Alvahid.Text == "EUR" || Alvahid.Text == "RUBL" || Alvahid.Text == "GBP" || Alvahid.Text == "CHF" || Alvahid.Text == "TRY" || SatVahid.Text == "USD" || SatVahid.Text == "EUR" || SatVahid.Text == "RUBL" || SatVahid.Text == "GBP" || SatVahid.Text == "CHF" || SatVahid.Text == "TRY" || SatVahid.Text == "AZN")
                {

                    if (  Alvahid.Text == "USD" || Alvahid.Text == "EUR" || Alvahid.Text == "RUBL" || Alvahid.Text == "GBP" || Alvahid.Text == "CHF" || Alvahid.Text == "TRY" && SatVahid.Text=="AZN") 
                    {

                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into musteri ( Ad, Soyad, AtaAdi, dogumTarixi, FinKod, SeriyaNom, TelefonNom, AlisVahid, AlisMiqdar, SatisVahid, SatisMiqdari ) values ( @Ad, @Soyad, @AtaAdi, @dogumTarixi, @FinKod, @DogumGunu, @SeriyaNom, @TelefonNom, @AlisVahid, @AlisMiqdar, @SatisVahid, @SatisMiqdari )", con);

                        cmd.Parameters.AddWithValue("@Ad", ad.Text);
                        cmd.Parameters.AddWithValue("@Soyad", soyad.Text);
                        cmd.Parameters.AddWithValue("@AtaAdi", ataAdi.Text);
                        cmd.Parameters.AddWithValue("@dogumTarixi", dogumT.Text);
                        cmd.Parameters.AddWithValue("@FinKod", finKod.Text);
                        cmd.Parameters.AddWithValue("@SeriyaNom", int.Parse(seriyaN.Text));
                        cmd.Parameters.AddWithValue("@TelefonNom", int.Parse(telnom.Text));
                        cmd.Parameters.AddWithValue("@AlisVahid", Alvahid.Text);
                        cmd.Parameters.AddWithValue("@AlisMiqdar", double.Parse(Almiqdar.Text)); 
                        cmd.Parameters.AddWithValue("@SatisVahid", SatVahid.Text);
                        cmd.Parameters.AddWithValue("@SatisMiqdari", double.Parse(Satmiqdar.Text));

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Yadda saxlanıldı.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);

                    }

                   

                    else if (SatVahid.Text == "USD" || SatVahid.Text == "EUR" || SatVahid.Text == "RUBL" || SatVahid.Text == "GBP" || SatVahid.Text == "CHF" || SatVahid.Text == "TRY" && Alvahid.Text == "AZN")
                    {

                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into musteri ( Ad, Soyad, AtaAdi, dogumTarixi, FinKod, SeriyaNom, TelefonNom, AlisVahid, AlisMiqdar, SatisVahid, SatisMiqdari ) values ( @Ad, @Soyad, @AtaAdi, @dogumTarixi, @FinKod, @DogumGunu, @SeriyaNom, @TelefonNom, @AlisVahid, @AlisMiqdar, @SatisVahid, @SatisMiqdari )", con);

                        cmd.Parameters.AddWithValue("@Ad", ad.Text);
                        cmd.Parameters.AddWithValue("@Soyad", soyad.Text);
                        cmd.Parameters.AddWithValue("@AtaAdi", ataAdi.Text);
                        cmd.Parameters.AddWithValue("@dogumTarixi", dogumT.Text);
                        cmd.Parameters.AddWithValue("@FinKod", finKod.Text);
                        cmd.Parameters.AddWithValue("@SeriyaNom", int.Parse(seriyaN.Text));
                        cmd.Parameters.AddWithValue("@TelefonNom", int.Parse(telnom.Text));
                        cmd.Parameters.AddWithValue("@AlisVahid", Alvahid.Text);
                        cmd.Parameters.AddWithValue("@AlisMiqdar", double.Parse(Almiqdar.Text));
                        cmd.Parameters.AddWithValue("@SatisVahid", SatVahid.Text);
                        cmd.Parameters.AddWithValue("@SatisMiqdari", double.Parse(Satmiqdar.Text));

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Yadda saxlanıldı.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);


                    }

                    else
                    {
                        MessageBox.Show("Alış və ya satış vahidlərini düzgün yazın. \n(AZN, USD, EUR, RUBL, GBP, CHF, TRY)", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
                    }

                }
            
                else
                {
                    MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
                }
            }
        }

        private void emeliyyat_Load(object sender, EventArgs e)
        {

        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


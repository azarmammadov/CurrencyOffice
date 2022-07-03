using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Accessibility;
using System.Globalization;
using System.Data.SqlClient;

namespace CurrencyOffice
{
    public partial class MusteriMD : Form
    {
        public MusteriMD()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";


        private void MusteriMD_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isvalid = regex.IsMatch(dogumT.Text.Trim());
            DateTime dt;
            isvalid = DateTime.TryParseExact(dogumT.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);

            if (!isvalid)
            {
                MessageBox.Show("Doğum tarixini düzgün yazın.\n(məsələn: 02/11/2022 )", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }
            else
            {
                if (ad.Text != "" && soyad.Text != "" && ataAdi.Text != "" && dogumT.Text != "" && finKod.Text != "" && finKod.Text.Length == 7 && seriyaN.Text != "" && telnom.Text != "" && Alvahid.Text != "" && Almiqdar.Text != "" && SatVahid.Text != "" && Satmiqdar.Text != "" || Alvahid.Text == "AZN" || Alvahid.Text == "USD" || Alvahid.Text == "EUR" || Alvahid.Text == "RUBL" || Alvahid.Text == "GBP" || Alvahid.Text == "CHF" || Alvahid.Text == "TRY" || SatVahid.Text == "USD" || SatVahid.Text == "EUR" || SatVahid.Text == "RUBL" || SatVahid.Text == "GBP" || SatVahid.Text == "CHF" || SatVahid.Text == "TRY" || SatVahid.Text == "AZN")
                {

                    if (Alvahid.Text == "USD" || Alvahid.Text == "EUR" || Alvahid.Text == "RUBL" || Alvahid.Text == "GBP" || Alvahid.Text == "CHF" || Alvahid.Text == "TRY" && SatVahid.Text == "AZN")
                    {

                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update musteri set  Ad=@Ad, Soyad=@Soyad, AtaAdi=@AtaAdi, dogumTarixi=@dogumTarixi, FinKod=@FinKod, SeriyaNom=@SeriyaNom, TelefonNom=@TelefonNom, AlisVahid=@AlisVahid, AlisMiqdar=@AlisMiqdar, SatisVahid=@SatisVahid, SatisMiqdari=@SatisMiqdari where ID=@ID ", con);


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
                        MessageBox.Show("Dəyişiklik edildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);

                    }

                    else if (SatVahid.Text == "USD" || SatVahid.Text == "EUR" || SatVahid.Text == "RUBL" || SatVahid.Text == "GBP" || SatVahid.Text == "CHF" || SatVahid.Text == "TRY" && Alvahid.Text == "AZN")
                    {

                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update musteri set  Ad=@Ad, Soyad=@Soyad, AtaAdi=@AtaAdi, dogumTarixi=@dogumTarixi, FinKod=@FinKod, SeriyaNom=@SeriyaNom, TelefonNom=@TelefonNom, AlisVahid=@AlisVahid, AlisMiqdar=@AlisMiqdar, SatisVahid=@SatisVahid, SatisMiqdari=@SatisMiqdari where ID=@ID ", con);


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
                        MessageBox.Show("Dəyişiklik edildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);

                    }

                    else
                    {
                        MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
                    }


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (idt.Text != "" && idt.Text != "0")
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" Delete musteri where ID=@ID ", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(idt.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat silindi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) )
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

        private void idt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Alvahid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SatVahid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Almiqdar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Satmiqdar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminP ap = new adminP();

            ap.Show();

            this.Hide();
        }
    }
}

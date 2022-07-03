using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Accessibility;
using System.Globalization;

namespace CurrencyOffice
{
    public partial class isciD : Form
    {
        public isciD()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";


        private void back_Click(object sender, EventArgs e)
        {
            isciMelumatlari ism = new isciMelumatlari();

            ism.Show();

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

        private void yaddaSaxla_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isvalid = regex.IsMatch(dogumGunu.Text.Trim());
            DateTime dt;
            isvalid = DateTime.TryParseExact(dogumGunu.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);

            if (!isvalid)
            {
                MessageBox.Show("Doğum tarixini düzgün yazın.\n(məsələn: 02/11/2022 )", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }
            else
            {
                if (ad.Text != "" && soyad.Text != "" && ataAdi.Text != "" && unvan.Text != "" && dogumYeri.Text != "" && dogumGunu.Text != "" && Tecrube.Text != "" && tehsili.Text != "" && ixtisas.Text != "" && vezife.Text != "" && maas.Text != "" && isAD.Text != "" && sifre.Text != "" && finKod.Text != "" && seriyaN.Text != "" && telnom.Text != "")
                {
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update isci set  Ad =@Ad , Soyad=@Soyad, AtaAdi=@AtaAdi, Unvan=@Unvan, DogumYeri=@DogumYeri, DogumGunu=DogumGunu, IsTecrubesi=@IsTecrubesi, TehsilMuessisesi=@TehsilMuessisesi, Ixtisasi=@Ixtisasi, Vezifesi=@Vezifesi, MaasiManatla=@MaasiManatla, IstifadeciAdi=@IstifadeciAdi, Sifre=@Sifre, FinKod=@FinKod, SeriyaNom=@SeriyaNom, TelefonNomresi=@TelefonNomresi where ID=@ID", con);

                    cmd.Parameters.AddWithValue("@ID", int.Parse(idt.Text));
                    cmd.Parameters.AddWithValue("@Ad", ad.Text);
                    cmd.Parameters.AddWithValue("@Soyad", soyad.Text);
                    cmd.Parameters.AddWithValue("@AtaAdi", ataAdi.Text);
                    cmd.Parameters.AddWithValue("@Unvan", unvan.Text);
                    cmd.Parameters.AddWithValue("@DogumYeri", dogumYeri.Text);
                    cmd.Parameters.AddWithValue("@DogumGunu", dogumGunu.Text);
                    cmd.Parameters.AddWithValue("@IsTecrubesi", int.Parse(Tecrube.Text));
                    cmd.Parameters.AddWithValue("@TehsilMuessisesi", tehsili.Text);
                    cmd.Parameters.AddWithValue("@Ixtisasi", ixtisas.Text);
                    cmd.Parameters.AddWithValue("@Vezifesi", vezife.Text);
                    cmd.Parameters.AddWithValue("@MaasiManatla", int.Parse(maas.Text));
                    cmd.Parameters.AddWithValue("@IstifadeciAdi", isAD.Text);
                    cmd.Parameters.AddWithValue("@Sifre", sifre.Text);
                    cmd.Parameters.AddWithValue("@FinKod", finKod.Text);
                    cmd.Parameters.AddWithValue("@SeriyaNom", seriyaN.Text);
                    cmd.Parameters.AddWithValue("@TelefonNomresi", telnom.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            if ( idt.Text != "" && idt.Text != "0")
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" Delete isci where ID=@ID ", con);
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

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void telnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void ataAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ixtisas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void vezife_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void finKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void isciD_Load(object sender, EventArgs e)
        {

        }
    }
}

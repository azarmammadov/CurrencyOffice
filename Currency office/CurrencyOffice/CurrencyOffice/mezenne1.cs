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
    public partial class mezenne1 : Form
    {
        public mezenne1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True";
        
        private void saveB_Click(object sender, EventArgs e)
        {
            
                if (Tusdal.Text != "" && TusdS.Text != "" && TeurA.Text != "" && TeurS.Text != "" && TrublA.Text != "" && TrublS.Text != "" && TgbpA.Text != "" && TgbpS.Text != "" && TchfA.Text != "" && TchfS.Text != "" && TtryA.Text != "" && TtryS.Text != "")
                {
                    double usdalis;
                    usdalis = double.Parse(Tusdal.Text); 

                    double usdsat;
                    usdsat = double.Parse(TusdS.Text);

                    double euralis;
                    euralis = double.Parse(TeurA.Text);

                    double eursat;
                    eursat = double.Parse(TeurS.Text);

                    double rublalis;
                    rublalis = double.Parse(TrublA.Text);

                    double rublsat;
                    rublsat = double.Parse(TrublS.Text);

                    double gbpalis;
                    gbpalis = double.Parse(TgbpA.Text);

                    double gbpsat;
                    gbpsat = double.Parse(TgbpS.Text);

                    double chfalis;
                    chfalis = double.Parse(TchfA.Text);

                    double chfsat;
                    chfsat = double.Parse(TchfS.Text);

                    double tryalis;
                    tryalis = double.Parse(TtryA.Text);

                    double trysat;
                    trysat = double.Parse(TtryS.Text);


                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Table_1 (usdAlis, usdSatis, eurAlis, eurSatis, rublAlis, rublSatis, gbpAlis, gbpSatis, chfAlis, chfSatis, tryAlis, trySatis) values ( @usdAlis, @usdSatis, @eurAlis, @eurSatis, @rublAlis, @rublSatis, @gbpAlis, @gbpSatis, @chfAlis, @chfSatis, @tryAlis, @trySatis)", con);
                    cmd.Parameters.AddWithValue("@usdAlis", usdalis);
                    cmd.Parameters.AddWithValue("@usdSatis", usdsat);
                    cmd.Parameters.AddWithValue("@eurAlis", euralis);
                    cmd.Parameters.AddWithValue("@eurSatis", eursat);
                    cmd.Parameters.AddWithValue("@rublAlis", rublalis);
                    cmd.Parameters.AddWithValue("@rublSatis", rublsat);
                    cmd.Parameters.AddWithValue("@gbpAlis", gbpalis);
                    cmd.Parameters.AddWithValue("@gbpSatis", gbpsat);
                    cmd.Parameters.AddWithValue("@chfAlis", chfalis);
                    cmd.Parameters.AddWithValue("@chfSatis", chfsat);
                    cmd.Parameters.AddWithValue("@tryAlis", tryalis);
                    cmd.Parameters.AddWithValue("@trySatis", trysat);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Yadda saxlanıldı.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);


                }
               
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }



        }

        
        private void button11_Click(object sender, EventArgs e)
        {
            

            if (Tusdal.Text != "" && TusdS.Text != ""  )
            {
                
                double usdalis;
                usdalis = double.Parse(Tusdal.Text);
                
                double usdsat;
                usdsat = double.Parse(TusdS.Text);
                
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set usdAlis=@usdAlis , usdSatis=@usdSatis ", con);

                cmd.Parameters.AddWithValue("@usdAlis",usdalis);
                cmd.Parameters.AddWithValue("@usdSatis", usdsat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.","Uğurlu əməliyyat.",MessageBoxButtons.OK);
               
                
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (TeurA.Text != "" && TeurS.Text != "")
            {
                double euralis;
                euralis = double.Parse(TeurA.Text);

                double eursat;
                eursat = double.Parse(TeurS.Text);

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set eurAlis=@eurAlis , eurSatis=@eurSatis ", con);

                cmd.Parameters.AddWithValue("@eurAlis", euralis);
                cmd.Parameters.AddWithValue("@eurSatis", eursat);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TrublA.Text != "" && TrublS.Text != "")
            {
                double rublalis;
                rublalis = double.Parse(TrublA.Text);

                double rublsat;
                rublsat = double.Parse(TrublS.Text);

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set rublAlis=@rublAlis , rublSatis=@rublSatis ", con);

                cmd.Parameters.AddWithValue("@rublAlis", rublalis);
                cmd.Parameters.AddWithValue("@rublSatis", rublsat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

           

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (TgbpA.Text != "" && TgbpS.Text != "" )
            {
                double gbpalis;
                gbpalis = double.Parse(TgbpA.Text);

                double gbpsat;
                gbpsat = double.Parse(TgbpS.Text);

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set gbpAlis=@gbpAlis , gbpSatis=@gbpSatis ", con);

                cmd.Parameters.AddWithValue("@gbpAlis", gbpalis);
                cmd.Parameters.AddWithValue("@gbpSatis", gbpsat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

            

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (TchfA.Text != "" && TchfS.Text != "")
            {
                double chfalis;
                chfalis = double.Parse(TchfA.Text);

                double chfsat;
                chfsat = double.Parse(TchfS.Text);

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set chfAlis=@chfAlis , chfSatis=@chfSatis ", con);

                cmd.Parameters.AddWithValue("@chfAlis", chfalis);
                cmd.Parameters.AddWithValue("@chfSatis", chfsat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {


            if (TtryA.Text != "" && TtryS.Text != "")
            {

                double tryalis;
                tryalis = double.Parse(TtryA.Text);

                double trysat;
                trysat = double.Parse(TtryS.Text);

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set tryAlis=@chfAlis , trySatis=@chfSatis ", con);

                cmd.Parameters.AddWithValue("@tryAlis", tryalis);
                cmd.Parameters.AddWithValue("@trySatis", trysat);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

        }

        private void Tusdal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TusdS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Tusdal_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(Tusdal.Text, out value)) { Tusdal.Text = ""; }
        }

        private void TusdS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TusdS.Text, out value)) { TusdS.Text = ""; }
        }

        private void TeurA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TeurS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TeurA_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TeurA.Text, out value)) { TeurA.Text = ""; }
        }

        private void TeurS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TeurS.Text, out value)) { TeurS.Text = ""; }
        }

        private void TrublA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrublA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TrublS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TrublA_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TrublA.Text, out value)) { TrublA.Text = ""; }
        }

        private void TrublS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TrublS.Text, out value)) { TrublS.Text = ""; }
        }

        private void TgbpA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TgbpS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TgbpA_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TgbpA.Text, out value)) { TgbpA.Text = ""; }
        }

        private void TgbpS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TgbpS.Text, out value)) { TgbpS.Text = ""; }
        }

        private void TchfA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TchfS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TtryA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TtryS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TgbpA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TchfA_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TchfA.Text, out value)) { TchfA.Text = ""; }
        }

        private void TchfS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TchfS.Text, out value)) { TchfS.Text = ""; }
        }

        private void TtryA_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TtryA.Text, out value)) { TtryA.Text = ""; }
        }

        private void TtryS_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(TtryS.Text, out value)) { TtryS.Text = ""; }
        }

        private void TeurS_TextChanged(object sender, EventArgs e)
        {

        }

        private void mezenne1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Tusdal.Text != "" && TusdS.Text != "" && TeurA.Text != "" && TeurS.Text != "" && TrublA.Text != "" && TrublS.Text != "" && TgbpA.Text != "" && TgbpS.Text != "" && TchfA.Text != "" && TchfS.Text != "" && TtryA.Text != "" && TtryS.Text != "")
            {

                double usdalis;
                usdalis = double.Parse(Tusdal.Text);

                double usdsat;
                usdsat = double.Parse(TusdS.Text);

                double euralis;
                euralis = double.Parse(TeurA.Text);

                double eursat;
                eursat = double.Parse(TeurS.Text);

                double rublalis;
                rublalis = double.Parse(TrublA.Text);

                double rublsat;
                rublsat = double.Parse(TrublS.Text);

                double gbpalis;
                gbpalis = double.Parse(TgbpA.Text);

                double gbpsat;
                gbpsat = double.Parse(TgbpS.Text);

                double chfalis;
                chfalis = double.Parse(TchfA.Text);

                double chfsat;
                chfsat = double.Parse(TchfS.Text);

                double tryalis;
                tryalis = double.Parse(TtryA.Text);

                double trysat;
                trysat = double.Parse(TtryS.Text);


                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set usdAlis=@usdAlis , usdSatis=@usdSatis, eurAlis =@eurAlis , eurSatis=@eurSatis, rublAlis=@rublAlis, rublSatis=@rublSatis, gbpAlis@=gbpAlis, gbpSatis=@gbpSatis, chfAlis=@chfAlis, chfSatis=@chfSatis, tryAlis=@tryAlis, trySatis=@trySatis ", con);

                cmd.Parameters.AddWithValue("@usdAlis", usdalis);
                cmd.Parameters.AddWithValue("@usdSatis", usdsat);
                cmd.Parameters.AddWithValue("@eurAlis", euralis);
                cmd.Parameters.AddWithValue("@eurSatis", eursat);
                cmd.Parameters.AddWithValue("@rublAlis", rublalis);
                cmd.Parameters.AddWithValue("@rublSatis", rublsat);
                cmd.Parameters.AddWithValue("@gbpAlis", gbpalis);
                cmd.Parameters.AddWithValue("@gbpSatis", gbpsat);
                cmd.Parameters.AddWithValue("@chfAlis", chfalis);
                cmd.Parameters.AddWithValue("@chfSatis", chfsat);
                cmd.Parameters.AddWithValue("@tryAlis", tryalis);
                cmd.Parameters.AddWithValue("@trySatis", trysat);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Məlumat dəyişdirildi.", "Uğurlu əməliyyat.", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Zəhmət olmasa daxil etmənizi düzgün edin.", "DIQQƏT! Səhvlik aşkar edildi", MessageBoxButtons.OK);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Table_1", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminP ap = new adminP();

            ap.Show();

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace CurrencyOffice
{
    partial class adminP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minimal = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimal
            // 
            this.minimal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimal.Location = new System.Drawing.Point(678, 12);
            this.minimal.Name = "minimal";
            this.minimal.Size = new System.Drawing.Size(44, 31);
            this.minimal.TabIndex = 14;
            this.minimal.Text = "_";
            this.minimal.UseVisualStyleBackColor = true;
            this.minimal.Click += new System.EventHandler(this.minimal_Click);
            // 
            // exitB
            // 
            this.exitB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitB.Location = new System.Drawing.Point(738, 12);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(50, 31);
            this.exitB.TabIndex = 13;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(207, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "İşçi qeydiyyatı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(207, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ana Səhifə";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(207, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(412, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Məzənnə";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(207, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(412, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "İşçi Məlumatları";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(207, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(412, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "Müştəri Məlumatları";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(352, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 24);
            this.label16.TabIndex = 160;
            this.label16.Text = "Admin Panel";
            // 
            // adminP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(817, 359);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minimal);
            this.Controls.Add(this.exitB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminP";
            this.Load += new System.EventHandler(this.adminP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimal;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
    }
}

namespace CurrencyOffice
{
    partial class MusteriMelumatlari
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
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Goster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.minimal = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(45, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 26);
            this.button6.TabIndex = 150;
            this.button6.Text = "Dəyişiklik et";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(465, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 18);
            this.label9.TabIndex = 149;
            this.label9.Text = "Data Base - də ki məlumatları : ";
            // 
            // Goster
            // 
            this.Goster.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Goster.Location = new System.Drawing.Point(691, 65);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(65, 30);
            this.Goster.TabIndex = 148;
            this.Goster.Text = "Göstər";
            this.Goster.UseVisualStyleBackColor = true;
            this.Goster.Click += new System.EventHandler(this.Goster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(711, 318);
            this.dataGridView1.TabIndex = 147;
            // 
            // minimal
            // 
            this.minimal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimal.Location = new System.Drawing.Point(678, 12);
            this.minimal.Name = "minimal";
            this.minimal.Size = new System.Drawing.Size(44, 31);
            this.minimal.TabIndex = 146;
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
            this.exitB.TabIndex = 145;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 31);
            this.back.TabIndex = 144;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 151;
            this.label1.Text = "Müştəri Məlumatları";
            // 
            // MusteriMelumatlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.minimal);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriMelumatlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriMelumatlari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Goster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button minimal;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}

namespace CurrencyOffice
{
    partial class Entry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitB = new System.Windows.Forms.Button();
            this.minimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workerM = new System.Windows.Forms.Button();
            this.adminButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitB.Location = new System.Drawing.Point(383, 11);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(44, 31);
            this.exitB.TabIndex = 0;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // minimal
            // 
            this.minimal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimal.Location = new System.Drawing.Point(318, 11);
            this.minimal.Name = "minimal";
            this.minimal.Size = new System.Drawing.Size(44, 31);
            this.minimal.TabIndex = 1;
            this.minimal.Text = "_";
            this.minimal.UseVisualStyleBackColor = true;
            this.minimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valyuta ofis proqramı";
            // 
            // workerM
            // 
            this.workerM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workerM.Location = new System.Drawing.Point(68, 245);
            this.workerM.Name = "workerM";
            this.workerM.Size = new System.Drawing.Size(95, 42);
            this.workerM.TabIndex = 3;
            this.workerM.Text = "İşçi";
            this.workerM.UseVisualStyleBackColor = true;
            this.workerM.Click += new System.EventHandler(this.workerM_Click);
            // 
            // adminButt
            // 
            this.adminButt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminButt.Location = new System.Drawing.Point(318, 245);
            this.adminButt.Name = "adminButt";
            this.adminButt.Size = new System.Drawing.Size(95, 42);
            this.adminButt.TabIndex = 4;
            this.adminButt.Text = "Admin";
            this.adminButt.UseVisualStyleBackColor = true;
            this.adminButt.Click += new System.EventHandler(this.adminButt_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(489, 381);
            this.Controls.Add(this.adminButt);
            this.Controls.Add(this.workerM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimal);
            this.Controls.Add(this.exitB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button minimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button workerM;
        private System.Windows.Forms.Button adminButt;
    }
}


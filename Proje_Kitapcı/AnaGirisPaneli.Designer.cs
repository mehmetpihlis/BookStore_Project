namespace Proje_Kitapcı
{
    partial class AnaGirisPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGirisPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelpictureBox = new System.Windows.Forms.PictureBox();
            this.AdminpictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(109, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Giris Paneli";
            // 
            // PersonelpictureBox
            // 
            this.PersonelpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.PersonelpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonelpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PersonelpictureBox.Image")));
            this.PersonelpictureBox.Location = new System.Drawing.Point(176, 199);
            this.PersonelpictureBox.Name = "PersonelpictureBox";
            this.PersonelpictureBox.Size = new System.Drawing.Size(175, 126);
            this.PersonelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonelpictureBox.TabIndex = 1;
            this.PersonelpictureBox.TabStop = false;
            this.PersonelpictureBox.Click += new System.EventHandler(this.PersonelpictureBox_Click);
            // 
            // AdminpictureBox
            // 
            this.AdminpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.AdminpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminpictureBox.Image")));
            this.AdminpictureBox.Location = new System.Drawing.Point(532, 199);
            this.AdminpictureBox.Name = "AdminpictureBox";
            this.AdminpictureBox.Size = new System.Drawing.Size(175, 126);
            this.AdminpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminpictureBox.TabIndex = 2;
            this.AdminpictureBox.TabStop = false;
            this.AdminpictureBox.Click += new System.EventHandler(this.AdminpictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(191, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Girisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(552, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin Girisi";
            // 
            // ExitBox
            // 
            this.ExitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(856, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(70, 57);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBox.TabIndex = 5;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AnaGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(938, 417);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminpictureBox);
            this.Controls.Add(this.PersonelpictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PersonelpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PersonelpictureBox;
        private System.Windows.Forms.PictureBox AdminpictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ExitBox;
    }
}


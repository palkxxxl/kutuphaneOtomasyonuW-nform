namespace kutuphaneOtomasyonuWınform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personelgırıstxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sıfregırıstxt = new System.Windows.Forms.TextBox();
            this.Personelgırısbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personelgırıstxt
            // 
            this.personelgırıstxt.Location = new System.Drawing.Point(78, 144);
            this.personelgırıstxt.Name = "personelgırıstxt";
            this.personelgırıstxt.Size = new System.Drawing.Size(198, 20);
            this.personelgırıstxt.TabIndex = 0;
            this.personelgırıstxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sıfregırıstxt
            // 
            this.sıfregırıstxt.Location = new System.Drawing.Point(78, 170);
            this.sıfregırıstxt.Name = "sıfregırıstxt";
            this.sıfregırıstxt.PasswordChar = '*';
            this.sıfregırıstxt.Size = new System.Drawing.Size(198, 20);
            this.sıfregırıstxt.TabIndex = 3;
            this.sıfregırıstxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Personelgırısbtn
            // 
            this.Personelgırısbtn.BackColor = System.Drawing.Color.MintCream;
            this.Personelgırısbtn.ForeColor = System.Drawing.Color.Black;
            this.Personelgırısbtn.Location = new System.Drawing.Point(78, 225);
            this.Personelgırısbtn.Name = "Personelgırısbtn";
            this.Personelgırısbtn.Size = new System.Drawing.Size(198, 30);
            this.Personelgırısbtn.TabIndex = 4;
            this.Personelgırısbtn.Text = "Giriş";
            this.Personelgırısbtn.UseVisualStyleBackColor = false;
            this.Personelgırısbtn.Click += new System.EventHandler(this.Personelgırısbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(363, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Personelgırısbtn);
            this.Controls.Add(this.sıfregırıstxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelgırıstxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personelgırıstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sıfregırıstxt;
        private System.Windows.Forms.Button Personelgırısbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


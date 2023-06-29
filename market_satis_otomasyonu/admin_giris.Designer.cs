namespace market_satis_otomasyonu
{
    partial class admin_giris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngirisatla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngiris);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtkullaniciadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "giriş";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btngiris.Location = new System.Drawing.Point(56, 110);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(87, 36);
            this.btngiris.TabIndex = 9;
            this.btngiris.Text = "giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(91, 58);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(100, 22);
            this.txtsifre.TabIndex = 8;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(91, 29);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(100, 22);
            this.txtkullaniciadi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "kullanıcı adı";
            // 
            // btngirisatla
            // 
            this.btngirisatla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btngirisatla.Location = new System.Drawing.Point(287, 166);
            this.btngirisatla.Name = "btngirisatla";
            this.btngirisatla.Size = new System.Drawing.Size(87, 36);
            this.btngirisatla.TabIndex = 5;
            this.btngirisatla.Text = "girişi atla >";
            this.btngirisatla.UseVisualStyleBackColor = false;
            this.btngirisatla.Click += new System.EventHandler(this.btngirisatla_Click);
            // 
            // admin_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btngirisatla);
            this.Name = "admin_giris";
            this.Text = "admin giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngirisatla;
    }
}


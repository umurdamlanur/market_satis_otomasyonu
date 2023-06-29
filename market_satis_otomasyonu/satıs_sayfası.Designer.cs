namespace market_satis_otomasyonu
{
    partial class satıs_sayfası
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnadetekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcarp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 356);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttoplam);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnpdf);
            this.groupBox2.Location = new System.Drawing.Point(481, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 580);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "satış";
            // 
            // txttoplam
            // 
            this.txttoplam.Location = new System.Drawing.Point(293, 436);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(100, 22);
            this.txttoplam.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "toplam fiyat";
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(399, 426);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(128, 36);
            this.btnpdf.TabIndex = 5;
            this.btnpdf.Text = "pdf al";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnadetekle
            // 
            this.btnadetekle.Location = new System.Drawing.Point(296, 544);
            this.btnadetekle.Name = "btnadetekle";
            this.btnadetekle.Size = new System.Drawing.Size(128, 36);
            this.btnadetekle.TabIndex = 8;
            this.btnadetekle.Text = "adet ekle";
            this.btnadetekle.UseVisualStyleBackColor = true;
            this.btnadetekle.Click += new System.EventHandler(this.btnadetekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "ürünleri getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcarp
            // 
            this.txtcarp.Location = new System.Drawing.Point(162, 551);
            this.txtcarp.Name = "txtcarp";
            this.txtcarp.Size = new System.Drawing.Size(128, 22);
            this.txtcarp.TabIndex = 9;
            this.txtcarp.TextChanged += new System.EventHandler(this.txtcarp_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 357);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MultiSelectChanged += new System.EventHandler(this.button1_Click);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "adet bilgisi girin!";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(162, 433);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(128, 22);
            this.txtkod.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ürün kodu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txturunfiyati);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnadetekle);
            this.groupBox1.Controls.Add(this.txtcarp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtkod);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 580);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "ürün adı";
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Location = new System.Drawing.Point(162, 517);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(128, 22);
            this.txturunfiyati.TabIndex = 18;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(162, 475);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(128, 22);
            this.txtad.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "ürün fiyatı";
            // 
            // satıs_sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "satıs_sayfası";
            this.Text = "satıs_sayfası";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnadetekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcarp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.Label label5;
    }
}
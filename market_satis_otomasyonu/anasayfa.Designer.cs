namespace market_satis_otomasyonu
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürün_sistemiDataSet = new market_satis_otomasyonu.ürün_sistemiDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txturunmiktari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txturunadı = new System.Windows.Forms.TextBox();
            this.btnsatıssayfasi = new System.Windows.Forms.Button();
            this.ürünTableAdapter = new market_satis_otomasyonu.ürün_sistemiDataSetTableAdapters.ürünTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürün_sistemiDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnekle.Location = new System.Drawing.Point(296, 77);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(87, 36);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnguncelle.Location = new System.Drawing.Point(296, 139);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 36);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnsil.Location = new System.Drawing.Point(296, 202);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 36);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.urunfiyatiDataGridViewTextBoxColumn,
            this.urunmiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 383);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            this.urunkoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatiDataGridViewTextBoxColumn
            // 
            this.urunfiyatiDataGridViewTextBoxColumn.DataPropertyName = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.HeaderText = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatiDataGridViewTextBoxColumn.Name = "urunfiyatiDataGridViewTextBoxColumn";
            this.urunfiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunmiktariDataGridViewTextBoxColumn
            // 
            this.urunmiktariDataGridViewTextBoxColumn.DataPropertyName = "urunmiktari";
            this.urunmiktariDataGridViewTextBoxColumn.HeaderText = "urunmiktari";
            this.urunmiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunmiktariDataGridViewTextBoxColumn.Name = "urunmiktariDataGridViewTextBoxColumn";
            this.urunmiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataMember = "ürün";
            this.ürünBindingSource.DataSource = this.ürün_sistemiDataSet;
            // 
            // ürün_sistemiDataSet
            // 
            this.ürün_sistemiDataSet.DataSetName = "ürün_sistemiDataSet";
            this.ürün_sistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txturunmiktari);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txturunfiyati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txturunkodu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txturunadı);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ürün bilgileri";
            // 
            // txturunmiktari
            // 
            this.txturunmiktari.Location = new System.Drawing.Point(133, 184);
            this.txturunmiktari.Name = "txturunmiktari";
            this.txturunmiktari.Size = new System.Drawing.Size(100, 22);
            this.txturunmiktari.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "ürün miktarı";
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Location = new System.Drawing.Point(133, 142);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(100, 22);
            this.txturunfiyati.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ürün fiyatı";
            // 
            // txturunkodu
            // 
            this.txturunkodu.Location = new System.Drawing.Point(133, 66);
            this.txturunkodu.Name = "txturunkodu";
            this.txturunkodu.Size = new System.Drawing.Size(100, 22);
            this.txturunkodu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ürün kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ürün adı";
            // 
            // txturunadı
            // 
            this.txturunadı.Location = new System.Drawing.Point(133, 102);
            this.txturunadı.Name = "txturunadı";
            this.txturunadı.Size = new System.Drawing.Size(100, 22);
            this.txturunadı.TabIndex = 10;
            // 
            // btnsatıssayfasi
            // 
            this.btnsatıssayfasi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnsatıssayfasi.Location = new System.Drawing.Point(827, 414);
            this.btnsatıssayfasi.Name = "btnsatıssayfasi";
            this.btnsatıssayfasi.Size = new System.Drawing.Size(142, 36);
            this.btnsatıssayfasi.TabIndex = 11;
            this.btnsatıssayfasi.Text = "satış sayfasına git  >";
            this.btnsatıssayfasi.UseVisualStyleBackColor = false;
            this.btnsatıssayfasi.Click += new System.EventHandler(this.btnsatıssayfasi_Click);
            // 
            // ürünTableAdapter
            // 
            this.ürünTableAdapter.ClearBeforeFill = true;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btnsatıssayfasi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürün_sistemiDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunkodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunadı;
        private System.Windows.Forms.TextBox txturunmiktari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsatıssayfasi;
        private ürün_sistemiDataSet ürün_sistemiDataSet;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private ürün_sistemiDataSetTableAdapters.ürünTableAdapter ürünTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmiktariDataGridViewTextBoxColumn;
    }
}
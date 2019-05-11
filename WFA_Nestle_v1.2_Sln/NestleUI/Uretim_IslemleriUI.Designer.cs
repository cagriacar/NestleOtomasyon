namespace NestleUI
{
    partial class Uretim_IslemleriUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uretim_IslemleriUI));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nudUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.dtpUrunTarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUrunBilgisi = new System.Windows.Forms.DataGridView();
            this.cmbUrunTuru = new System.Windows.Forms.ComboBox();
            this.txtUrunSorgula = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDepoAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunBilgisi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "659806-Box_cube_cargo_loading_package_archive_arrow_file_open_product-512.png");
            // 
            // nudUrunAdet
            // 
            this.nudUrunAdet.Location = new System.Drawing.Point(121, 128);
            this.nudUrunAdet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudUrunAdet.Name = "nudUrunAdet";
            this.nudUrunAdet.Size = new System.Drawing.Size(50, 20);
            this.nudUrunAdet.TabIndex = 14;
            // 
            // dtpUrunTarihi
            // 
            this.dtpUrunTarihi.Location = new System.Drawing.Point(121, 70);
            this.dtpUrunTarihi.Name = "dtpUrunTarihi";
            this.dtpUrunTarihi.Size = new System.Drawing.Size(129, 20);
            this.dtpUrunTarihi.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ürün Sorgulama :";
            // 
            // dgvUrunBilgisi
            // 
            this.dgvUrunBilgisi.AllowUserToAddRows = false;
            this.dgvUrunBilgisi.AllowUserToDeleteRows = false;
            this.dgvUrunBilgisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunBilgisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunBilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunBilgisi.Location = new System.Drawing.Point(286, 17);
            this.dgvUrunBilgisi.Name = "dgvUrunBilgisi";
            this.dgvUrunBilgisi.ReadOnly = true;
            this.dgvUrunBilgisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunBilgisi.Size = new System.Drawing.Size(907, 253);
            this.dgvUrunBilgisi.TabIndex = 11;
            this.dgvUrunBilgisi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunBilgisi_CellClick);
            // 
            // cmbUrunTuru
            // 
            this.cmbUrunTuru.FormattingEnabled = true;
            this.cmbUrunTuru.Location = new System.Drawing.Point(121, 43);
            this.cmbUrunTuru.Name = "cmbUrunTuru";
            this.cmbUrunTuru.Size = new System.Drawing.Size(129, 21);
            this.cmbUrunTuru.TabIndex = 10;
            // 
            // txtUrunSorgula
            // 
            this.txtUrunSorgula.Location = new System.Drawing.Point(389, 276);
            this.txtUrunSorgula.Name = "txtUrunSorgula";
            this.txtUrunSorgula.Size = new System.Drawing.Size(129, 20);
            this.txtUrunSorgula.TabIndex = 7;
            this.txtUrunSorgula.TextChanged += new System.EventHandler(this.txtUrunSorgula_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(121, 17);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(129, 20);
            this.txtUrunAdi.TabIndex = 7;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(192, 222);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(65, 25);
            this.btnUrunSil.TabIndex = 6;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(192, 191);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(65, 25);
            this.btnUrunGuncelle.TabIndex = 6;
            this.btnUrunGuncelle.Text = "Düzenle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(121, 191);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(65, 25);
            this.btnUrunEkle.TabIndex = 6;
            this.btnUrunEkle.Text = "Kayıt Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adedi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Fiyatı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adı  :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nudFiyat);
            this.tabPage2.Controls.Add(this.nudUrunAdet);
            this.tabPage2.Controls.Add(this.dtpUrunTarihi);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dgvUrunBilgisi);
            this.tabPage2.Controls.Add(this.cmbDepoAdi);
            this.tabPage2.Controls.Add(this.cmbUrunTuru);
            this.tabPage2.Controls.Add(this.txtUrunSorgula);
            this.tabPage2.Controls.Add(this.txtUrunAdi);
            this.tabPage2.Controls.Add(this.btnUrunSil);
            this.tabPage2.Controls.Add(this.btnUrunGuncelle);
            this.tabPage2.Controls.Add(this.btnUrunEkle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbDepoAdi
            // 
            this.cmbDepoAdi.FormattingEnabled = true;
            this.cmbDepoAdi.Location = new System.Drawing.Point(120, 154);
            this.cmbDepoAdi.Name = "cmbDepoAdi";
            this.cmbDepoAdi.Size = new System.Drawing.Size(129, 21);
            this.cmbDepoAdi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depo Adi :";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(120, 102);
            this.nudFiyat.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(129, 20);
            this.nudFiyat.TabIndex = 15;
            // 
            // Uretim_IslemleriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Uretim_IslemleriUI";
            this.Text = "Uretim_IslemleriUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Uretim_IslemleriUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunBilgisi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.NumericUpDown nudUrunAdet;
        private System.Windows.Forms.DateTimePicker dtpUrunTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUrunBilgisi;
        private System.Windows.Forms.ComboBox cmbUrunTuru;
        private System.Windows.Forms.TextBox txtUrunSorgula;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFiyat;
    }
}
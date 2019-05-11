namespace NestleUI
{
    partial class Sevkiyat_IslemleriUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sevkiyat_IslemleriUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSevDuzenle = new System.Windows.Forms.Button();
            this.btnSevSil = new System.Windows.Forms.Button();
            this.btnSevkiyatTamamla = new System.Windows.Forms.Button();
            this.dgvSevkiyat = new System.Windows.Forms.DataGridView();
            this.txtSevkiyatAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.cmbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.cmbSevkiyatTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSevDuzenle);
            this.tabPage2.Controls.Add(this.btnSevSil);
            this.tabPage2.Controls.Add(this.btnSevkiyatTamamla);
            this.tabPage2.Controls.Add(this.dgvSevkiyat);
            this.tabPage2.Controls.Add(this.txtSevkiyatAdres);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbUrunAdi);
            this.tabPage2.Controls.Add(this.cmbFirmaAdi);
            this.tabPage2.Controls.Add(this.cmbSevkiyatTuru);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sevkiyat İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSevDuzenle
            // 
            this.btnSevDuzenle.Location = new System.Drawing.Point(174, 236);
            this.btnSevDuzenle.Name = "btnSevDuzenle";
            this.btnSevDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnSevDuzenle.TabIndex = 8;
            this.btnSevDuzenle.Text = "Düzenle";
            this.btnSevDuzenle.UseVisualStyleBackColor = true;
            this.btnSevDuzenle.Click += new System.EventHandler(this.btnSevDuzenle_Click);
            // 
            // btnSevSil
            // 
            this.btnSevSil.Location = new System.Drawing.Point(93, 236);
            this.btnSevSil.Name = "btnSevSil";
            this.btnSevSil.Size = new System.Drawing.Size(75, 23);
            this.btnSevSil.TabIndex = 7;
            this.btnSevSil.Text = "Sil";
            this.btnSevSil.UseVisualStyleBackColor = true;
            this.btnSevSil.Click += new System.EventHandler(this.btnSevSil_Click);
            // 
            // btnSevkiyatTamamla
            // 
            this.btnSevkiyatTamamla.Location = new System.Drawing.Point(93, 207);
            this.btnSevkiyatTamamla.Name = "btnSevkiyatTamamla";
            this.btnSevkiyatTamamla.Size = new System.Drawing.Size(156, 23);
            this.btnSevkiyatTamamla.TabIndex = 6;
            this.btnSevkiyatTamamla.Text = "Sevkiyatı Tamamla";
            this.btnSevkiyatTamamla.UseVisualStyleBackColor = true;
            this.btnSevkiyatTamamla.Click += new System.EventHandler(this.btnSevkiyatTamamla_Click);
            // 
            // dgvSevkiyat
            // 
            this.dgvSevkiyat.AllowUserToAddRows = false;
            this.dgvSevkiyat.AllowUserToDeleteRows = false;
            this.dgvSevkiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSevkiyat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSevkiyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSevkiyat.Location = new System.Drawing.Point(262, 23);
            this.dgvSevkiyat.Name = "dgvSevkiyat";
            this.dgvSevkiyat.ReadOnly = true;
            this.dgvSevkiyat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSevkiyat.Size = new System.Drawing.Size(701, 310);
            this.dgvSevkiyat.TabIndex = 5;
            this.dgvSevkiyat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSevkiyat_CellClick);
            // 
            // txtSevkiyatAdres
            // 
            this.txtSevkiyatAdres.BackColor = System.Drawing.Color.White;
            this.txtSevkiyatAdres.Location = new System.Drawing.Point(93, 116);
            this.txtSevkiyatAdres.Multiline = true;
            this.txtSevkiyatAdres.Name = "txtSevkiyatAdres";
            this.txtSevkiyatAdres.Size = new System.Drawing.Size(156, 85);
            this.txtSevkiyatAdres.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Adres :";
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(93, 77);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(156, 21);
            this.cmbUrunAdi.TabIndex = 2;
            // 
            // cmbFirmaAdi
            // 
            this.cmbFirmaAdi.FormattingEnabled = true;
            this.cmbFirmaAdi.Location = new System.Drawing.Point(93, 23);
            this.cmbFirmaAdi.Name = "cmbFirmaAdi";
            this.cmbFirmaAdi.Size = new System.Drawing.Size(156, 21);
            this.cmbFirmaAdi.TabIndex = 2;
            // 
            // cmbSevkiyatTuru
            // 
            this.cmbSevkiyatTuru.FormattingEnabled = true;
            this.cmbSevkiyatTuru.Location = new System.Drawing.Point(93, 50);
            this.cmbSevkiyatTuru.Name = "cmbSevkiyatTuru";
            this.cmbSevkiyatTuru.Size = new System.Drawing.Size(156, 21);
            this.cmbSevkiyatTuru.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Firma  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sevkiyat Türü :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "transport-icons-03.png");
            this.ımageList1.Images.SetKeyName(1, "doğru-araç.png");
            // 
            // Sevkiyat_IslemleriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sevkiyat_IslemleriUI";
            this.Text = "Sevkiyat_IslemleriUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sevkiyat_IslemleriUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSevkiyatTamamla;
        private System.Windows.Forms.DataGridView dgvSevkiyat;
        private System.Windows.Forms.TextBox txtSevkiyatAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.ComboBox cmbFirmaAdi;
        private System.Windows.Forms.ComboBox cmbSevkiyatTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSevDuzenle;
        private System.Windows.Forms.Button btnSevSil;
    }
}
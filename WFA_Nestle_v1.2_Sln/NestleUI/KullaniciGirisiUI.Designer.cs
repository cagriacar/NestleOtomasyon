namespace NestleUI
{
    partial class KullaniciGirisiUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisiUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifreKontrol = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnKulllaniciGiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbGoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola :";
            // 
            // lblSifreKontrol
            // 
            this.lblSifreKontrol.AutoSize = true;
            this.lblSifreKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreKontrol.ForeColor = System.Drawing.Color.Red;
            this.lblSifreKontrol.Location = new System.Drawing.Point(54, 144);
            this.lblSifreKontrol.Name = "lblSifreKontrol";
            this.lblSifreKontrol.Size = new System.Drawing.Size(0, 15);
            this.lblSifreKontrol.TabIndex = 2;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(130, 43);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(139, 20);
            this.txtKadi.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(130, 69);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(139, 20);
            this.txtParola.TabIndex = 4;
            // 
            // btnKulllaniciGiris
            // 
            this.btnKulllaniciGiris.Location = new System.Drawing.Point(194, 95);
            this.btnKulllaniciGiris.Name = "btnKulllaniciGiris";
            this.btnKulllaniciGiris.Size = new System.Drawing.Size(75, 23);
            this.btnKulllaniciGiris.TabIndex = 5;
            this.btnKulllaniciGiris.Text = "Giriş";
            this.btnKulllaniciGiris.UseVisualStyleBackColor = true;
            this.btnKulllaniciGiris.Click += new System.EventHandler(this.btnKulllaniciGiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "goz.jpg");
            // 
            // pbGoster
            // 
            this.pbGoster.Image = ((System.Drawing.Image)(resources.GetObject("pbGoster.Image")));
            this.pbGoster.Location = new System.Drawing.Point(275, 69);
            this.pbGoster.Name = "pbGoster";
            this.pbGoster.Size = new System.Drawing.Size(25, 20);
            this.pbGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGoster.TabIndex = 7;
            this.pbGoster.TabStop = false;
            this.pbGoster.MouseLeave += new System.EventHandler(this.pbGoster_MouseLeave);
            this.pbGoster.MouseHover += new System.EventHandler(this.pbGoster_MouseHover);
            // 
            // KullaniciGirisiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 185);
            this.Controls.Add(this.pbGoster);
            this.Controls.Add(this.btnKulllaniciGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.lblSifreKontrol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGirisiUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pbGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifreKontrol;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnKulllaniciGiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pbGoster;
    }
}
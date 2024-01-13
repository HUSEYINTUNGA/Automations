namespace FİSTİK_Otomasyon
{
    partial class FrmMusteri_Bilgilerini_Guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteri_Bilgilerini_Guncelle));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtBosArac = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt5arac = new System.Windows.Forms.TextBox();
            this.txt4arac = new System.Windows.Forms.TextBox();
            this.txt3arac = new System.Windows.Forms.TextBox();
            this.txt1arac = new System.Windows.Forms.TextBox();
            this.txt2arac = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSahadanSil = new System.Windows.Forms.Button();
            this.txtSahaNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(555, 16);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(214, 33);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.ImageKey = "güncelle.png";
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(1100, 58);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(142, 53);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
            this.ımageList1.Images.SetKeyName(1, "iptal.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            this.ımageList1.Images.SetKeyName(3, "güncelle.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 347);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 223);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "sil.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(1100, 119);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 53);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.ImageKey = "iptal.png";
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(1100, 180);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(142, 53);
            this.btnİptal.TabIndex = 7;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(556, 142);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(214, 33);
            this.txtAdres.TabIndex = 4;
            // 
            // txtBosArac
            // 
            this.txtBosArac.Location = new System.Drawing.Point(555, 270);
            this.txtBosArac.Margin = new System.Windows.Forms.Padding(4);
            this.txtBosArac.Name = "txtBosArac";
            this.txtBosArac.Size = new System.Drawing.Size(214, 33);
            this.txtBosArac.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(555, 58);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(214, 33);
            this.txtSoyad.TabIndex = 2;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(555, 184);
            this.txteposta.Margin = new System.Windows.Forms.Padding(4);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(214, 33);
            this.txteposta.TabIndex = 5;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(163, 306);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(197, 33);
            this.txtArama.TabIndex = 12;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-Posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Boş Araç Kütlesi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "1. Araç :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "İsme Göre Ara:";
            // 
            // txt5arac
            // 
            this.txt5arac.Location = new System.Drawing.Point(921, 187);
            this.txt5arac.Margin = new System.Windows.Forms.Padding(4);
            this.txt5arac.Name = "txt5arac";
            this.txt5arac.Size = new System.Drawing.Size(78, 33);
            this.txt5arac.TabIndex = 10;
            // 
            // txt4arac
            // 
            this.txt4arac.Location = new System.Drawing.Point(921, 142);
            this.txt4arac.Margin = new System.Windows.Forms.Padding(4);
            this.txt4arac.Name = "txt4arac";
            this.txt4arac.Size = new System.Drawing.Size(78, 33);
            this.txt4arac.TabIndex = 9;
            // 
            // txt3arac
            // 
            this.txt3arac.Location = new System.Drawing.Point(921, 99);
            this.txt3arac.Margin = new System.Windows.Forms.Padding(4);
            this.txt3arac.Name = "txt3arac";
            this.txt3arac.Size = new System.Drawing.Size(78, 33);
            this.txt3arac.TabIndex = 8;
            // 
            // txt1arac
            // 
            this.txt1arac.Location = new System.Drawing.Point(921, 15);
            this.txt1arac.Margin = new System.Windows.Forms.Padding(4);
            this.txt1arac.Name = "txt1arac";
            this.txt1arac.Size = new System.Drawing.Size(78, 33);
            this.txt1arac.TabIndex = 6;
            // 
            // txt2arac
            // 
            this.txt2arac.Location = new System.Drawing.Point(921, 56);
            this.txt2arac.Margin = new System.Windows.Forms.Padding(4);
            this.txt2arac.Name = "txt2arac";
            this.txt2arac.Size = new System.Drawing.Size(78, 33);
            this.txt2arac.TabIndex = 7;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(555, 100);
            this.mskTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(214, 33);
            this.mskTelefon.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(824, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 27);
            this.label9.TabIndex = 29;
            this.label9.Text = "5. Araç :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(822, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 27);
            this.label10.TabIndex = 30;
            this.label10.Text = "4. Araç :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(822, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 27);
            this.label11.TabIndex = 31;
            this.label11.Text = "3. Araç :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(822, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 27);
            this.label12.TabIndex = 32;
            this.label12.Text = "2. Araç :";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.ImageKey = "geri.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(1100, 0);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(142, 53);
            this.btnGeri.TabIndex = 33;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 229);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 27);
            this.label13.TabIndex = 35;
            this.label13.Text = "Saha Numarası:";
            // 
            // btnSahadanSil
            // 
            this.btnSahadanSil.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSahadanSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSahadanSil.ImageKey = "sil.png";
            this.btnSahadanSil.ImageList = this.ımageList1;
            this.btnSahadanSil.Location = new System.Drawing.Point(1100, 241);
            this.btnSahadanSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSahadanSil.Name = "btnSahadanSil";
            this.btnSahadanSil.Size = new System.Drawing.Size(142, 62);
            this.btnSahadanSil.TabIndex = 37;
            this.btnSahadanSil.Text = "Sahadan\r\n Sil";
            this.btnSahadanSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSahadanSil.UseVisualStyleBackColor = true;
            this.btnSahadanSil.Click += new System.EventHandler(this.btnSahadanSil_Click);
            // 
            // txtSahaNo
            // 
            this.txtSahaNo.Location = new System.Drawing.Point(556, 226);
            this.txtSahaNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSahaNo.Name = "txtSahaNo";
            this.txtSahaNo.Size = new System.Drawing.Size(214, 33);
            this.txtSahaNo.TabIndex = 38;
            // 
            // FrmMusteri_Bilgilerini_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1255, 571);
            this.Controls.Add(this.txtSahaNo);
            this.Controls.Add(this.btnSahadanSil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txt2arac);
            this.Controls.Add(this.txt1arac);
            this.Controls.Add(this.txt3arac);
            this.Controls.Add(this.txt4arac);
            this.Controls.Add(this.txt5arac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtBosArac);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteri_Bilgilerini_Guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bilgilerini Güncelle";
            this.Load += new System.EventHandler(this.MusteriBilgileriniGüncelle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusteriBilgileriniGüncelle_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtBosArac;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt5arac;
        private System.Windows.Forms.TextBox txt4arac;
        private System.Windows.Forms.TextBox txt3arac;
        private System.Windows.Forms.TextBox txt1arac;
        private System.Windows.Forms.TextBox txt2arac;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSahadanSil;
        private System.Windows.Forms.TextBox txtSahaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilkAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bosAracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahaBolgesiDataGridViewTextBoxColumn;
    }
}
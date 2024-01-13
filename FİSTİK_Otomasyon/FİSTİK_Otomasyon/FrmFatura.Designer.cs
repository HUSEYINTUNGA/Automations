namespace FİSTİK_Otomasyon
{
    partial class FrmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFatura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1arac = new System.Windows.Forms.TextBox();
            this.txt2arac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3arac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt4arac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt5arac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBosArac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilkAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bosAracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahaBolgesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyAdDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.ilkAracDataGridViewTextBoxColumn,
            this.ikAracDataGridViewTextBoxColumn,
            this.ucAracDataGridViewTextBoxColumn,
            this.doAracDataGridViewTextBoxColumn,
            this.beAracDataGridViewTextBoxColumn,
            this.bosAracDataGridViewTextBoxColumn,
            this.sahaBolgesiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(284, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(547, 558);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(72, 494);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(147, 56);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.Araç:";
            // 
            // txt1arac
            // 
            this.txt1arac.Location = new System.Drawing.Point(148, 175);
            this.txt1arac.Name = "txt1arac";
            this.txt1arac.Size = new System.Drawing.Size(100, 26);
            this.txt1arac.TabIndex = 3;
            // 
            // txt2arac
            // 
            this.txt2arac.Location = new System.Drawing.Point(148, 207);
            this.txt2arac.Name = "txt2arac";
            this.txt2arac.Size = new System.Drawing.Size(100, 26);
            this.txt2arac.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "2.Araç:";
            // 
            // txt3arac
            // 
            this.txt3arac.Location = new System.Drawing.Point(148, 239);
            this.txt3arac.Name = "txt3arac";
            this.txt3arac.Size = new System.Drawing.Size(100, 26);
            this.txt3arac.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "3.Araç:";
            // 
            // txt4arac
            // 
            this.txt4arac.Location = new System.Drawing.Point(148, 271);
            this.txt4arac.Name = "txt4arac";
            this.txt4arac.Size = new System.Drawing.Size(100, 26);
            this.txt4arac.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "4.Araç:";
            // 
            // txt5arac
            // 
            this.txt5arac.Location = new System.Drawing.Point(148, 303);
            this.txt5arac.Name = "txt5arac";
            this.txt5arac.Size = new System.Drawing.Size(100, 26);
            this.txt5arac.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(65, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "5.Araç:";
            // 
            // txtBosArac
            // 
            this.txtBosArac.Location = new System.Drawing.Point(148, 335);
            this.txtBosArac.Name = "txtBosArac";
            this.txtBosArac.Size = new System.Drawing.Size(100, 26);
            this.txtBosArac.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Boş Araç:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Soyadı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(47, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 26);
            this.txtSoyad.TabIndex = 18;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 26);
            this.txtAd.TabIndex = 16;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(124, 398);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 26);
            this.txtFiyat.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ton fiyatı: ";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.ImageKey = "geri.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(2, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 36);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.png");
         
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            // 
            // musteriTableAdapter
            // 
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyAdDataGridViewTextBoxColumn
            // 
            this.soyAdDataGridViewTextBoxColumn.DataPropertyName = "SoyAd";
            this.soyAdDataGridViewTextBoxColumn.HeaderText = "SoyAd";
            this.soyAdDataGridViewTextBoxColumn.Name = "soyAdDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // ilkAracDataGridViewTextBoxColumn
            // 
            this.ilkAracDataGridViewTextBoxColumn.DataPropertyName = "ilkArac";
            this.ilkAracDataGridViewTextBoxColumn.HeaderText = "ilkArac";
            this.ilkAracDataGridViewTextBoxColumn.Name = "ilkAracDataGridViewTextBoxColumn";
            // 
            // ikAracDataGridViewTextBoxColumn
            // 
            this.ikAracDataGridViewTextBoxColumn.DataPropertyName = "ikArac";
            this.ikAracDataGridViewTextBoxColumn.HeaderText = "ikArac";
            this.ikAracDataGridViewTextBoxColumn.Name = "ikAracDataGridViewTextBoxColumn";
            // 
            // ucAracDataGridViewTextBoxColumn
            // 
            this.ucAracDataGridViewTextBoxColumn.DataPropertyName = "ucArac";
            this.ucAracDataGridViewTextBoxColumn.HeaderText = "ucArac";
            this.ucAracDataGridViewTextBoxColumn.Name = "ucAracDataGridViewTextBoxColumn";
            // 
            // doAracDataGridViewTextBoxColumn
            // 
            this.doAracDataGridViewTextBoxColumn.DataPropertyName = "doArac";
            this.doAracDataGridViewTextBoxColumn.HeaderText = "doArac";
            this.doAracDataGridViewTextBoxColumn.Name = "doAracDataGridViewTextBoxColumn";
            // 
            // beAracDataGridViewTextBoxColumn
            // 
            this.beAracDataGridViewTextBoxColumn.DataPropertyName = "beArac";
            this.beAracDataGridViewTextBoxColumn.HeaderText = "beArac";
            this.beAracDataGridViewTextBoxColumn.Name = "beAracDataGridViewTextBoxColumn";
            // 
            // bosAracDataGridViewTextBoxColumn
            // 
            this.bosAracDataGridViewTextBoxColumn.DataPropertyName = "Bos_Arac";
            this.bosAracDataGridViewTextBoxColumn.HeaderText = "Bos_Arac";
            this.bosAracDataGridViewTextBoxColumn.Name = "bosAracDataGridViewTextBoxColumn";
            // 
            // sahaBolgesiDataGridViewTextBoxColumn
            // 
            this.sahaBolgesiDataGridViewTextBoxColumn.DataPropertyName = "SahaBolgesi";
            this.sahaBolgesiDataGridViewTextBoxColumn.HeaderText = "SahaBolgesi";
            this.sahaBolgesiDataGridViewTextBoxColumn.Name = "sahaBolgesiDataGridViewTextBoxColumn";
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(831, 562);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBosArac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt5arac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4arac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt3arac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2arac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1arac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ekranı";
            this.Load += new System.EventHandler(this.Fatura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fatura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1arac;
        private System.Windows.Forms.TextBox txt2arac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt3arac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt4arac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt5arac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBosArac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
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
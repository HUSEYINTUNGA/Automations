using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FİSTİK_Otomasyon
{
    public partial class FrmMusteri_Bilgilerini_Guncelle : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        Methods methot = new Methods();
        public FrmMusteri_Bilgilerini_Guncelle()
        {
            InitializeComponent();
        }

        private void MusteriBilgileriniGüncelle_Load(object sender, EventArgs e)
        {

                       
            CGRTABL();


        }
        private void CGRTABL()
        {
            string cml = "select*from Musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = methot.list(adtr2, cml);

        }

        //Tabloda isme göre kayıt arama
        #region
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string cml = "select*from Musteri where Ad like '%" + txtArama.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = methot.list(adtr2, cml);
        }
        #endregion

        /* Bilgilerini güncelleyeceğimiz müşterinin tablo üzerinde herhangi
         bir bilgisini içeren kutucuğa tıkladığımızda textboxlara bilgileri yazması*/
        #region
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txteposta.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt1arac.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt2arac.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txt3arac.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txt4arac.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txt5arac.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtBosArac.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            txtSahaNo.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();

        }
        #endregion

        //Güncelle Butonu
        #region
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();
            String cml = "update Musteri set  SoyAd=@P2,Telefon=@P3,Adres=@P4,Eposta=@P5,ilkArac=@P6," +
                "ikArac=@P7,ucArac=@P8,doArac=@P9,beArac=@P10,Bos_Arac=@P11,SahaBolgesi=@p12 WHERE Ad=@P1";

            SqlCommand komut2 = new SqlCommand(cml, baglanti);
            komut2.Parameters.AddWithValue("@P1", txtAd.Text);
            komut2.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@P3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@P4", txtAdres.Text);
            komut2.Parameters.AddWithValue("@P5", txteposta.Text);
            komut2.Parameters.AddWithValue("@P6", txt1arac.Text);
            komut2.Parameters.AddWithValue("@P7", txt2arac.Text);
            komut2.Parameters.AddWithValue("@P8", txt3arac.Text);
            komut2.Parameters.AddWithValue("@P9", txt4arac.Text);
            komut2.Parameters.AddWithValue("@P10", txt5arac.Text);
            komut2.Parameters.AddWithValue("@P11", txtBosArac.Text);
            komut2.Parameters.AddWithValue("@P12", txtSahaNo.Text);
            komut2.ExecuteNonQuery();
            methot.ekle_sil_güncelle(komut2, cml);
            foreach (Control cml2 in Controls) if (cml2 is TextBox) cml2.Text = "";
            CGRTABL();
            txtAd.Clear();
            txtSoyad.Clear();
            mskTelefon.Clear();
            txtAdres.Clear();
            txteposta.Clear();
            txtBosArac.Clear();
            txtSahaNo.Text = "";
            txt1arac.Clear();
            txt2arac.Clear();
            txt3arac.Clear();
            txt4arac.Clear();
            txt5arac.Clear();

            baglanti.Close();
        }
        #endregion

        //Sil Butonu
        #region
        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            String dize = "delete from Musteri where Ad='" + satır.Cells[1].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            methot.ekle_sil_güncelle(komut2, dize);
            CGRTABL();
            txtAd.Clear();
            txtSoyad.Clear();
            mskTelefon.Clear();
            txtAdres.Clear();
            txteposta.Clear();
            txtBosArac.Clear();
            txtSahaNo.Text = "";
            txt1arac.Clear();
            txt2arac.Clear();
            txt3arac.Clear();
            txt4arac.Clear();
            txt5arac.Clear();
        }
        #endregion

        //İptal Butonu
        #region
        private void btnİptal_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
        #endregion

        //Geri İptal
        #region
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
        #endregion

        //Butonlara Tuş Atama
        #region
        private void MusteriBilgileriniGüncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt&&e.KeyCode == Keys.G)
            {
                btnGüncelle.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.I)
            {
                btnİptal.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnGeri.PerformClick();
            }
        }

        #endregion

        //Sahadan Sil Butonu
        #region
        private void btnSahadanSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);


            string text;
            text = txtSahaNo.Text;
            switch (text)
            {
                case "00":
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("Delete from Bolge00",baglanti);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "01":
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("Delete from Bolge01", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "10":
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("Delete from Bolge10", baglanti);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "11":
                    baglanti.Open();
                    SqlCommand komut4 = new SqlCommand("Delete from Bolge11", baglanti);
                    komut4.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "20":
                    baglanti.Open();
                    SqlCommand komut5 = new SqlCommand("Delete from Bolge20", baglanti);
                    komut5.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "21":
                    baglanti.Open();
                    SqlCommand komut6 = new SqlCommand("Delete from Bolge21", baglanti);
                    komut6.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "30":
                    baglanti.Open();
                    SqlCommand komut7 = new SqlCommand("Delete from Bolge30", baglanti);
                    komut7.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "31":
                    baglanti.Open();
                    SqlCommand komut8 = new SqlCommand("Delete from Bolge31", baglanti);
                    komut8.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "40":
                    baglanti.Open();
                    SqlCommand komut9 = new SqlCommand("Delete from Bolge40", baglanti);
                    komut9.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "41":
                    baglanti.Open();
                    SqlCommand komut10 = new SqlCommand("Delete from Bolge41", baglanti);
                    komut10.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "50":
                    baglanti.Open();
                    SqlCommand komut11 = new SqlCommand("Delete from Bolge50", baglanti);
                    komut11.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;

                case "51":
                    baglanti.Open();
                    SqlCommand komut12 = new SqlCommand("Delete from Bolge51", baglanti);
                    komut12.ExecuteNonQuery();
                    baglanti.Close();
                    CGRTABL();
                    break;


            }
        }
        #endregion


    }
}

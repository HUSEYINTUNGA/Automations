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

    public partial class FrmMusteri_Ekle : Form
    {
        
        Methods sqlek = new Methods();
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmMusteri_Ekle()
        {
            InitializeComponent();
        }
        //Sahaya Ekle Butonu
        #region
        private void btnSahayaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komt = new SqlCommand();
            string cumle;
            string bolge;
            bolge = txtSahaNo.Text;
            switch (bolge)
            {

                case "00":
                    cumle = "insert into Bolge00(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "01":
                    cumle = "insert into Bolge01(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "10":
                    cumle = "insert into Bolge10(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "11":
                    cumle = "insert into Bolge11(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "20":
                    cumle = "insert into Bolge20(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "21":
                    cumle = "insert into Bolge21(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "30":
                    cumle = "insert into Bolge30(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "31":
                    cumle = "insert into Bolge31(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "40":
                    cumle = "insert into Bolge40(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "41":
                    cumle = "insert into Bolge41(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "50":
                    cumle = "insert into Bolge50(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

                case "51":
                    cumle = "insert into Bolge51(Ad,Soyad) values(@t1,@t2)";
                    komt.Parameters.AddWithValue("@t1", txtAd.Text);
                    komt.Parameters.AddWithValue("@t2", txtSoyad.Text);
                    sqlek.ekle_sil_güncelle(komt, cumle);
                    break;

            }
        }
        #endregion

        //Ekle Butonu
        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Musteri(Ad,SoyAd,Telefon,Adres,Eposta,Bos_Arac,ilkArac,ikArac,ucArac,doArac,beArac,SahaBolgesi)" +
                " values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@p12)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@P1", txtAd.Text);
            komut2.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@P3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@P4", txtAdres.Text);
            komut2.Parameters.AddWithValue("@P5", txteposta.Text);
            komut2.Parameters.AddWithValue("@P6", txtBosArac.Text);
            komut2.Parameters.AddWithValue("@P7", txtİlkArac.Text);
            komut2.Parameters.AddWithValue("@P8", 0);
            komut2.Parameters.AddWithValue("@P9", 0);
            komut2.Parameters.AddWithValue("@P10", 0);
            komut2.Parameters.AddWithValue("@P11", 0);          
            komut2.Parameters.AddWithValue("@P12", txtSahaNo.Text);           
            sqlek.ekle_sil_güncelle(komut2, cümle);
            foreach (Control cml in Controls) if (cml is TextBox) cml.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            txtAdres.Text = "";
            txteposta.Text = "";
            txtİlkArac.Text = "";
            txtBosArac.Text = "";
            txtSahaNo.Text = "";

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

        //Temizle Butonu
        #region
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            txtAdres.Text = "";
            txteposta.Text = "";
            txtİlkArac.Text = "";
            txtBosArac.Text = "";
            txtSahaNo.Text = "";

        }
        #endregion

        //Geri Butonu
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
        private void Müsteri_Ekle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.C)
            {
                btnTemizle.PerformClick();
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

        /*Matris Düzenli sahada müşteriye ayrılan saha bölgesinin
        belirlenmesi için butonlara tıklanması olayı.*/
        #region
        private void bnt00_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn00.Text;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn10.Text;

        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn20.Text;

        }

        private void btn30_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn30.Text;

        }

        private void btn40_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn40.Text;

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn50.Text;

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn01.Text;

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn11.Text;

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn21.Text;

        }

        private void btn31_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn31.Text;

        }

        private void btn41_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn41.Text;

        }

        private void btn51_Click(object sender, EventArgs e)
        {
            txtSahaNo.Text = btn51.Text;

        }


        #endregion

        /*Tesis Sahası text'li groupBox'ın alanları içerisinde dolu ve boş olanların ayırma.
        Dolu bölgelerin rengini kırmızı yapma ve rezerve edilen kişinin ismini yazdırma*/
        #region
        private void FrmMusteri_Ekle_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            //Bölge00
            #region
            conn.Open();
            SqlCommand comm1 = new SqlCommand("Select * from Bolge00", conn);
            SqlDataReader dr1 = comm1.ExecuteReader();
            while (dr1.Read())
            {
                grB00.Text = dr1[0].ToString() + " " + dr1[1].ToString();
            }
            conn.Close();
            if (grB00.Text != "00")
            {
                grB00.BackColor = Color.Red;
                btn00.Enabled = false;

            }
            #endregion

            //Bölge01
            #region
            conn.Open();
            SqlCommand comm2 = new SqlCommand("Select * from Bolge01", conn);
            SqlDataReader dr2 = comm2.ExecuteReader();
            while (dr2.Read())
            {
                grB01.Text = dr2[0].ToString() + " " + dr2[1].ToString();
            }
            conn.Close();
            if (grB01.Text != "01")
            {
                grB01.BackColor = Color.Red;
                btn01.Enabled = false;
            }
            #endregion

            //Bölge10
            #region
            conn.Open();
            SqlCommand comm3 = new SqlCommand("Select * from Bolge10", conn);
            SqlDataReader dr3 = comm3.ExecuteReader();
            while (dr3.Read())
            {
                grB10.Text = dr3[0].ToString() + " " + dr3[1].ToString();
            }
            conn.Close();
            if (grB10.Text != "10")
            {
                grB10.BackColor = Color.Red;
                btn10.Enabled = false;

            }
            #endregion

            //Bölge11
            #region
            conn.Open();
            SqlCommand comm4 = new SqlCommand("Select * from Bolge11", conn);
            SqlDataReader dr4 = comm4.ExecuteReader();
            while (dr4.Read())
            {
                grB11.Text = dr4[0].ToString() + " " + dr4[1].ToString();
            }
            conn.Close();
            if (grB11.Text != "11")
            {
                grB11.BackColor = Color.Red;
                btn11.Enabled = false;

            }
            #endregion

            //Bölge20
            #region
            conn.Open();
            SqlCommand comm5 = new SqlCommand("Select * from Bolge20", conn);
            SqlDataReader dr5 = comm5.ExecuteReader();
            while (dr5.Read())
            {
                grB20.Text = dr5[0].ToString() + " " + dr5[1].ToString();
            }
            conn.Close();
            if (grB20.Text != "20")
            {
                grB20.BackColor = Color.Red;
                btn20.Enabled = false;

            }
            #endregion

            //Bölge21
            #region
            conn.Open();
            SqlCommand comm6 = new SqlCommand("Select * from Bolge21", conn);
            SqlDataReader dr6 = comm6.ExecuteReader();
            while (dr6.Read())
            {
                grB21.Text = dr6[0].ToString() + " " + dr6[1].ToString();
            }
            conn.Close();
            if (grB21.Text != "21")
            {
                grB21.BackColor = Color.Red;
                btn21.Enabled = false;
            }
            #endregion

            //Bölge30
            #region
            conn.Open();
            SqlCommand comm7 = new SqlCommand("Select * from Bolge30", conn);
            SqlDataReader dr7 = comm7.ExecuteReader();
            while (dr7.Read())
            {
                grB30.Text = dr7[0].ToString() + " " + dr7[1].ToString();
            }
            conn.Close();
            if (grB30.Text != "30")
            {
                grB30.BackColor = Color.Red;
                btn30.Enabled = false;

            }
            #endregion

            //Bölge31
            #region
            conn.Open();
            SqlCommand comm8 = new SqlCommand("Select * from Bolge31", conn);
            SqlDataReader dr8 = comm8.ExecuteReader();
            while (dr8.Read())
            {
                grB31.Text = dr8[0].ToString() + " " + dr8[1].ToString();
            }
            conn.Close();
            if (grB31.Text != "31")
            {
                grB31.BackColor = Color.Red;
                btn31.Enabled = false;
            }
            #endregion

            //Bölge40
            #region
            conn.Open();
            SqlCommand comm9 = new SqlCommand("Select * from Bolge40", conn);
            SqlDataReader dr9 = comm9.ExecuteReader();
            while (dr9.Read())
            {
                grB40.Text = dr9[0].ToString() + " " + dr9[1].ToString();
            }
            conn.Close();
            if (grB40.Text != "40")
            {
                grB40.BackColor = Color.Red;
                btn40.Enabled = false;

            }
            #endregion

            //Bölge41
            #region
            conn.Open();
            SqlCommand comm10 = new SqlCommand("Select * from Bolge41", conn);
            SqlDataReader dr10 = comm10.ExecuteReader();
            while (dr10.Read())
            {
                grB41.Text = dr10[0].ToString() + " " + dr10[1].ToString();
            }
            conn.Close();
            if (grB41.Text != "41")
            {
                grB41.BackColor = Color.Red;
                btn41.Enabled = false;

            }
            #endregion

            //Bölge50
            #region
            conn.Open();
            SqlCommand comm11 = new SqlCommand("Select * from Bolge50", conn);
            SqlDataReader dr11 = comm11.ExecuteReader();
            while (dr11.Read())
            {
                grB50.Text = dr11[0].ToString() + " " + dr11[1].ToString();
            }
            conn.Close();
            if (grB50.Text != "50")
            {
                grB50.BackColor = Color.Red;
                btn50.Enabled = false;

            }
            #endregion

            //Bölge51
            #region
            conn.Open();
            SqlCommand comm12 = new SqlCommand("Select * from Bolge51", conn);
            SqlDataReader dr12 = comm12.ExecuteReader();
            while (dr12.Read())
            {
                grB51.Text = dr12[0].ToString() + " " + dr12[1].ToString();
            }
            conn.Close();
            if (grB51.Text != "51")
            {
                grB51.BackColor = Color.Red;
                btn51.Enabled = false;

            }
            #endregion
        }
        #endregion
    }
}

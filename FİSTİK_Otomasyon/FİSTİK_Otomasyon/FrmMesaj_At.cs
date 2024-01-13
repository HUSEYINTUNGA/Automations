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
using System.Net;
using System.Net.Mail;


namespace FİSTİK_Otomasyon
{
    public partial class FrmMesaj_At : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        
       

        public FrmMesaj_At()
        {
            InitializeComponent();
        }

        /*Form Sayfası yüklenirken Mesaj Alıcısı (Nakliyeci) isimlerini ve Musteri isimlerini 
        combobox lara taşıma işlemi*/
        #region
        private void FrmMesaj_At_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlDataReader dr1;
            SqlCommand komut1 = new SqlCommand("Select * From Nakliyeci", baglanti);                       
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbAlıcıAd.Items.Add(dr1[1].ToString());
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader dtr;
            SqlCommand komut = new SqlCommand("Select * From Musteri", baglanti);
            dtr = komut.ExecuteReader();
            while (dtr.Read())
            {
                cmbsahipAd.Items.Add(dtr[1].ToString());
            }
            baglanti.Close();
        }
        #endregion
              
        //Gönder Butonu
        #region
        private void btnGönder_Click(object sender, EventArgs e)
        {
           
            string sifre = "2071ht514";
            string eposta = "Fistikityo@hotmail.com";
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(eposta, sifre);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(eposta);
            mail.To.Add(lblEposta.Text);
            mail.Subject ="Nahsenoğlu Fıstık İşleme Tesisi";
            mail.IsBodyHtml = true;
            mail.Body = cmbAlıcıAd.Text + " " + lblSoyad.Text + " " + rchAdres.Text + " adresine gitmesi gereken "
                +txtParca.Text+ " parça "+cmbsahipAd.Text+" kişisinin fıstığı var "+txtSahiptel.Text+
                " bu numaradan fıstık sahibiyle iletişime geçebilirsin";
            sc.Timeout = 100;
            sc.Send(mail);
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

        //Nakliyecinin Adı Combobox'tan seçildiğinde 
        #region
        private void cmbAlıcıAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Soyadı,EPosta from Nakliyeci where Adı=@p1", baglanti);
            SqlDataReader dr2;
            komut2.Parameters.AddWithValue("@p1", cmbAlıcıAd.Text);
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblSoyad.Text = dr2[0].ToString();
                lblEposta.Text = dr2[1].ToString();
            }

            baglanti.Close();
        }
        #endregion

        //Fıstık Sahibinin Adı Combobox'tan seçildiğinde 
        #region
        private void cmbsahipAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Telefon from Musteri where Ad=@p2", baglanti);
            SqlDataReader dr3;
            komut3.Parameters.AddWithValue("@p2", cmbsahipAd.Text);
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                txtSahiptel.Text = dr3[0].ToString();
            }
            baglanti.Close();
        }

        #endregion

      
    }
}

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
using System.Net.Mail;
using System.Net;

namespace FİSTİK_Otomasyon
{

    public partial class FrmSifremi_Unuttum : Form
    {
        

       
        SqlDataReader dr;
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmSifremi_Unuttum()
        {
            InitializeComponent();
        }

        //Hatırla Butonu
        #region
        private void btnHatırla_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            string user = txtAd.Text;
            string password = txtGkodu.Text;
            baglanti.Open();
           
            SqlCommand komut = new SqlCommand("Select*From Yonetici where Ad= '" + txtAd.Text +
            "'And GuvenlikKodu='" + txtGkodu.Text + "'");
            komut.Connection = baglanti;
           dr = komut.ExecuteReader();
            if (dr.Read())
            {
               MessageBox.Show ("Yönetici "+txtAd.Text+" Bey şifreniz: " +dr[1].ToString());
              
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı bilgi girişi yaptınız");
            }
            baglanti.Close();

        }

        #endregion

        //Geri Butonu
        #region
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmGiris gcs = new FrmGiris();
            gcs.Show();
            this.Hide();
        }
        #endregion       
    }
}

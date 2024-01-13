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
    public partial class FrmYonetici_Kayıt : Form
    {
        Methods metot = new Methods();
        public FrmYonetici_Kayıt()
        {
            InitializeComponent();
        }
        //İptal Butonu
        #region
        private void btnİptal_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
        #endregion

        //Kaydet Butonu
        #region
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifretekrar.Text==txtSifre.Text)
            {
                string cml = "insert into Yonetici(Ad,Sifre,GuvenlikKodu)values(@p1,@p2,@p3)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@p1",txtAd.Text);
                komut.Parameters.AddWithValue("@p2",txtSifre.Text);
                komut.Parameters.AddWithValue("@p3",txtGuvenlikKodu.Text);
                metot.ekle_sil_güncelle(komut, cml);

            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor lütfen kontrol ettikten sonra tekrar deneyiniz");
            }
        }
        #endregion

        //Şifreyi Görüntüle Butonu
        #region
        private void btngor_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            txtSifretekrar.UseSystemPasswordChar = false;
        }
        #endregion

    }
}

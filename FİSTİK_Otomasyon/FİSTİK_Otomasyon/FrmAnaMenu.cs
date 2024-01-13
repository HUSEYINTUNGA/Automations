using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİSTİK_Otomasyon
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }


        //   1)GENEL AYARLAR
        #region
        //  1.1)Müşteri Ayarları
        #region
        // 1.1.1)Müşteri Kaydet
        private void müşteriKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri_Ekle gcs = new FrmMusteri_Ekle();
            gcs.Show();
            this.Hide();

        }
        
        // 1.1.2)Müşteri Bilgilerini Güncelle        
        private void müşteribilgilerinigüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri_Bilgilerini_Guncelle gcs = new FrmMusteri_Bilgilerini_Guncelle();
            gcs.Show();
            this.Hide();
        }
        
        // 1.1.3)Hesap Getir        
        private void hesapGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFatura gcs = new FrmFatura();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion
        //  1.2)Çalışan Ayarları
        #region
        // 1.2.1)Çalışan Bilgilerini Güncelle
        private void çalışanBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalısan_Bilgilerini_Guncelle gcs = new FrmCalısan_Bilgilerini_Guncelle();
            gcs.Show();
            this.Hide();
        }

        // 1.2.2)Ücret Hesapla
        private void ücretHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUcret_Hesapla gcs = new FrmUcret_Hesapla();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion
        //  1.3)Nakliyeci Ayarları 
        #region
        private void nakliyeciAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNakliyeci_Ayarları gcs = new FrmNakliyeci_Ayarları();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion
        //  1.4)Saha Ayarları
        #region
        private void sahaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaha_Goruntule gcs = new FrmSaha_Goruntule();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion
        //  1.5)Müşteriye Mesaj At
        #region
        private void müşteriyeMesajAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMesaj_At gcs = new FrmMesaj_At();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion

        #endregion

        //   2)HAKKIMIZDA
        #region
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkımızda gcs = new FrmHakkımızda();
            gcs.Show();
            this.Hide();
        }
        /*---------------------------------------------------------------------------------------------------*/
        #endregion

        //   3)YÖNETİCİ KAYDET 
        #region
        private void yöneticiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYonetici_Kayıt gcs = new FrmYonetici_Kayıt();
            gcs.Show();
            this.Hide();
        }
        #endregion

        //   4)ÇIKIŞ
        #region
        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

      
    }
}

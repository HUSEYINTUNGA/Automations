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
    public partial class FrmCalısan_Bilgilerini_Guncelle : Form
    {
        public FrmCalısan_Bilgilerini_Guncelle()
        {
            InitializeComponent();
        }
        
        Methods metot = new Methods();
        SqlBaglantisi bgl = new SqlBaglantisi();

       


        private void CalısanList_Load(object sender, EventArgs e)
        {

            TBLCGR();

        }
        private void TBLCGR()
        {
            String cml = "select*from Calısan";
            SqlDataAdapter dr = new SqlDataAdapter();
            dataGridView1.DataSource = metot.list(dr, cml);
        }

        //Geri Butonu
        #region
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
        #endregion

        //Kaydet Butonu
        #region
        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            String cümle = "insert into Calısan(Ad,SoyAd,Telefon,Eposta,BaslangicTarihi,CikisTarihi)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@p1", Txtİsim.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyisim.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtMail.Text);
            komut.Parameters.AddWithValue("@p5", dtpbaslangıc.Text);
            komut.Parameters.AddWithValue("@p6", dtpcıkıs.Text);
            metot.ekle_sil_güncelle(komut, cümle);
            foreach (Control cml in Controls) if (cml is TextBox) cml.Text = "";

        }
        #endregion

        //Sil Butonu
        #region
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            DataGridViewRow satır = dataGridView1.CurrentRow;
            String dize = "delete from Calısan where CalisanId='" + satır.Cells[0].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(dize,baglanti);
            metot.ekle_sil_güncelle(komut, dize);
            TBLCGR();

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

        //Güncelle Butonu
        #region
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();
            String cml = "update Calısan set Ad=@p1,SoyAd=@p2,Telefon=@p3,Eposta=@p4," +
                "BaslangicTarihi=@p5,CikisTarihi=@p6 WHERE CalisanId=@p7";
            SqlCommand komt = new SqlCommand(cml, baglanti);
            komt.Parameters.AddWithValue("@p1", Txtİsim.Text);
            komt.Parameters.AddWithValue("@p2", TxtSoyisim.Text);
            komt.Parameters.AddWithValue("@p3", msktelefon.Text);
            komt.Parameters.AddWithValue("@p4", TxtMail.Text);
            komt.Parameters.AddWithValue("@p5", dtpbaslangıc.Text);
            komt.Parameters.AddWithValue("@p6", dtpcıkıs.Text);
            komt.Parameters.AddWithValue("@p7", txtCalısanId.Text);
            komt.ExecuteNonQuery();
            metot.ekle_sil_güncelle(komt, cml);
            foreach (Control cml2 in Controls) if (cml2 is TextBox) cml2.Text = "";
            TBLCGR();           
            MessageBox.Show("Bilgiler Güncellendi");
        }
        #endregion

        /* Bilgilerini güncelleyeceğimiz çalışanın tablo üzerinde herhangi
      bir bilgisini içeren kutucuğa tıkladığımızda textboxlara bilgileri yazması*/
        #region
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtCalısanId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtİsim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dtpbaslangıc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dtpcıkıs.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        #endregion

        // Butonlara tuş atama
        #region
        private void CalısanList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.I)
            {
                btnİptal.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }
            if (e.Alt&&e.KeyCode==Keys.G)
            {
                btnGüncelle.PerformClick();
            }
            if (e.KeyCode==Keys.Enter)
            {
                bttnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnGeri.PerformClick();
            }
        }
        #endregion
    }
}


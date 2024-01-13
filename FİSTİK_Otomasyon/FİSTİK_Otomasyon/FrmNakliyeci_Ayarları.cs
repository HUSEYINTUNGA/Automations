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

    public partial class FrmNakliyeci_Ayarları : Form
    {
        
        Methods metot = new Methods();
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmNakliyeci_Ayarları()
        {
            InitializeComponent();
        }

        private void TabloCgr()
        {
            String cml = "select*from Nakliyeci";
            SqlDataAdapter dr = new SqlDataAdapter();
            dataGridView1.DataSource = metot.list(dr, cml);
        }

        private void FrmNakliyeci_Ayarları_Load(object sender, EventArgs e)
        {


            TabloCgr();

        }

        /* Bilgilerini güncelleyeceğimiz çalışanın tablo üzerinde herhangi
            bir bilgisini içeren kutucuğa tıkladığımızda textboxlara bilgileri yazması*/
        #region
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txteposta.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
        #endregion

        //Kaydet Butonu
        #region
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String cümle = "insert into Nakliyeci(Adı,Soyadı,Telefon,EPosta) values(@p1, @p2, @p3, @p4)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txteposta.Text);
            metot.ekle_sil_güncelle(komut, cümle);
            foreach (Control cml in Controls) if (cml is TextBox) cml.Text = "";
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txteposta.Text = "";
            mskTelefon.Text = "";
                

        }
        #endregion

        //Sil Butonu
        #region
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            DataGridViewRow satır = dataGridView1.CurrentRow;
            String dize = "delete from Nakliyeci where NakliyeciId='" + satır.Cells[0].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(dize, baglanti);
            metot.ekle_sil_güncelle(komut, dize);
            TabloCgr();
        }
        #endregion

        //Güncelle Butonu
        #region
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            String cml = "update Nakliyeci set Adı=@p1,Soyadı=@p2,Telefon=@p3,EPosta=@p4" +
                " WHERE NakliyeciId=@p5";

            SqlCommand komt = new SqlCommand(cml, baglanti);
            komt.Parameters.AddWithValue("@p1", txtAd.Text);
            komt.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komt.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komt.Parameters.AddWithValue("@p4", txteposta.Text);
            komt.Parameters.AddWithValue("@p5", txtId.Text);
            komt.ExecuteNonQuery();
            metot.ekle_sil_güncelle(komt, cml);
            foreach (Control cml2 in Controls) if (cml2 is TextBox) cml2.Text = "";
            TabloCgr();
            baglanti.Close();
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txteposta.Text = "";
            mskTelefon.Text = "";
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
        private void FrmNakliyeci_Ayarları_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) { btnKaydet.PerformClick(); }
            if (e.Alt && e.KeyCode==Keys.Delete) { btnSil.PerformClick(); }
            if (e.Alt && e.KeyCode==Keys.G) { btnGüncelle.PerformClick(); }
            if (e.Alt && e.KeyCode==Keys.I) { btnİptal.PerformClick(); }
            if (e.KeyCode==Keys.Escape) { btnGeri.PerformClick(); }
        }
        #endregion

        
    }
}

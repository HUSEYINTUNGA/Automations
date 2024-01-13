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
    public partial class FrmUcret_Hesapla : Form
    {
        Methods metot = new Methods();
        public FrmUcret_Hesapla()
        {
            InitializeComponent();
        }

        private void TablCagr()
        {
            String cml = "select*from Calısan";
            SqlDataAdapter dr = new SqlDataAdapter();
            dataGridView1.DataSource = metot.list(dr, cml);
        }

        private void FrmUcret_Hesapla_Load(object sender, EventArgs e)
        {
            TablCagr();
            

        }
        
        /* Bilgilerini güncelleyeceğimiz müşterinin tablo üzerinde herhangi
      bir bilgisini içeren kutucuğa tıkladığımızda textboxlara bilgileri yazması*/
        #region
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBaslangıc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtCıkıs.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        #endregion

        //Hesapla Butonu
        #region
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double hesap;
            TimeSpan fark = Convert.ToDateTime(txtCıkıs.Text) - Convert.ToDateTime(txtBaslangıc.Text);
            int fark1 = Convert.ToInt32(fark.TotalDays) + 1;
            hesap = fark1 * Convert.ToInt32(txtUcret.Text);
            MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " isimli çalışanın" +
                " emeğinin karşılığı\n" + hesap.ToString() + "TL");
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
        private void FrmUcret_Hesapla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnHesapla.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnGeri.PerformClick();
            }
        }
        #endregion


    }
}

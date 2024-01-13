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
    public partial class FrmFatura : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        Methods methot = new Methods();
        public FrmFatura()
        {
            InitializeComponent();
        }
        private void CGRTABL()
        {
            string cml = "select*from Musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = methot.list(adtr2, cml);

        }

        private void Fatura_Load(object sender, EventArgs e)
        {

            CGRTABL();

        }
        /* Bilgilerini güncelleyeceğimiz müşterinin tablo üzerinde herhangi
        bir bilgisini içeren kutucuğa tıkladığımızda textboxlara bilgileri yazması*/
        #region
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt1arac.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt2arac.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txt3arac.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txt4arac.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txt5arac.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtBosArac.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }
        #endregion

        //Hesapla Butonu
        #region
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double hesap,x,fiyat;
            int t1, t2, t3, t4, t5, tbos;
            t1 = Convert.ToInt16(txt1arac.Text);
            t2 = Convert.ToInt16(txt2arac.Text);
            t3 = Convert.ToInt16(txt3arac.Text);
            t4 = Convert.ToInt16(txt4arac.Text);
            t5 = Convert.ToInt16(txt5arac.Text);
            tbos = Convert.ToInt16(txtBosArac.Text);
            fiyat = Convert.ToDouble(txtFiyat.Text);
            x = fiyat / 1000;

            if (t2==0&&t3==0&&t4==0&&t5==0)
            {
                hesap = (t1 - tbos) * x;
            }
            else if(t3 == 0 && t4 == 0 && t5 == 0)
            {
                hesap = ((t1 + t2) - 2 * tbos) * x;
            }
            else if(t4 == 0 && t5 == 0)
            {
                hesap = ((t1 + t2 + t3) - 3 * tbos) * x;
            }
            else if (t5 == 0)
            {
                hesap = ((t1 + t2 + t3 + t4) - 4 * tbos) * x;
            }
            else
            {
                hesap = ((t1 + t2 + t3 + t4+t5) - 5 * tbos) * x;
            }
           
            MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + "\n" + hesap + " TL");
            
        }
        #endregion
        //Geri Butonu
        #region
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Close();
        }
        #endregion
        //Butonlara Tuş Atama
        #region
        private void Fatura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHesapla.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnGeri.PerformClick();
            }
        }
        #endregion
    }
}

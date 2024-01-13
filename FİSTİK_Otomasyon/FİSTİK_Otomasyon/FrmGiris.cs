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
    public partial class FrmGiris : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        SqlCommand scmnd = new SqlCommand();
        SqlDataReader sdrdr;

        

        public FrmGiris()
        {
            InitializeComponent();
        }

        //Giriş Butonu
        #region
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection sconn = new SqlConnection(bgl.Adres);
            string user = txtKAdı.Text;
            string password = txtSifre.Text;
            sconn.Open();
            scmnd.Connection = sconn;
            scmnd.CommandText = "Select*From Yonetici where Ad= '" + txtKAdı.Text +
            "'And Sifre='" + txtSifre.Text + "'";
            sdrdr = scmnd.ExecuteReader();
            if (sdrdr.Read())
            {
               
                FrmAnaMenu gcs = new FrmAnaMenu();
                gcs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı veya Eksik bilgi girişi yaptınız!");
            }
            sconn.Close();
        }
        #endregion

        //LinkLabel Şifremi Unuttum
        #region
        private void lnkSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremi_Unuttum gcs = new FrmSifremi_Unuttum();
            gcs.Show();
            this.Hide();

        }
        #endregion

        //Butona Tuş Atama
        #region
        private void FrmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }

        }
        #endregion
    }
}

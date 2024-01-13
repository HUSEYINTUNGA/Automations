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
    
    public partial class FrmSaha_Goruntule : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public FrmSaha_Goruntule()
        {
            InitializeComponent();
        }

        /*Tesis Sahası text'li groupBox'ın alanları içerisinde dolu ve boş olanların ayırma.
              Dolu bölgelerin rengini kırmızı yapma ve rezerve edilen kişinin ismini yazdırma*/
        private void FrmSaha_Ayarları_Load(object sender, EventArgs e)
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
                }
                #endregion
            
        }

        //Ana Menüye Dön Butonu
        #region
        private void btnAnamenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
        #endregion
    }
}

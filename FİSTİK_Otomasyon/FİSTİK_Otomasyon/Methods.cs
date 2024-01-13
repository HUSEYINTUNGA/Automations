using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace FİSTİK_Otomasyon
{
    class Methods
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable tablo;

        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable list(SqlDataAdapter adtr, string sorgu)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);


            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}

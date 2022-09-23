using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.KullaniciModulu.Class
{
    class cls_frmKullaniciListesi : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_KullaniciListe_Bilgileri()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select KullaniciID,Ad,Soyad,Eposta,Telefon,KullaniciAdi,Sifre,Aciklama,Admin from Muhasebe_TBL_Kullanicilar where IsActive=1 order by Ad asc", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public DataTable Gel_KullaniciKarti_Bilgileri_Arama(string aranacakKelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter(string.Format("select KullaniciID,Ad,Soyad,Eposta,Telefon,KullaniciAdi,Sifre,Aciklama,Admin from Muhasebe_TBL_Kullanicilar where IsActive=1 {0}", aranacakKelime), con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] Gel_KullaniciKarti_Bilgileri(string gelKulID)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[10];
            SqlCommand dap = new SqlCommand("select KullaniciID,Ad,Soyad,Eposta,Telefon,KullaniciAdi,Sifre,Aciklama,Admin from Muhasebe_TBL_Kullanicilar where IsActive=1 and KullaniciID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelKulID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["KullaniciID"].ToString();
                    KartBilgileri[1] = dr["Ad"].ToString();
                    KartBilgileri[2] = dr["Soyad"].ToString();
                    KartBilgileri[3] = dr["Eposta"].ToString();
                    KartBilgileri[4] = dr["Telefon"].ToString();
                    KartBilgileri[5] = dr["KullaniciAdi"].ToString();
                    KartBilgileri[6] = dr["Sifre"].ToString();
                    KartBilgileri[7] = dr["Aciklama"].ToString();
                    KartBilgileri[8] = dr["Admin"].ToString();
                }
            }
            else
            {
                KartBilgileri[0] = "";
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KartBilgileri;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

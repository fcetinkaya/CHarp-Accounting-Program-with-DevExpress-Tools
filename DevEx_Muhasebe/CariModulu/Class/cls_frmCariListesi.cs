using System;
using System.Data;
using System.Data.SqlClient;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Cariler.Class
{
    class cls_frmCariListesi:IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_CariListe_Bilgileri()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select TOP 25 CariID,CariKodu,CariIsim,Ilce,Sehir,Ulke,Telefon,Fax,Email,Web,Tc,PostaKodu,VergiDairesi,VergiNo,Tipi,TipiValue from Muhasebe_TBL_Cariler where IsActive=1 order by CariIsim", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public DataTable Gel_CariKarti_Bilgileri_Arama(string aranacakKelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter(string.Format("select CariID,CariKodu,CariIsim,Ilce,Sehir,Ulke,Telefon,Fax,Email,Web,Tc,PostaKodu,VergiDairesi,VergiNo,Tipi,TipiValue from Muhasebe_TBL_Cariler where IsActive=1 {0}", aranacakKelime), con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static string[] Gel_CariKarti_Bilgileri(string gelCariId)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[17];
            SqlCommand dap = new SqlCommand("select CariID,CariKodu,CariIsim,Adres,Ilce,Sehir,Ulke,Telefon,Fax,Email,Web,Tc,PostaKodu,VergiDairesi,VergiNo,Tipi,TipiValue from Muhasebe_TBL_Cariler where IsActive=1 and CariID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelCariId);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["CariID"].ToString();
                    KartBilgileri[1] = dr["CariKodu"].ToString();
                    KartBilgileri[2] = dr["CariIsim"].ToString();
                    KartBilgileri[3] = dr["Ilce"].ToString();
                    KartBilgileri[4] = dr["Sehir"].ToString();
                    KartBilgileri[5] = dr["Ulke"].ToString();
                    KartBilgileri[6] = dr["Telefon"].ToString();
                    KartBilgileri[7] = dr["Fax"].ToString();
                    KartBilgileri[8] = dr["Email"].ToString();
                    KartBilgileri[9] = dr["Web"].ToString();
                    KartBilgileri[10] = dr["Tc"].ToString();
                    KartBilgileri[11] = dr["PostaKodu"].ToString();
                    KartBilgileri[12] = dr["VergiDairesi"].ToString();
                    KartBilgileri[13] = dr["VergiNo"].ToString();
                    KartBilgileri[14] = dr["TipiValue"].ToString();
                    KartBilgileri[15] = dr["Adres"].ToString();
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

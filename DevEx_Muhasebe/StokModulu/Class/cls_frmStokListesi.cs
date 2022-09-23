using Gelisim_Muhasebe.Tools;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gelisim_Muhasebe._Class
{
    class cls_frmStokListesi : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_StokListe_Bilgileri()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Stoklar.StokID,Muhasebe_TBL_Stoklar.StokKodu,Muhasebe_TBL_Stoklar.StokAdi,Muhasebe_TBL_Stoklar.Birim,Muhasebe_TBL_Stoklar.AlisFiyat1,Muhasebe_TBL_Stoklar.SatisFiyat1,Muhasebe_TBL_StokKodBir.Kod1,Muhasebe_TBL_StokKodIki.Kod2,Muhasebe_TBL_StokKodUc.Kod3,Muhasebe_TBL_StokKodDort.Kod4,Muhasebe_TBL_StokKodBes.Kod5 from Muhasebe_TBL_Stoklar left join Muhasebe_TBL_StokKodBir on Muhasebe_TBL_StokKodBir.Kod1ID=Muhasebe_TBL_Stoklar.Kod1 left join Muhasebe_TBL_StokKodIki on Muhasebe_TBL_StokKodIki.Kod2ID=Muhasebe_TBL_Stoklar.Kod2 left join Muhasebe_TBL_StokKodUc on Muhasebe_TBL_StokKodUc.Kod3ID=Muhasebe_TBL_Stoklar.Kod3 left join Muhasebe_TBL_StokKodDort  on Muhasebe_TBL_StokKodDort.Kod4ID=Muhasebe_TBL_Stoklar.Kod4 left join Muhasebe_TBL_StokKodBes on Muhasebe_TBL_StokKodBes.Kod5ID=Muhasebe_TBL_Stoklar.Kod5 where Muhasebe_TBL_Stoklar.IsActive=1", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static string[] Gel_StokKarti_Bilgileri(string _GeleStokID)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[25];
            SqlCommand dap = new SqlCommand("select * from Muhasebe_TBL_Stoklar where IsActive=1 and StokID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _GeleStokID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["StokKodu"].ToString();
                    KartBilgileri[1] = dr["StokAdi"].ToString();
                    KartBilgileri[2] = dr["Kod1"].ToString();
                    KartBilgileri[3] = dr["Kod2"].ToString();
                    KartBilgileri[4] = dr["Kod3"].ToString();
                    KartBilgileri[5] = dr["Kod4"].ToString();
                    KartBilgileri[6] = dr["Kod5"].ToString();
                    KartBilgileri[7] = dr["Birim"].ToString();
                    KartBilgileri[8] = dr["Barkod"].ToString();
                    KartBilgileri[9] = dr["AlisFiyat1"].ToString();
                    KartBilgileri[10] = dr["AlisKdv1"].ToString();
                    KartBilgileri[11] = dr["AlisFiyat2"].ToString();
                    KartBilgileri[12] = dr["AlisKdv2"].ToString();
                    KartBilgileri[13] = dr["SatisFiyat1"].ToString();
                    KartBilgileri[14] = dr["SatisKdv1"].ToString();
                    KartBilgileri[15] = dr["SatisFiyat2"].ToString();
                    KartBilgileri[16] = dr["SatisKdv2"].ToString();
                    KartBilgileri[17] = dr["StokID"].ToString();
                    KartBilgileri[18] = dr["IngilizceAdi"].ToString();
                    KartBilgileri[19] = dr["AlisKdv1Oran"].ToString();
                    KartBilgileri[20] = dr["AlisKdv2Oran"].ToString();
                    KartBilgileri[21] = dr["SatissKdv1Oran"].ToString();
                    KartBilgileri[22] = dr["SatissKdv2Oran"].ToString();
                }
            }
            else
            {
                KartBilgileri[0] = "";
            }
            return KartBilgileri;
        }
        public DataTable Gel_StokListe_Bilgileri_Arama(string _AranacakKelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Stoklar.StokID,Muhasebe_TBL_Stoklar.StokKodu,Muhasebe_TBL_Stoklar.StokAdi,Muhasebe_TBL_Stoklar.Birim,Muhasebe_TBL_Stoklar.AlisFiyat1,Muhasebe_TBL_Stoklar.SatisFiyat1,Muhasebe_TBL_StokKodBir.Kod1,Muhasebe_TBL_StokKodIki.Kod2,Muhasebe_TBL_StokKodUc.Kod3,Muhasebe_TBL_StokKodDort.Kod4,Muhasebe_TBL_StokKodBes.Kod5 from Muhasebe_TBL_Stoklar inner join Muhasebe_TBL_StokKodBir on Muhasebe_TBL_StokKodBir.Kod1ID=Muhasebe_TBL_Stoklar.Kod1 inner join Muhasebe_TBL_StokKodIki on Muhasebe_TBL_StokKodIki.Kod2ID=Muhasebe_TBL_Stoklar.Kod2 inner join Muhasebe_TBL_StokKodUc on Muhasebe_TBL_StokKodUc.Kod3ID=Muhasebe_TBL_Stoklar.Kod3 inner join Muhasebe_TBL_StokKodDort  on Muhasebe_TBL_StokKodDort.Kod4ID=Muhasebe_TBL_Stoklar.Kod4 inner join Muhasebe_TBL_StokKodBes on Muhasebe_TBL_StokKodBes.Kod5ID=Muhasebe_TBL_Stoklar.Kod5 where Muhasebe_TBL_Stoklar.IsActive=1 " + _AranacakKelime, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static string StokKodBilgileri(string _StokID, string _StokTabloAdi, string _StokKodAdi, string _StokIDAdi)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string Adi = "";
            SqlCommand com = new SqlCommand("select " + _StokKodAdi + " from " + _StokTabloAdi + " where " + _StokIDAdi + "=" + _StokID, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Adi = dr[0].ToString();
                }
            }
            con.Close();
            com.Dispose();
            dr.Close();
            return Adi;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

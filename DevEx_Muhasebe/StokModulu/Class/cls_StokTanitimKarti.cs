using Gelisim_Muhasebe.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Gelisim_Muhasebe._Class
{
    class cls_StokTanitimKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool StokKodKayit(string _StokKodu, string _StokAdi, string _IngilizceAdi, string _Kod1, string _Kod2, string _Kod3, string _Kod4, string _Kod5, string _Birim, string _Barkod, string _AlisFiyat1, string _AlisKdv1, string _AlisKDV1Oran, string _AlisFiyat2, string _AlisKdv2, string _AlisKDV2Oran, string _SatisFiyat1, string _SatisKdv1, string _SatisKDV1Oran, string _SatisFiyat2, string _SatisKdv2, string _SatisKDV2Oran, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Stoklar values(@StokKodu,@StokAdi,@Ingilizce,@Kod1,@Kod2,@Kod3,@Kod4,@Kod5,@Birim,@Barkod,@AlisFiyat1,@AlisKdv1,@AlisKdv1Oran,@AlisFiyat2,@AlisKdv2,@AlisKdv2Oran,@SatisFiyat1,@SatisKdv1,@SatissKdv1Oran,@SatisFiyat2,@SatisKdv2,@SatissKdv2Oran,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@StokKodu", _StokKodu);
            com.Parameters.AddWithValue("@StokAdi", _StokAdi);
            com.Parameters.AddWithValue("@Ingilizce", _IngilizceAdi);
            com.Parameters.AddWithValue("@Kod1", _Kod1);
            com.Parameters.AddWithValue("@Kod2", _Kod2);
            com.Parameters.AddWithValue("@Kod3", _Kod3);
            com.Parameters.AddWithValue("@Kod4", _Kod4);
            com.Parameters.AddWithValue("@Kod5", _Kod5);
            com.Parameters.AddWithValue("@Birim", _Birim);
            com.Parameters.AddWithValue("@Barkod", _Barkod);
            com.Parameters.AddWithValue("@AlisFiyat1", Convert.ToDouble(_AlisFiyat1));
            com.Parameters.AddWithValue("@AlisKdv1", Convert.ToDouble(_AlisKdv1));
            com.Parameters.AddWithValue("@AlisKdv1Oran", _AlisKDV1Oran);
            com.Parameters.AddWithValue("@AlisFiyat2", Convert.ToDouble(_AlisFiyat2));
            com.Parameters.AddWithValue("@AlisKdv2", Convert.ToDouble(_AlisKdv2));
            com.Parameters.AddWithValue("@AlisKdv2Oran", _AlisKDV2Oran);
            com.Parameters.AddWithValue("@SatisFiyat1", Convert.ToDouble(_SatisFiyat1));
            com.Parameters.AddWithValue("@SatisKdv1", Convert.ToDouble(_SatisKdv1));
            com.Parameters.AddWithValue("@SatissKdv1Oran", _SatisKDV1Oran);
            com.Parameters.AddWithValue("@SatisFiyat2", Convert.ToDouble(_SatisFiyat2));
            com.Parameters.AddWithValue("@SatisKdv2", Convert.ToDouble(_SatisKdv2));
            com.Parameters.AddWithValue("@SatissKdv2Oran", _SatisKDV2Oran);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@IsActive", true);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (com.ExecuteNonQuery() > 0)
            {
                con.Close();
                com.Dispose();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                return false;
            }
        }
        public bool StokGuncelle(string _StokKodu, string _StokAdi, string _IngilizceAdi, string _Kod1, string _Kod2, string _Kod3, string _Kod4, string _Kod5, string _Birim, string _Barkod, string _AlisFiyat1, string _AlisKdv1, string _AlisKDV1Oran, string _AlisFiyat2, string _AlisKdv2, string _AlisKDV2Oran, string _SatisFiyat1, string _SatisKdv1, string _SatisKDV1Oran, string _SatisFiyat2, string _SatisKdv2, string _SatisKDV2Oran, int _KullaniciID, string _GelenStokID){
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Stoklar set StokKodu=@StokKodu,StokAdi=@StokAdi,@Ingilizce=IngilizceAdi,Kod1=@Kod1,Kod2=@Kod2,Kod3=@Kod3,Kod4=@Kod4,Kod5=@Kod5,Birim=@Birim,Barkod=@Barkod,AlisFiyat1=@AlisFiyat1,AlisKdv1=@AlisKdv1,AlisFiyat2=@AlisFiyat2,AlisKdv2=@AlisKdv2,SatisFiyat1=@SatisFiyat1,SatisKdv1=@SatisKdv1,SatisFiyat2=@SatisFiyat2,SatisKdv2=@SatisKdv2,EditUserID=@EditUserID where StokID=@StokID", con);
            com.Parameters.AddWithValue("@StokKodu", _StokKodu);
            com.Parameters.AddWithValue("@StokAdi", _StokAdi);
            com.Parameters.AddWithValue("@Ingilizce", _IngilizceAdi);
            com.Parameters.AddWithValue("@Kod1", _Kod1);
            com.Parameters.AddWithValue("@Kod2", _Kod2);
            com.Parameters.AddWithValue("@Kod3", _Kod3);
            com.Parameters.AddWithValue("@Kod4", _Kod4);
            com.Parameters.AddWithValue("@Kod5", _Kod5);
            com.Parameters.AddWithValue("@Birim", _Birim);
            com.Parameters.AddWithValue("@Barkod", _Barkod);
            com.Parameters.AddWithValue("@AlisFiyat1", Convert.ToDouble(_AlisFiyat1));
            com.Parameters.AddWithValue("@AlisKdv1", Convert.ToDouble(_AlisKdv1));
            com.Parameters.AddWithValue("@AlisKdv1Oran", _AlisKDV1Oran);
            com.Parameters.AddWithValue("@AlisFiyat2", Convert.ToDouble(_AlisFiyat2));
            com.Parameters.AddWithValue("@AlisKdv2", Convert.ToDouble(_AlisKdv2));
            com.Parameters.AddWithValue("@AlisKdv2Oran", _AlisKDV2Oran);
            com.Parameters.AddWithValue("@SatisFiyat1", Convert.ToDouble(_SatisFiyat1));
            com.Parameters.AddWithValue("@SatisKdv1", Convert.ToDouble(_SatisKdv1));
            com.Parameters.AddWithValue("@SatissKdv1Oran", _SatisKDV1Oran);
            com.Parameters.AddWithValue("@SatisFiyat2", Convert.ToDouble(_SatisFiyat2));
            com.Parameters.AddWithValue("@SatisKdv2", Convert.ToDouble(_SatisKdv2));
            com.Parameters.AddWithValue("@SatissKdv2Oran", _SatisKDV2Oran);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@StokID", _GelenStokID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (com.ExecuteNonQuery() > 0)
            {
                con.Close();
                com.Dispose();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                return false;
            }
        }
        public bool StokKullanimdanKaldir(int _EditUserID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Stoklar set IsActive=0,EditUserID=@UID,EditDate=@DT where StokID=@ID", con);
            com.Parameters.AddWithValue("@ID", _GelenID);
            com.Parameters.AddWithValue("@UID", _EditUserID);
            com.Parameters.AddWithValue("@DT", DateTime.Now);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (com.ExecuteNonQuery() > 0)
            {
                con.Close();
                com.Dispose();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                return false;
            }
        }
        public bool StokKullanimdami(string _StokKodu)
        {
            SqlCommand com = new SqlCommand("select StokHareketID from Muhasebe_TBL_StokHareketleri where StokKodu=@Kod", con);
            com.Parameters.AddWithValue("@Kod", _StokKodu);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                com.Dispose();
                dr.Close();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                dr.Close();
                return false;
            }
        } // Kod Sayısına Dikkat
        public bool TopluStokGuncelle(string _SQLScript)
        {
            SqlCommand com = new SqlCommand(_SQLScript, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (com.ExecuteNonQuery() > 0)
            {
                con.Close();
                com.Dispose();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                return false;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.BankaModulu.Class
{
    class cls_frmGidenHavale : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool BankaHareketKayit(string _BelgeNo, string _FisNo, string _Tarih, double _tutar, string _Aciklama, string _CariID, string _BankaID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_BankaHareketleri values(@FisNo,@Makbuz,@Tarih,@GCKodu,@Tutar,@Aciklama,@Tipi,@CariID,@BankaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@EvrakTuru,@EvrakID,@IsActive)", con);
            com.Parameters.AddWithValue("@FisNo", _BelgeNo);
            com.Parameters.AddWithValue("@Makbuz", _FisNo);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GCKodu", "C");
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Tipi", "Giden");
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@BankaID", _BankaID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@EvrakTuru", DBNull.Value);
            com.Parameters.AddWithValue("@EvrakID", DBNull.Value);
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
        public bool BankaHareketGuncelle(string _BelgeNo, string _FisNo, string _Tarih, double _tutar, string _Aciklama, string _CariID, string _BankaID, int _KullaniciID, string _ID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_BankaHareketleri set FisNo=@FisNo,MakbuzNo=@Makbuz,Tarih=@Tarih,Tutar=@Tutar,Aciklama=@Aciklama,CariID=@CariID,BankaID=@BankaID,EditUserID=@EditUserID,EditDate=@EditDate where BankaHareketID=@ID", con);
            com.Parameters.AddWithValue("@FisNo", _BelgeNo);
            com.Parameters.AddWithValue("@Makbuz", _FisNo);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@BankaID", _BankaID);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _ID);
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
        public void BankaHareketSil(string _HareketID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_BankaHareketleri where BankaHareketID=@ID", con);
            com.Parameters.AddWithValue("@ID", _HareketID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public string[] CariKarti_Bilgileri(string gelCariId)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select CariKodu,CariIsim from Muhasebe_TBL_Cariler where IsActive=1 and CariID=@ID", con);
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
                    KartBilgileri[0] = dr["CariKodu"].ToString();
                    KartBilgileri[1] = dr["CariIsim"].ToString();
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
        public string[] BankaKarti_Bilgileri(string gelBankaID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select BankaKodu,BankaAdi from Muhasebe_TBL_Banka where IsActive=1 and BankaID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelBankaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["BankaKodu"].ToString();
                    KartBilgileri[1] = dr["BankaAdi"].ToString();
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
        public string[] BankaHareket_Bilgileri(string gel_ID)
        {
            string[] KartBilgileri = new string[8];
            SqlCommand dap = new SqlCommand("select FisNo,MakbuzNo,Tarih,GCKodu,Tutar,Aciklama,Tipi,CariID,BankaID from Muhasebe_TBL_BankaHareketleri where BankaHareketID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gel_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["FisNo"].ToString();
                    KartBilgileri[1] = dr["MakbuzNo"].ToString();
                    KartBilgileri[2] = dr["Tarih"].ToString();
                    KartBilgileri[3] = dr["GCKodu"].ToString();
                    KartBilgileri[4] = dr["Tutar"].ToString();
                    KartBilgileri[5] = dr["Aciklama"].ToString();
                    KartBilgileri[6] = dr["CariID"].ToString();
                    KartBilgileri[7] = dr["BankaID"].ToString();
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
        public string BankaID_Donder(string _gelBankaKod)
        {
            string KartID = "";
            SqlCommand dap = new SqlCommand("select BankaID from Muhasebe_TBL_Banka where IsActive=1 and BankaKodu=@Kod", con);
            dap.Parameters.AddWithValue("@Kod", _gelBankaKod);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartID = dr["BankaID"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KartID;
        }
        public string CariID_Donder(string _gelCariKod)
        {
            string KartID = "";
            SqlCommand dap = new SqlCommand("select CariID from Muhasebe_TBL_Cariler where IsActive=1 and CariKodu=@Kod", con);
            dap.Parameters.AddWithValue("@Kod", _gelCariKod);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartID = dr["CariID"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KartID;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

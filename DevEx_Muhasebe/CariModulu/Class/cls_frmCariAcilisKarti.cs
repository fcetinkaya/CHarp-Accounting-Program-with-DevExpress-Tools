using Gelisim_Muhasebe.Tools;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Gelisim_Muhasebe.CariModulu.Class
{
    internal class cls_frmCariAcilisKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool CariHareketKayit(string _Tarih, double _Borc, double _Alacak, string _Aciklama, string _CariID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_CariHareketler values(@FaturaNo,@BelgeNo,@Tarih,@Borc,@Alacak,@Aciklama,@VadeTarihi,@Tipi,@TipiValue,@CariID,@FaturaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate)", con);
            com.Parameters.AddWithValue("@FaturaNo", "Açılış Kaydı");
            com.Parameters.AddWithValue("@BelgeNo", DBNull.Value);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@Borc", _Borc);
            com.Parameters.AddWithValue("@Alacak", _Alacak);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@VadeTarihi", DBNull.Value);
            com.Parameters.AddWithValue("@Tipi", "Açılış Kayıt");
            com.Parameters.AddWithValue("@TipiValue", 4);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@FaturaID", DBNull.Value);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
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
        public bool cariHareketGuncelle(string _Tarih, double _Borc, double _Alacak, string _Aciklama, string _CariID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_CariHareketler set Tarih=@Tarih,Borc=@Borc,Alacak=@Alacak,Aciklama=@Aciklama,CariID=@CariID,EditUserID=@EditUserID,EditDate=@EditDate where CariID=@ID and FaturaNo='Açılış Kayıt'", con);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@Borc", _Borc);
            com.Parameters.AddWithValue("@Alacak", _Alacak);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _CariID);
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
        public void cariHareketSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_CariHareketler where CariHareketID=@ID", con);
            com.Parameters.AddWithValue("@ID", _FaturaID);
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
        public string[] CariHareket_Bilgileri(string gel_ID)
        {
            string[] KartBilgileri = new string[6];
            SqlCommand dap = new SqlCommand("select CariID,Tarih,Borc,Alacak,TipiValue,Aciklama from Muhasebe_TBL_CariHareketler where CariHareketID=@ID", con);
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
                    KartBilgileri[0] = dr["CariID"].ToString();
                    KartBilgileri[1] = dr["Tarih"].ToString();
                    KartBilgileri[2] = dr["Borc"].ToString();
                    KartBilgileri[3] = dr["Alacak"].ToString();
                    KartBilgileri[4] = dr["TipiValue"].ToString();
                    KartBilgileri[5] = dr["Aciklama"].ToString();
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Kasa.Class
{
    class cls_frmKasaAcilisKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool KasaHareketKayit(string _Tarih, string _GCKodu, double _tutar, string _KasaID, int _KullaniciID){
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_KasaHareketleri values(@FisNo,@Makbuz,@Tarih,@GCKodu,@Tutar,@Aciklama,@Tipi,@CariID,@KasaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@EvrakTuru,@EvrakID,@IsActive)", con);
            com.Parameters.AddWithValue("@FisNo", "Açılış Kayıt");
            com.Parameters.AddWithValue("@Makbuz", DBNull.Value.ToString());
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GCKodu", _GCKodu);
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", DBNull.Value);
            com.Parameters.AddWithValue("@Tipi", "Açılış Kayıt");
            com.Parameters.AddWithValue("@CariID", DBNull.Value);
            com.Parameters.AddWithValue("@KasaID", _KasaID);
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
        public bool KasaHareketGuncelle(string _Tarih, string _GCKodu, double _tutar, string _KasaID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_KasaHareketleri set Tarih=@Tarih,GCKodu=@GC,Tutar=@Tutar,KasaID=@KasaID,EditUserID=@EditUserID,EditDate=@EditDate where KasaHareketID=@ID and FisNo='Açılış Kayıt'", con);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GC", _GCKodu);
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@KasaID", _KasaID);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _KasaID);
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
        public void KasaHareketSil(string _HareketID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_KasaHareketleri where KasaHareketID=@ID", con);
            com.Parameters.AddWithValue("@ID", _HareketID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public string[] KasaKarti_Bilgileri(string gelKasaID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select KasaKodu,KasaAdi from Muhasebe_TBL_Kasa where IsActive=1 and KasaID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelKasaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["KasaKodu"].ToString();
                    KartBilgileri[1] = dr["KasaAdi"].ToString();
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
        public string[] KasaHareket_Bilgileri(string gel_ID)
        {
            string[] KartBilgileri = new string[5];
            SqlCommand dap = new SqlCommand("select Tarih,GCKodu,Tutar,BankaID from Muhasebe_TBL_KasaHareketleri where KasaHareketID=@ID", con);
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
                    KartBilgileri[0] = dr["Tarih"].ToString();
                    KartBilgileri[1] = dr["GCKodu"].ToString();
                    KartBilgileri[2] = dr["Tutar"].ToString();
                    KartBilgileri[3] = dr["BankaID"].ToString();
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
        public string KasaID_Donder(string _gelKasaKod)
        {
            string KartID = "";
            SqlCommand dap = new SqlCommand("select KasaID from Muhasebe_TBL_Kasa where IsActive=1 and KasaKodu=@Kod", con);
            dap.Parameters.AddWithValue("@Kod", _gelKasaKod);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartID = dr["KasaID"].ToString();
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

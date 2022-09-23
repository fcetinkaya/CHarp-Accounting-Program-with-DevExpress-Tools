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
    class cls_frmKasaTediye : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public string[] KasaKarti_Bilgileri(string gelKasaID)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select KasaKodu,KasaAdi,KasaID from Muhasebe_TBL_Kasa where IsActive=1 and KasaID=@ID", con);
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
                    KartBilgileri[2] = dr["KasaID"].ToString();
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
        public bool KasaHareketKayit(string _fisno, string _MakbuzNo, string _Tarih,string _GCKodu ,double _tutar, string _Aciklama,string _Tipi, string _CariID, string _KasaID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_KasaHareketleri values(@FisNo,@Makbuz,@Tarih,@GCKodu,@Tutar,@Aciklama,@Tipi,@CariID,@KasaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@EvrakTuru,@EvrakID,@IsActive)", con);
            com.Parameters.AddWithValue("@FisNo", _fisno);
            com.Parameters.AddWithValue("@Makbuz", _MakbuzNo);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GCKodu", _GCKodu);
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@CariID", _CariID);
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
        public bool KasaHareketGuncelle(string _fisno, string _MakbuzNo, string _Tarih, double _tutar, string _Aciklama, string _KasaID, string _CariID, int _KullaniciID,string _ID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_KasaHareketleri set FisNo=@FisNo,MakbuzNo=@Makbuz,Tarih=@Tarih,Tutar=@Tutar,Aciklama=@Aciklama,CariID=@CariID,KasaID=@KasaID,EditUserID=@EditUserID,EditDate=@EditDate where KasaHareketID=@ID", con);
            com.Parameters.AddWithValue("@FisNo", _fisno);
            com.Parameters.AddWithValue("@Makbuz", _MakbuzNo);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@KasaID", _KasaID);
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
        public string[] KasaHareket_Bilgileri(string _GelHareketID)
        {
            string[] KartBilgileri = new string[7];
            SqlCommand dap = new SqlCommand("select FisNo,MakbuzNo,Tarih,Tutar,Aciklama,CariID,KasaID from Muhasebe_TBL_KasaHareketleri where IsActive=1 and KasaHareketID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _GelHareketID);
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
                    KartBilgileri[3] = dr["Tutar"].ToString();
                    KartBilgileri[4] = dr["Aciklama"].ToString();
                    KartBilgileri[5] = dr["CariID"].ToString();
                    KartBilgileri[6] = dr["KasaID"].ToString();
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

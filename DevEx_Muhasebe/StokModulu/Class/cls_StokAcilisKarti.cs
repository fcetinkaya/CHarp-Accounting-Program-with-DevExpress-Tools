using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu.Class
{
    class cls_StokAcilisKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool stokHareketKayit(string _GCKod, double _Miktar, double _BrutFiyat, string _Aciklama, string _Tarih, string _StokID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_StokHareketleri(FaturaNo,GCKod,Miktar,BrutFiyat,Aciklama,Tipi,Tarih,StokID,SaveUserID,SaveDate) values(@FaturaNo,@GCKod,@Miktar,@BrutFiyat,@Aciklama,@Tipi,@Tarih,@StokID,@SaveUserID,@SaveDate)", con);
            com.Parameters.AddWithValue("@FaturaNo", "Açılış Kaydı");
            com.Parameters.AddWithValue("@GCKod", _GCKod);
            com.Parameters.AddWithValue("@Miktar", _Miktar);
            com.Parameters.AddWithValue("@BrutFiyat", _BrutFiyat);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Tipi", "Açılış Kaydı");
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@StokID", _StokID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);

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
        public bool stokHareketGuncelle(string _GCKod, double _Miktar, double _BrutFiyat, string _Aciklama, string _Tarih, string _StokID, int _KullaniciID, string _StokHareketID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_StokHareketleri set GCKod=@GCKod,Miktar=@Miktar,BrutFiyat=@BrutFiyat,Aciklama=@Aciklama,Tarih=@Tarih,StokID=@StokID,EditUserID=@EditUserID,EditDate=@EditDate where StokHareketID=@ID", con);
            com.Parameters.AddWithValue("@GCKod", _GCKod);
            com.Parameters.AddWithValue("@Miktar", _Miktar);
            com.Parameters.AddWithValue("@BrutFiyat", _BrutFiyat);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@StokID", _StokID);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _StokHareketID);

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
        public void stokHareketSil(string _GelStokHareketID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_StokHareketleri where StokHareketID=@StokHareketID", con);
            com.Parameters.AddWithValue("@StokHareketID", _GelStokHareketID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public string[] Gel_StokHareketleri_Bilgileri(string _GelStokHareketID)
        {
            string[] KartBilgileri = new string[6];
            SqlCommand dap = new SqlCommand("select GCKod,Miktar,BrutFiyat,Aciklama,Tarih,StokID from Muhasebe_TBL_StokHareketleri where IsActive=1 and StokHareketID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _GelStokHareketID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["GCKod"].ToString();
                    KartBilgileri[1] = dr["Miktar"].ToString();
                    KartBilgileri[2] = dr["BrutFiyat"].ToString();
                    KartBilgileri[3] = dr["Aciklama"].ToString();
                    KartBilgileri[4] = dr["Tarih"].ToString();
                    KartBilgileri[5] = dr["StokID"].ToString();
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
        public string[] Gel_StokKarti_Bilgileri(string _GeleStokID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select StokKodu,StokAdi from Muhasebe_TBL_Stoklar where IsActive=1 and StokID=@ID", con);
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
        public string Gel_StokID(string _GeleStokKodu)
        {
            string StokAydi = "";
            SqlCommand dap = new SqlCommand("select StokID from Muhasebe_TBL_Stoklar where StokKodu=@SK", con);
            dap.Parameters.AddWithValue("@SK", _GeleStokKodu);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    StokAydi = dr["StokID"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return StokAydi;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

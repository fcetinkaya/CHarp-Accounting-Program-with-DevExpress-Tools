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
    class cls_frmKasaTanitimKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool Kasa_Kayit(string _Kodu, string _Adi, string _Aciklama, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Kasa values(@Kodu,@Adi,@Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@Kodu", _Kodu);
            com.Parameters.AddWithValue("@Adi", _Adi);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
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
        public bool Kasa_Guncelle(string _Kodu, string _Adi, string _Aciklama, int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Kasa set KasaKodu=@KasaKodu,KasaAdi=@KasaAdi,KasaAciklama=@KasaAciklama,EditUserID=@EditUserID,EditDate=@EditDate where KasaID=@ID", con);
            com.Parameters.AddWithValue("@KasaKodu", _Kodu);
            com.Parameters.AddWithValue("@KasaAdi", _Adi);
            com.Parameters.AddWithValue("@KasaAciklama", _Aciklama);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _GelID);
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
        public bool Kasa_KoduVarMi(string _KasaKodu)
        {
            SqlCommand com = new SqlCommand("Select KasaID from Muhasebe_TBL_Kasa where KasaKodu=@KK", con);
            com.Parameters.AddWithValue("@KK", _KasaKodu);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                con.Close();
                com.Dispose();
                return true;
            }
            else
            {
                dr.Close(); con.Close();
                com.Dispose();
                return false;
            }
        }
        public string[] Gel_KasaKarti_Bilgileri(string gelKasaId)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[5];
            SqlCommand dap = new SqlCommand("select KasaID,KasaKodu,KasaAdi,KasaAciklama from Muhasebe_TBL_Kasa where IsActive=1 and KasaID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelKasaId);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["KasaID"].ToString();
                    KartBilgileri[1] = dr["KasaKodu"].ToString();
                    KartBilgileri[2] = dr["KasaAdi"].ToString();
                    KartBilgileri[3] = dr["KasaAciklama"].ToString();
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
        public bool Kasa_KullanimdaMi(string _KasaID)
        {
            SqlCommand com = new SqlCommand("Select KasaID from Muhasebe_TBL_KasaHareketleri where KasaID=@ID", con);
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
        public bool Kasa_KullanimdanKaldir(int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Kasa set IsActive=0,EditUserID=@EditUserID,EditDate=@EditDate where KasaID=@ID", con);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _GelID);
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
        public DataTable Gel_KasaBakiye(string _KasaID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Kasa.KasaID,Muhasebe_TBL_Kasa.KasaKodu,SUM((Case when GCKodu='G' Then Tutar else 0 end)) as GIRIS,SUM((case when GCKodu='C' then Tutar else 0 end)) as CIKIS,SUM((Case when GCKodu='G' Then Tutar else 0 end))-SUM((case when GCKodu='C' then Tutar else 0 end)) as BAKIYE from Muhasebe_TBL_Kasa inner join Muhasebe_TBL_KasaHareketleri on Muhasebe_TBL_Kasa.KasaID=Muhasebe_TBL_KasaHareketleri.KasaID where Muhasebe_TBL_KasaHareketleri.KasaID=@ID group by Muhasebe_TBL_Kasa.KasaID,Muhasebe_TBL_Kasa.KasaKodu", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _KasaID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

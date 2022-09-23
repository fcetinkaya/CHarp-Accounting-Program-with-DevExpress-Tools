using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.KullaniciModulu.Class
{
    class cls_frmKullanici : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool Kullanici_Kayit(string _Ad, string _Soyad, string _eposta, string _Telefon, string _KulAdi, string _Sifre, string _Aciklama, bool _Admin, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Kullanicilar values(@Ad,@Soyad,@Eposta,@Telefon,@KullaniciAdi,@Sifre,@Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@Ad", _Ad);
            com.Parameters.AddWithValue("@Soyad", _Soyad);
            com.Parameters.AddWithValue("@Eposta", _eposta);
            com.Parameters.AddWithValue("@Telefon", _Telefon);
            com.Parameters.AddWithValue("@KullaniciAdi", _KulAdi);
            com.Parameters.AddWithValue("@Sifre", _Sifre);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Admin", _Admin);
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
        public bool Kullanici_Guncelle(string _Ad, string _Soyad, string _eposta, string _Telefon, string _KulAdi, string _Sifre, string _Aciklama, bool _Admin, int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Kullanicilar set Ad=@Ad,Soyad=@Soyad,Eposta=@Eposta,Telefon=@Telefon,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Admin=@Admin,Aciklama=@Aciklama,EditUserID=@EditUserID,EditDate=@EditDate where KullaniciID=@ID", con);
            com.Parameters.AddWithValue("@Ad", _Ad);
            com.Parameters.AddWithValue("@Soyad", _Soyad);
            com.Parameters.AddWithValue("@Eposta", _eposta);
            com.Parameters.AddWithValue("@Telefon", _Telefon);
            com.Parameters.AddWithValue("@KullaniciAdi", _KulAdi);
            com.Parameters.AddWithValue("@Sifre", _Sifre);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Admin", _Admin);
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
        public bool Kullanici_KullanimdanKaldir(int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Kullanicilar set IsActive=0,EditUserID=@EditUserID,EditDate=@EditDate where KullaniciID=@ID", con);
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
        public bool Kullanici_KullanimaDevamEt(int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Kullanicilar set IsActive=1,EditUserID=@EditUserID,EditDate=@EditDate where KullaniciID=@ID", con);
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
        public static string[] Giris(string _KulAdi, string _Sifre)
        {
            string[] GitBilgi = new string[3];
            SqlConnection con = new SqlConnection(Yol.ECon);
            SqlCommand dap = new SqlCommand("select KullaniciID,Ad+' '+Soyad as [AdSoyad],Admin from Muhasebe_TBL_Kullanicilar where IsActive=1 and KullaniciAdi=@Adi and Sifre=@Sif", con);
            dap.Parameters.AddWithValue("@Adi", _KulAdi);
            dap.Parameters.AddWithValue("@Sif", _Sifre);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    GitBilgi[0] = dr["KullaniciID"].ToString();
                    GitBilgi[1] = dr["AdSoyad"].ToString();
                    GitBilgi[2] = dr["Admin"].ToString();
                }
                dap.Dispose();
                con.Close();
                dr.Close();
            }
            return GitBilgi;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

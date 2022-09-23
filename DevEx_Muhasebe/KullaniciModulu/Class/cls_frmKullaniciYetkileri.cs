using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.KullaniciModulu.Class
{
    class cls_frmKullaniciYetkileri : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public string[] Gel_KullaniciKarti_Bilgileri(string gelKulID)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select KullaniciID,Ad,Soyad from Muhasebe_TBL_Kullanicilar where IsActive=1 and KullaniciID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelKulID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["KullaniciID"].ToString();
                    KartBilgileri[1] = dr["Ad"].ToString();
                    KartBilgileri[2] = dr["Soyad"].ToString();
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
        public DataTable Gel_TumYetkiler()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select * from Muhasebe_TBL_Kullanicilar_Yetki order by Modul", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public void KullaniciIzinEkle(string _KulID, string _YekkiID, bool _durum, int SaveUserID)
        {
            SqlCommand comEk = new SqlCommand("insert into Muhasebe_TBL_Kullanicilar_Izinler values (@KulID,@YetID,@Durum,@SaveID,@SaveDate)", con);
            comEk.Parameters.AddWithValue("@KulID", _KulID);
            comEk.Parameters.AddWithValue("@YetID", _YekkiID);
            comEk.Parameters.AddWithValue("@Durum", _durum);
            comEk.Parameters.AddWithValue("@SaveID", SaveUserID);
            comEk.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            comEk.ExecuteNonQuery();
            con.Close();
            comEk.Dispose();
        }
        public void IzinleriSil(string _YetkileriSilinecekKulID)
        {
            SqlCommand comEk = new SqlCommand("delete from Muhasebe_TBL_Kullanicilar_Izinler where KullaniciID=@KulID", con);
            comEk.Parameters.AddWithValue("@KulID", _YetkileriSilinecekKulID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            comEk.ExecuteNonQuery();
            con.Close();
            comEk.Dispose();
        }
        public DataTable Kullanici_Yetkileri(string _KullaniciID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Kullanicilar_Yetki.YetkiID,Muhasebe_TBL_Kullanicilar_Yetki.Modul,Muhasebe_TBL_Kullanicilar_Yetki.Yetki,Muhasebe_TBL_Kullanicilar_Yetki.Aciklama,(Case When Muhasebe_TBL_Kullanicilar_Izinler.Durum IS NULL Then 'False' Else Muhasebe_TBL_Kullanicilar_Izinler.Durum END) as Izin from Muhasebe_TBL_Kullanicilar_Yetki inner join Muhasebe_TBL_Kullanicilar_Izinler on Muhasebe_TBL_Kullanicilar_Yetki.YetkiID=Muhasebe_TBL_Kullanicilar_Izinler.YetkiID where Muhasebe_TBL_Kullanicilar_Izinler.KullaniciID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _KullaniciID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public bool KullaniciYetkisiVarmi(string _KullaniciID)
        {
            SqlCommand dap = new SqlCommand("select top 1 KullaniciIzinID from Muhasebe_TBL_Kullanicilar_Izinler where KullaniciID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _KullaniciID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                dap.Dispose();
                con.Close();
                dr.Close();
                return true;
            }
            else
            {
                dap.Dispose();
                con.Close();
                dr.Close();
                return false;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

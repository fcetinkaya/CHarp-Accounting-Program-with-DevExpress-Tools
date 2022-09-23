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
    class cls_frmSifreDegistir : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool Kullanici_Sifredogrula(string _KulID, string _Sifre)
        {
            SqlCommand dap = new SqlCommand("select KullaniciID from Muhasebe_TBL_Kullanicilar where  Sifre=@Sifre and KullaniciID=@ID", con); dap.Parameters.AddWithValue("@ID", _KulID);
            dap.Parameters.AddWithValue("@Sifre", _Sifre);
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

        public bool Kullanici_SifreGuncelle(string _KulID, string _Sifre)
        {
            SqlCommand dap = new SqlCommand("update Muhasebe_TBL_Kullanicilar set Sifre=@Sifre where KullaniciID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _KulID);
            dap.Parameters.AddWithValue("@Sifre", _Sifre);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (dap.ExecuteNonQuery() > 0)
            {
                dap.Dispose();
                con.Close();
                return true;
            }
            else
            {
                dap.Dispose();
                con.Close();
                return false;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

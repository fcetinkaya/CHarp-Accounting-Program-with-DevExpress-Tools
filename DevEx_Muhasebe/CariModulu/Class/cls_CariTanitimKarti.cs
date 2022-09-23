using Gelisim_Muhasebe.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelisim_Muhasebe.Cariler.Class
{
    class cls_CariTanitimKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool CariKayit(string _CariKodu, string _CariIsim, string _Adres, string _Ilce, string _Sehir, string _Ulke, string _Telefon, string _Fax, string _Email, string _Web, string _Tc, string _PostaKodu, string _VergiDairesi, string _VergiNo, string _Tipi, string _TipiValue, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Cariler values(@CariKodu,@CariIsim,@Adres,@Ilce,@Sehir,@Ulke,@Telefon,@Fax,@Email,@Web,@Tc,@PostaKodu,@VergiDairesi,@VergiNo,@Tipi,@TipiValue,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@CariKodu", _CariKodu);
            com.Parameters.AddWithValue("@CariIsim", _CariIsim);
            com.Parameters.AddWithValue("@Adres", _Adres);
            com.Parameters.AddWithValue("@Ilce", _Ilce);
            com.Parameters.AddWithValue("@Sehir", _Sehir);
            com.Parameters.AddWithValue("@Ulke", _Ulke);
            com.Parameters.AddWithValue("@Telefon", _Telefon);
            com.Parameters.AddWithValue("@Fax", _Fax);
            com.Parameters.AddWithValue("@Email", _Email);
            com.Parameters.AddWithValue("@Web", _Web);
            com.Parameters.AddWithValue("@Tc", _Tc);
            com.Parameters.AddWithValue("@PostaKodu", _PostaKodu);
            com.Parameters.AddWithValue("@VergiDairesi", _VergiDairesi);
            com.Parameters.AddWithValue("@VergiNo", _VergiNo);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@TipiValue", _TipiValue);
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
        public bool CariGuncelle(string _CariKodu, string _CariIsim, string _Adres, string _Ilce, string _Sehir, string _Ulke, string _Telefon, string _Fax, string _Email, string _Web, string _Tc, string _PostaKodu, string _VergiDairesi, string _VergiNo, string _Tipi, string _TipiValue, string _GelenID, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Cariler set CariKodu=@CariKodu,CariIsim=@CariIsim,Adres=@Adres,Ilce=@Ilce,Sehir=@Sehir,Ulke=@Ulke,Telefon=@Telefon,Fax=@Fax,Email=@Email,Web=@Web,Tc=@Tc,PostaKodu=@PostaKodu,VergiDairesi=@VergiDairesi,VergiNo=@VergiNo,Tipi=@Tipi,TipiValue=@TipiValue,SaveUserID=@EditUserID,EditDate=@EditDate where CariID=@ID", con);
            com.Parameters.AddWithValue("@CariKodu", _CariKodu);
            com.Parameters.AddWithValue("@CariIsim", _CariIsim);
            com.Parameters.AddWithValue("@Adres", _Adres);
            com.Parameters.AddWithValue("@Ilce", _Ilce);
            com.Parameters.AddWithValue("@Sehir", _Sehir);
            com.Parameters.AddWithValue("@Ulke", _Ulke);
            com.Parameters.AddWithValue("@Telefon", _Telefon);
            com.Parameters.AddWithValue("@Fax", _Fax);
            com.Parameters.AddWithValue("@Email", _Email);
            com.Parameters.AddWithValue("@Web", _Web);
            com.Parameters.AddWithValue("@Tc", _Tc);
            com.Parameters.AddWithValue("@PostaKodu", _PostaKodu);
            com.Parameters.AddWithValue("@VergiDairesi", _VergiDairesi);
            com.Parameters.AddWithValue("@VergiNo", _VergiNo);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@TipiValue", _TipiValue);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _GelenID);
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
        public bool CariKullanimdanKaldir(int _EditUserID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Cariler set IsActive=0,EditUserID=@UID,EditDate=@DT where CariID=@ID", con);
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
        public bool CariKullanimdami(string _CariKodu)
        {
            SqlCommand com = new SqlCommand("select CariHareketID from Muhasebe_TBL_CariHareketler where CariKodu=@Kod", con);
            com.Parameters.AddWithValue("@Kod", _CariKodu);

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
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

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
    class cls_frmBankaTanitimKarti : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool Banka_Kayit(string _Kodu, string _Adi, string _Aciklama, string _HesapAdi, string _HesapNo, string _Iban, string _Sube, string _Tlf, string _Ilgili, int _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Banka values(@BankaKodu,@BankaAdi,@BankaAciklama,@HesapAdi,@HesapNo,@Iban,@Sube,@Tlf,@Ilgili,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@BankaKodu", _Kodu);
            com.Parameters.AddWithValue("@BankaAdi", _Adi);
            com.Parameters.AddWithValue("@BankaAciklama", _Aciklama);
            com.Parameters.AddWithValue("@HesapAdi", _HesapAdi);
            com.Parameters.AddWithValue("@HesapNo", _HesapNo);
            com.Parameters.AddWithValue("@Iban", _Iban);
            com.Parameters.AddWithValue("@Sube", _Sube);
            com.Parameters.AddWithValue("@Tlf", _Tlf);
            com.Parameters.AddWithValue("@Ilgili", _Ilgili);
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
        public bool Banka_Guncelle(string _Kodu, string _Adi, string _Aciklama, string _HesapAdi, string _HesapNo, string _Iban, string _Sube, string _Tlf, string _Ilgili, int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Banka set BankaKodu=@BankaKodu,BankaAdi=@BankaAdi,BankaAciklama=@BankaAciklama,HesapAdi=@HesapAdi,HesapNo=@HesapNo,Iban=@Iban,Sube=@Sube,Tlf=@Tlf,Ilgili=@Ilgili,EditUserID=@EditUserID,EditDate=@EditDate where BankaID=@ID", con);
            com.Parameters.AddWithValue("@BankaKodu", _Kodu);
            com.Parameters.AddWithValue("@BankaAdi", _Adi);
            com.Parameters.AddWithValue("@BankaAciklama", _Aciklama);
            com.Parameters.AddWithValue("@HesapAdi", _HesapAdi);
            com.Parameters.AddWithValue("@HesapNo", _HesapNo);
            com.Parameters.AddWithValue("@Iban", _Iban);
            com.Parameters.AddWithValue("@Sube", _Sube);
            com.Parameters.AddWithValue("@Tlf", _Tlf);
            com.Parameters.AddWithValue("@Ilgili", _Ilgili);
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
        public bool Banka_KoduVarMi(string _BankaKodu)
        {
            SqlCommand com = new SqlCommand("Select BankaID from Muhasebe_TBL_Banka where BankaKodu=@KK", con);
            com.Parameters.AddWithValue("@KK", _BankaKodu);
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
                dr.Close();con.Close();
                com.Dispose();
                return false;
            }
        }
        public string[] Gel_BankaKarti_Bilgileri(string gelKasaId)
        {
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] KartBilgileri = new string[10];
            SqlCommand dap = new SqlCommand("select BankaKodu,BankaAdi,BankaAciklama,HesapAdi,HesapNo,Iban,Sube,Tlf,Ilgili from Muhasebe_TBL_Banka where IsActive=1 and BankaID=@ID", con);
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
                    KartBilgileri[0] = dr["BankaKodu"].ToString();
                    KartBilgileri[1] = dr["BankaAdi"].ToString();
                    KartBilgileri[2] = dr["BankaAciklama"].ToString();
                    KartBilgileri[3] = dr["HesapAdi"].ToString();
                    KartBilgileri[4] = dr["HesapNo"].ToString();
                    KartBilgileri[5] = dr["Iban"].ToString();
                    KartBilgileri[6] = dr["Sube"].ToString();
                    KartBilgileri[7] = dr["Tlf"].ToString();
                    KartBilgileri[8] = dr["Ilgili"].ToString();
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
        public bool Banka_KullanimdaMi(string _KasaID)
        {
            SqlCommand com = new SqlCommand("Select BankaID from Muhasebe_TBL_BankaHareketleri where BankaID=@ID", con);
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
        public bool Banka_KullanimdanKaldir(int _KullaniciID, string _GelID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Banka set IsActive=0,EditUserID=@EditUserID,EditDate=@EditDate where BankaID=@ID", con);
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
        public DataTable Gel_BankaBakiye(string _KasaID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Banka.BankaID,Muhasebe_TBL_Banka.BankaKodu,SUM((Case when GCKodu='G' Then Tutar else 0 end)) as GIRIS,SUM((case when GCKodu='C' then Tutar else 0 end)) as CIKIS,SUM((Case when GCKodu='G' Then Tutar else 0 end))-SUM((case when GCKodu='C' then Tutar else 0 end)) as BAKIYE from Muhasebe_TBL_Banka inner join Muhasebe_TBL_BankaHareketleri on Muhasebe_TBL_Banka.BankaID=Muhasebe_TBL_BankaHareketleri.BankaID where Muhasebe_TBL_BankaHareketleri.BankaID=@ID group by Muhasebe_TBL_Banka.BankaID,Muhasebe_TBL_Banka.BankaKodu", con);
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

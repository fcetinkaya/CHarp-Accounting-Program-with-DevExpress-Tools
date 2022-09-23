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
    class cls_frmBankaListesi : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_BankaListesi()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select BankaID,BankaKodu,BankaAdi,BankaAciklama,HesapAdi,HesapNo,Iban,Sube,Tlf,Ilgili from Muhasebe_TBL_Banka where IsActive=1 order by BankaKodu", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public DataTable Gel_BankaListesi_Arama(string _Kelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select BankaID,BankaKodu,BankaAdi,BankaAciklama,HesapAdi,HesapNo,Iban,Sube,Tlf,Ilgili from Muhasebe_TBL_Banka where IsActive=1 and " + _Kelime, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] BankaKarti_Bilgileri(string gelBankaID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select BankaKodu,BankaAdi from Muhasebe_TBL_Banka where IsActive=1 and BankaID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelBankaID);
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

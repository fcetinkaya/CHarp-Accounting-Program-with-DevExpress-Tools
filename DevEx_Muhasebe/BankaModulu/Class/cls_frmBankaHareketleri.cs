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
    class cls_frmBankaHareketleri : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Banka_Hareketleri(string _BankaID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_BankaHareketleri.BankaHareketID,Muhasebe_TBL_Banka.BankaID,Muhasebe_TBL_Banka.BankaKodu,Muhasebe_TBL_Banka.BankaAdi,Muhasebe_TBL_Banka.HesapAdi,Muhasebe_TBL_Banka.HesapNo,Muhasebe_TBL_BankaHareketleri.Tarih,Muhasebe_TBL_BankaHareketleri.FisNo,Muhasebe_TBL_BankaHareketleri.MakbuzNo,(CASE WHEN Muhasebe_TBL_BankaHareketleri.GCKodu='G' THEN Muhasebe_TBL_BankaHareketleri.Tutar ELSE 0 END) As GIRIS,(CASE WHEN Muhasebe_TBL_BankaHareketleri.GCKodu='C' THEN Muhasebe_TBL_BankaHareketleri.Tutar ELSE 0 END) As CIKIS,Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_Cariler.CariIsim,Muhasebe_TBL_BankaHareketleri.Tipi,Muhasebe_TBL_Banka.BankaAciklama from Muhasebe_TBL_Banka inner join Muhasebe_TBL_BankaHareketleri on Muhasebe_TBL_Banka.BankaID=Muhasebe_TBL_BankaHareketleri.BankaID left join Muhasebe_TBL_Cariler on Muhasebe_TBL_BankaHareketleri.CariID= Muhasebe_TBL_Cariler.CariID where Muhasebe_TBL_Banka.BankaID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _BankaID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] BankaKarti_Bilgileri(string gelBankaID)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select BankaKodu,BankaAdi,BankaID from Muhasebe_TBL_Banka where IsActive=1 and BankaID=@ID", con);
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
                    KartBilgileri[2] = dr["BankaID"].ToString();
                }
            }
            else
            {
                KartBilgileri[0] = "";
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KartBilgileri;}
        public string[] BankaKarti_Bakiyeler(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select SUM((CASE WHEN GCKodu='G' THEN Tutar ELSE 0 END)) As ALACAK,SUM((CASE WHEN GCKodu='G' THEN Tutar ELSE 0 END)) As BORC,SUM((CASE WHEN GCKodu='C' THEN Tutar ELSE 0 END)) - SUM((CASE WHEN GCKodu='G' THEN Tutar ELSE 0 END)) as BAKIYE from Muhasebe_TBL_BankaHareketleri where BankaID=@ID", con);
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
                    KartBilgileri[0] = dr["BORC"].ToString();
                    KartBilgileri[1] = dr["ALACAK"].ToString();
                    KartBilgileri[2] = dr["BAKIYE"].ToString();
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

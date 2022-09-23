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
    class cls_frmKasaHareketleri : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Kasa_Hareketleri(string _KasaID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Kasa.KasaID,Muhasebe_TBL_Kasa.KasaKodu,Muhasebe_TBL_Kasa.KasaAdi,Muhasebe_TBL_Kasa.KasaAciklama,Muhasebe_TBL_KasaHareketleri.FisNo,Muhasebe_TBL_KasaHareketleri.KasaHareketID,Muhasebe_TBL_KasaHareketleri.Tarih,(CASE WHEN Muhasebe_TBL_KasaHareketleri.GCKodu='G' THEN Muhasebe_TBL_KasaHareketleri.Tutar ELSE 0 END) As GIRIS,(CASE WHEN Muhasebe_TBL_KasaHareketleri.GCKodu='C' THEN Muhasebe_TBL_KasaHareketleri.Tutar ELSE 0 END) As CIKIS,Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_Cariler.CariIsim,Muhasebe_TBL_KasaHareketleri.Tipi from Muhasebe_TBL_Kasa inner join Muhasebe_TBL_KasaHareketleri on Muhasebe_TBL_Kasa.KasaID=Muhasebe_TBL_KasaHareketleri.KasaID left join Muhasebe_TBL_Cariler on Muhasebe_TBL_KasaHareketleri.CariID= Muhasebe_TBL_Cariler.CariID where Muhasebe_TBL_Kasa.KasaID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _KasaID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
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
        public string[] KasaKarti_Bakiyeler(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select SUM((CASE WHEN GCKodu='G' THEN Tutar ELSE 0 END)) As ALACAK,SUM((CASE WHEN GCKodu='C' THEN Tutar ELSE 0 END)) As BORC,SUM((CASE WHEN GCKodu='G' THEN Tutar ELSE 0 END)) - SUM((CASE WHEN GCKodu='C' THEN Tutar ELSE 0 END)) as BAKIYE from Muhasebe_TBL_KasaHareketleri where KasaID=@ID", con);
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

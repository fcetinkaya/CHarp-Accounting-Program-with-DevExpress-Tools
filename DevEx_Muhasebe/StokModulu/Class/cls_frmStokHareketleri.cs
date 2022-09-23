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
    class cls_frmStokHareketleri : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_Stok_Hareketleri(string _cariID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_Cariler.CariIsim,Muhasebe_TBL_StokHareketleri.StokHareketID,Muhasebe_TBL_StokHareketleri.FaturaNo,Muhasebe_TBL_StokHareketleri.BelgeNo,Muhasebe_TBL_StokHareketleri.Tarih,Muhasebe_TBL_StokHareketleri.GCKod,Muhasebe_TBL_StokHareketleri.BrutFiyat,Muhasebe_TBL_StokHareketleri.Isk1,Muhasebe_TBL_StokHareketleri.Isk2,Muhasebe_TBL_StokHareketleri.Tipi,Muhasebe_TBL_StokHareketleri.Aciklama,Muhasebe_TBL_StokHareketleri.FaturaID,Muhasebe_TBL_StokHareketleri.StokID,Muhasebe_TBL_StokHareketleri.CariID,(Case when Muhasebe_TBL_StokHareketleri.GCKod='C' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end) as Cikis,(Case when Muhasebe_TBL_StokHareketleri.GCKod='G' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end) as Giris,(Muhasebe_TBL_StokHareketleri.BrutFiyat-((Muhasebe_TBL_StokHareketleri.BrutFiyat/100)*Muhasebe_TBL_StokHareketleri.Isk1)-(((Muhasebe_TBL_StokHareketleri.BrutFiyat-(Muhasebe_TBL_StokHareketleri.BrutFiyat/100)*Muhasebe_TBL_StokHareketleri.Isk1)/100)*Muhasebe_TBL_StokHareketleri.Isk2)) as NetFiyat from Muhasebe_TBL_StokHareketleri left join Muhasebe_TBL_Cariler on Muhasebe_TBL_Cariler.CariID=Muhasebe_TBL_StokHareketleri.CariID where Muhasebe_TBL_StokHareketleri.StokID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _cariID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] StokKarti_Bilgileri(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select StokKodu,StokAdi,StokID from Muhasebe_TBL_Stoklar where IsActive=1 and StokID=@ID", con);
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
                    KartBilgileri[0] = dr["StokKodu"].ToString();
                    KartBilgileri[1] = dr["StokAdi"].ToString();
                    KartBilgileri[2] = dr["StokID"].ToString();
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
        public string[] StokKarti_Bakiyeler(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select (Case when Muhasebe_TBL_StokHareketleri.GCKod='G' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end) as Giris,(Case when Muhasebe_TBL_StokHareketleri.GCKod='C' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end) as Cikis ,(Case when Muhasebe_TBL_StokHareketleri.GCKod='G' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end)-(Case when Muhasebe_TBL_StokHareketleri.GCKod='C' then Muhasebe_TBL_StokHareketleri.Miktar else 0 end) as Bakiye from Muhasebe_TBL_StokHareketleri where StokID=@ID", con);
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
                    KartBilgileri[0] = dr["Giris"].ToString();
                    KartBilgileri[1] = dr["Cikis"].ToString();
                    KartBilgileri[2] = dr["Bakiye"].ToString();
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

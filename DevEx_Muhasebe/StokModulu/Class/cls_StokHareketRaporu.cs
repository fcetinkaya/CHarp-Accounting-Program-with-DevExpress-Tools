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
    class cls_StokHareketRaporu:IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_StokListe_Bilgileri_Arama(string _AranacakKelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select * from View_ReportStokHareketleri " + _AranacakKelime, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] Gel_StokKarti_Bilgileri(string _GeleStokID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select StokKodu,StokAdi from Muhasebe_TBL_Stoklar where IsActive=1 and StokID=@ID", con);
            dap.Parameters.AddWithValue("@ID", _GeleStokID);
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

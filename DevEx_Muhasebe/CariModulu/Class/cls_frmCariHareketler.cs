using Gelisim_Muhasebe.Tools;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Gelisim_Muhasebe.CariModulu.Class
{
    internal class cls_frmCariHareketler : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_Cari_Hareketleri(string _cariID){
            SqlDataAdapter dap = new SqlDataAdapter("Select Muhasebe_TBL_CariHareketler.CariHareketID,Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_CariHareketler.FaturaNo,Muhasebe_TBL_Faturalar.BelgeNo,Muhasebe_TBL_CariHareketler.Tarih,Muhasebe_TBL_CariHareketler.Borc,Muhasebe_TBL_CariHareketler.Alacak,Muhasebe_TBL_CariHareketler.Aciklama,Muhasebe_TBL_CariHareketler.VadeTarihi,Muhasebe_TBL_CariHareketler.Tipi,Muhasebe_TBL_CariHareketler.FaturaID,DBO.FN_CariSatirBakiye(Muhasebe_TBL_Cariler.CariID,Muhasebe_TBL_CariHareketler.CariHareketID)-Muhasebe_TBL_CariHareketler.Borc+Muhasebe_TBL_CariHareketler.Alacak as Bakiye from Muhasebe_TBL_CariHareketler inner join Muhasebe_TBL_Cariler on Muhasebe_TBL_CariHareketler.CariID=Muhasebe_TBL_Cariler.CariID left join Muhasebe_TBL_Faturalar on Muhasebe_TBL_Faturalar.FaturaID=Muhasebe_TBL_CariHareketler.FaturaID where Muhasebe_TBL_CariHareketler.CariID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _cariID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] CariKarti_Bilgileri(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select CariKodu,CariIsim,CariID from Muhasebe_TBL_Cariler where IsActive=1 and CariID=@ID", con);
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
                    KartBilgileri[0] = dr["CariKodu"].ToString();
                    KartBilgileri[1] = dr["CariIsim"].ToString();
                    KartBilgileri[2] = dr["CariID"].ToString();
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
        public string[] CariKarti_Bakiyeler(string gelCariId)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select SUM(Borc) as Borc,Sum(Alacak) as Alacak, (Sum(Borc)-Sum(Alacak)) as Bakiye from Muhasebe_TBL_CariHareketler where CariID=@ID", con);
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
                    KartBilgileri[0] = dr["Borc"].ToString();
                    KartBilgileri[1] = dr["Alacak"].ToString();
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

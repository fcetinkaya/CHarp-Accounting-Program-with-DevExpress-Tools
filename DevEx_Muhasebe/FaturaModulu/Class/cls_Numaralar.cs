using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.FaturaModulu.Class
{
    class cls_Numaralar : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        // Numaralar Çekilir.
        public string Satis_FtNumarasi()
        {
            string FN = "";
            SqlCommand com = new SqlCommand("select TOP 1 FaturaNo from Muhasebe_TBL_Faturalar where TipiValue=0 order by FaturaSayisi desc", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    FN = dr["FaturaNo"].ToString();
                }
            }
            else
            {
                FN = "SF0000000000";
            }
            com.Dispose();
            con.Close();
            dr.Close();
            return FN;
        }
        public string SatisIade_FtNumarasi()
        {
            string FN = "";
            SqlCommand com = new SqlCommand("select FaturaNo from Muhasebe_TBL_Faturalar where TipiValue=2", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    FN = dr["FaturaNo"].ToString();
                }
            }
            else
            {
                FN = "SI0000000000";
            }
            com.Dispose();
            con.Close();
            dr.Close();
            return FN;
        }
        public string Alis_FtNumarasi()
        {
            string FN = "";
            SqlCommand com = new SqlCommand("select FaturaNo from Muhasebe_TBL_Faturalar where TipiValue=1", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    FN = dr["FaturaNo"].ToString();
                }
            }
            else
            {
                FN = "AF0000000000";
            }
            com.Dispose();
            con.Close();
            dr.Close();
            return FN;
        }
        public string AlisIade_FtNumarasi()
        {
            string FN = "";
            SqlCommand com = new SqlCommand("select FaturaNo from Muhasebe_TBL_Faturalar where TipiValue=3", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    FN = dr["FaturaNo"].ToString();
                }
            }
            else
            {
                FN = "AI0000000000";
            }
            com.Dispose();
            con.Close();
            dr.Close();
            return FN;
        }

        
        //// Yeni Numara Belirlenir.
        public string GetYeniStFtNumarasi()
        {
            string Numara = Satis_FtNumarasi();
            string[] GelP = cls_FaturaParametreleri.clsFtParametreleri();
            int uz = Convert.ToInt32(GelP[1]);
            int bas_Uzunluk = GelP[0].Length;
            Numara = Numara.Substring(bas_Uzunluk, Numara.Length - bas_Uzunluk);
            int Yeni = Convert.ToInt32(Numara);
            int yeni_uzun = Yeni.ToString().Length;
            string Sifirlar = "";
            int sayac = uz - bas_Uzunluk - yeni_uzun;
            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }
            Numara = GelP[0] + Sifirlar + (Yeni + 1);
            return Numara;
        }
        public string GetYeniStIadeFtNumarasi()
        {
            string Numara = SatisIade_FtNumarasi();
            string[] GelP = cls_FaturaParametreleri.clsFtParametreleri();
            int uz = Convert.ToInt32(GelP[3]);
            int bas_Uzunluk = GelP[2].Length;
            Numara = Numara.Substring(bas_Uzunluk, Numara.Length - bas_Uzunluk);
            int Yeni = Convert.ToInt32(Numara);
            int yeni_uzun = Yeni.ToString().Length;
            string Sifirlar = "";
            int sayac = uz - bas_Uzunluk - yeni_uzun;
            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }
            Numara = GelP[2] + Sifirlar + (Yeni + 1);
            return Numara;
        }
        public string GetYeniAlisFtNumarasi()
        {
            string Numara = Alis_FtNumarasi();
            string[] GelP = cls_FaturaParametreleri.clsFtParametreleri();
            int uz = Convert.ToInt32(GelP[5]);
            int bas_Uzunluk = GelP[4].Length;
            Numara = Numara.Substring(bas_Uzunluk, Numara.Length - bas_Uzunluk);
            int Yeni = Convert.ToInt32(Numara);
            int yeni_uzun = Yeni.ToString().Length;
            string Sifirlar = "";
            int sayac = uz - bas_Uzunluk - yeni_uzun;
            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }
            Numara = GelP[4] + Sifirlar + (Yeni + 1);
            return Numara;
        }
        public string GetYeniAlisIadeFtNumarasi()
        {
            string Numara = AlisIade_FtNumarasi();
            string[] GelP = cls_FaturaParametreleri.clsFtParametreleri();
            int uz = Convert.ToInt32(GelP[7]);
            int bas_Uzunluk = GelP[6].Length;
            Numara = Numara.Substring(bas_Uzunluk, Numara.Length - bas_Uzunluk);
            int Yeni = Convert.ToInt32(Numara);
            int yeni_uzun = Yeni.ToString().Length;
            string Sifirlar = "";
            int sayac = uz - bas_Uzunluk - yeni_uzun;
            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }
            Numara = GelP[6] + Sifirlar + (Yeni + 1);
            return Numara;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.FaturaModulu.Class
{
    class cls_FaturaParametreleri : IDisposable
    {
        public static string[] clsFtParametreleri()
        {     
            SqlConnection con = new SqlConnection(Yol.ECon);
            string[] parametre= new string[8];
            SqlCommand com = new SqlCommand("select SF_BAS_KAR,SF_UZN,AF_BAS_KAR,AF_UZN,SI_BAS_KAR,SI_UZN,AI_BAS_KAR,AI_UZN from Muhasebe_TBL_FtParametre", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows){
                while (dr.Read())
                {
                    parametre[0] = dr["SF_BAS_KAR"].ToString();
                    parametre[1] = dr["SF_UZN"].ToString();
                    parametre[2] = dr["SI_BAS_KAR"].ToString();
                    parametre[3] = dr["SI_UZN"].ToString();
                    parametre[4] = dr["AF_BAS_KAR"].ToString();
                    parametre[5] = dr["AF_UZN"].ToString();
                    parametre[6] = dr["AI_BAS_KAR"].ToString();
                    parametre[7] = dr["AI_UZN"].ToString();
                }
            }
            com.Dispose();
            con.Close();
            dr.Close();
            return parametre;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

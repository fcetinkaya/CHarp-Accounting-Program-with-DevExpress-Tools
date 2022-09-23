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
    class cls_frmKasaListesi : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public DataTable Gel_KasaListesi()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select KasaID,KasaKodu,KasaAdi,KasaAciklama from Muhasebe_TBL_Kasa where IsActive=1 order by KasaKodu", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public DataTable Gel_KasaListesi_Arama(string _Kelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select KasaID,KasaKodu,KasaAdi,KasaAciklama from Muhasebe_TBL_Kasa where IsActive=1 and " + _Kelime, con);
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

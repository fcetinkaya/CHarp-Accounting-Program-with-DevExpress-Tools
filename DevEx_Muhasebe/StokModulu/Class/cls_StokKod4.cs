using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe._Class
{
    class cls_StokKod4 : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool StokKodKayit(string _Kod, string _Aciklama, int _saveUserID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_StokKodDort values(@Kod4,@Kod4Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@Kullanimda)", con);
            com.Parameters.AddWithValue("@Kod4", _Kod);
            com.Parameters.AddWithValue("@Kod4Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@SaveUserID", _saveUserID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@Kullanimda", true);

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
        public bool StokKodGuncelleme(string _Kod, string _Aciklama, int _EditUserID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_StokKodDort set Kod4=@Kod4,Kod4Aciklama=@Kod4Aciklama where Kod4ID=@ID", con);
            com.Parameters.AddWithValue("@Kod4", _Kod);
            com.Parameters.AddWithValue("@Kod4Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@EditUserID", _EditUserID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@ID", _GelenID);

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
        public bool StokKodKullanimdanKaldir(int _EditUserID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_StokKodDort set Kullanimda=0,EditUserID=@UID,EditDate=@DT  where Kod4ID=@ID", con);
            com.Parameters.AddWithValue("@ID", _GelenID);
            com.Parameters.AddWithValue("@UID", _EditUserID);
            com.Parameters.AddWithValue("@DT", DateTime.Now);
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
        public bool StokKodSil(string _GelenID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_StokKodDort where Kod4ID=@ID", con);
            com.Parameters.AddWithValue("@ID", _GelenID);

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
        public bool StokKodKullanimdami(string _GelenID)
        {
            SqlCommand com = new SqlCommand("select StokID from Muhasebe_TBL_Stoklar where Kod4=@Kod4", con);
            com.Parameters.AddWithValue("@Kod4", _GelenID);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                com.Dispose();
                dr.Close();
                return true;
            }
            else
            {
                con.Close();
                com.Dispose();
                dr.Close();
                return false;
            }
        } // Kod Sayısına Dikkat
        public DataTable GelBilgiler()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Kod4ID,Kod4,Kod4Aciklama from Muhasebe_TBL_StokKodDort", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        // Toplu Stok işlemleri
        public string TopluStokEkleme_StokKodKullanimdami(string _StokKodAdi, int KulID)
        {
            string Gidecek = "";
            SqlCommand com = new SqlCommand("select Kod4ID from Muhasebe_TBL_StokKodDort where Kod4=@Kod4 or Kod4Aciklama=@Kod4", con);
            com.Parameters.AddWithValue("@Kod4", _StokKodAdi);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int GelStokID = Convert.ToInt32(com.ExecuteScalar());
            if (GelStokID > 0)
            {
                con.Close();
                com.Dispose();
                Gidecek = GelStokID.ToString();
            }
            else
            {
                SqlCommand com2 =
                    new SqlCommand(
                        "insert into Muhasebe_TBL_StokKodDort values(@Kod4,@Kod4Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@Kullanimda); select scope_identity()",
                        con);
                com2.Parameters.AddWithValue("@Kod4", _StokKodAdi);
                com2.Parameters.AddWithValue("@Kod4Aciklama", _StokKodAdi);
                com2.Parameters.AddWithValue("@SaveUserID", KulID.ToString());
                com2.Parameters.AddWithValue("@SaveDate", DateTime.Now);
                com2.Parameters.AddWithValue("@EditUserID", DBNull.Value);
                com2.Parameters.AddWithValue("@EditDate", DBNull.Value);
                com2.Parameters.AddWithValue("@Kullanimda", true);
                int GitStokID = Convert.ToInt32(com2.ExecuteScalar());
                if (GitStokID > 0)
                {
                    con.Close();
                    com.Dispose();
                    Gidecek = GitStokID.ToString();
                }
            }
            return Gidecek;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

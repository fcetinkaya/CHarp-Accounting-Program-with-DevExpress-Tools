using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe._Class
{
    class cls_StokKod2 : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool StokKodKayit(string _Kod, string _Aciklama, int _saveUserID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_StokKodIki values(@Kod2,@Kod2Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@Kullanimda)", con);
            com.Parameters.AddWithValue("@Kod2", _Kod);
            com.Parameters.AddWithValue("@Kod2Aciklama", _Aciklama);
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
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_StokKodIki set Kod2=@Kod2,Kod2Aciklama=@Kod2Aciklama where Kod2ID=@ID", con);
            com.Parameters.AddWithValue("@Kod2", _Kod);
            com.Parameters.AddWithValue("@Kod2Aciklama", _Aciklama);
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
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_StokKodIki set Kullanimda=0,EditUserID=@UID,EditDate=@DT  where Kod2ID=@ID", con);
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
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_StokKodIki where Kod2ID=@ID", con);
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
            SqlCommand com = new SqlCommand("select StokID from Muhasebe_TBL_Stoklar where Kod2=@Kod2", con);
            com.Parameters.AddWithValue("@Kod2", _GelenID);

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
            SqlDataAdapter dap = new SqlDataAdapter("select Kod2ID,Kod2,Kod2Aciklama from Muhasebe_TBL_StokKodIki", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
    
        // Toplu Stok işlemleri
        public string TopluStokEkleme_StokKodKullanimdami(string _StokKodAdi, int KulID)
        {
            string Gidecek = "";
            SqlCommand com = new SqlCommand("select Kod2ID from Muhasebe_TBL_StokKodIki where Kod2=@Kod2 or Kod2Aciklama=@Kod2", con);
            com.Parameters.AddWithValue("@Kod2", _StokKodAdi);
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
                        "insert into Muhasebe_TBL_StokKodIki values(@Kod2,@Kod2Aciklama,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@Kullanimda); select scope_identity()",
                        con);
                com2.Parameters.AddWithValue("@Kod2", _StokKodAdi);
                com2.Parameters.AddWithValue("@Kod2Aciklama", _StokKodAdi);
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

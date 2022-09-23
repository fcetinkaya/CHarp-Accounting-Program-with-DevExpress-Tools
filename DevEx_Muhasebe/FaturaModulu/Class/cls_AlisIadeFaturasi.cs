using Gelisim_Muhasebe.Tools;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gelisim_Muhasebe.FaturaModulu.Class
{
    class cls_AlisIadeFaturasi : IDisposable
    {
        SqlConnection con = new SqlConnection(Yol.ECon);
        public bool FtNumarasiKontrol(string _FtNo)
        {
            SqlCommand dap = new SqlCommand("select FaturaID from Muhasebe_TBL_Faturalar where IsActive=1 and FaturaNo=@No", con);
            dap.Parameters.AddWithValue("@No", _FtNo);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                dap.Dispose();
                dr.Close();
                return true;
            }
            else
            {
                con.Close();
                dap.Dispose();
                dr.Close();
                return false;
            }
        }

        #region FaturaKayitIslemleri
        public int faturaKayit(string _FaturaNo, string _BelgeNo, string _CariKodu, string _Tarih, string _VadeTarihi, string _Turu, string _Tipi, int _TipiValue, string _Aciklama, double _GenelToplam, string _CariID, string _KullaniciID, int _FaturaSayisi, string _OdemeYeri, string _OdemeID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_Faturalar values(@FaturaNo,@BelgeNo,@CariKodu,@Tarih,@VadeTarihi,@Turu,@Tipi,@TipiValue,@Aciklama,@GenelToplam,@CariID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@FaturaSayisi,@OdemeYeri,@OdemeID,@IsActive); select scope_identity()", con);
            com.Parameters.AddWithValue("@FaturaNo", _FaturaNo);
            com.Parameters.AddWithValue("@BelgeNo", _BelgeNo);
            com.Parameters.AddWithValue("@CariKodu", _CariKodu);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@VadeTarihi", _VadeTarihi);
            com.Parameters.AddWithValue("@Turu", _Turu);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@TipiValue", _TipiValue);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@GenelToplam", _GenelToplam);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@FaturaSayisi", _FaturaSayisi);
            com.Parameters.AddWithValue("@OdemeYeri", _OdemeYeri);
            com.Parameters.AddWithValue("@OdemeID", _OdemeID);
            com.Parameters.AddWithValue("@IsActive", true);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int aydiGit = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            com.Dispose();
            return aydiGit;
        }
        public bool faturaGuncelle(string _FaturaNo, string _BelgeNo, string _CariKodu, string _Tarih, string _VadeTarihi, string _Turu, string _Aciklama, double _GenelToplam, string _CariID, int _FaturaSayisi, string _KullaniciID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Faturalar set FaturaNo=@FaturaNo,BelgeNo=@BelgeNo,CariKodu=@CariKodu,Tarih=@Tarih,VadeTarihi=@VadeTarihi,Turu=@Turu,Aciklama=@Aciklama,GenelToplam=@GenelToplam,CariID=@CariID,EditUserID=@EditUserID,EditDate=@EditDate,FaturaSayisi=@FaturaSayisi where FaturaID=@ID", con);
            com.Parameters.AddWithValue("@FaturaNo", _FaturaNo);
            com.Parameters.AddWithValue("@BelgeNo", _BelgeNo);
            com.Parameters.AddWithValue("@CariKodu", _CariKodu);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@VadeTarihi", _VadeTarihi);
            com.Parameters.AddWithValue("@Turu", _Turu);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@GenelToplam", _GenelToplam);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@EditUserID", _KullaniciID);
            com.Parameters.AddWithValue("@EditDate", DateTime.Now);
            com.Parameters.AddWithValue("@FaturaSayisi", _FaturaSayisi);
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
        public bool faturaGuncelle_Odeme(string _OdemeYeri, int _OdemeID, int _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Faturalar set OdemeYeri=@OdemeYeri,OdemeID=@OdemeID where FaturaID=@ID", con);
            com.Parameters.AddWithValue("@OdemeYeri", _OdemeYeri);
            com.Parameters.AddWithValue("@OdemeID", _OdemeID);
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
        public bool FaturaKullanimdanKaldir(int _EditUserID, string _GelenID)
        {
            SqlCommand com = new SqlCommand("update Muhasebe_TBL_Faturalar set IsActive=0,EditUserID=@UID,EditDate=@DT where FaturaID=@ID", con);
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
        #endregion

        #region StokHareketKayitIslemleri
        public void stokHareketKayit(string _FaturaNo, string _BelgeNo, string _GCKod, double _Miktar, double _BrutFiyat, double _Isk1, double _Isk2, double _Kdv, string _Aciklama, string _Tipi, string _Tarih, string _CariID, string _StokID, string _FaturaID, string _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_StokHareketleri values(@FaturaNo,@BelgeNo,@GCKod,@Miktar,@BrutFiyat,@Isk1,@Isk2,@Kdv,@Aciklama,@Tipi,@Tarih,@FaturaID,@StokID,@CariID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@IsActive)", con);
            com.Parameters.AddWithValue("@FaturaNo", _FaturaNo);
            com.Parameters.AddWithValue("@BelgeNo", _BelgeNo);
            com.Parameters.AddWithValue("@GCKod", _GCKod);
            com.Parameters.AddWithValue("@Miktar", _Miktar);
            com.Parameters.AddWithValue("@BrutFiyat", _BrutFiyat);
            com.Parameters.AddWithValue("@Isk1", _Isk1);
            com.Parameters.AddWithValue("@Isk2", _Isk2);
            com.Parameters.AddWithValue("@Kdv", _Kdv);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@FaturaID", _FaturaID);
            com.Parameters.AddWithValue("@StokID", _StokID);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@IsActive", true);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public void stokHareketSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_StokHareketleri where FaturaID=@FaturaID", con);
            com.Parameters.AddWithValue("@FaturaID", _FaturaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public string[] Gel_StokKarti_Bilgileri(string _GeleStokID)
        {
            string[] KartBilgileri = new string[6];
            SqlCommand dap = new SqlCommand("select StokKodu,StokAdi,Birim,Barkod,SatisFiyat1,SatissKdv1Oran from Muhasebe_TBL_Stoklar where IsActive=1 and StokID=@ID", con);
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
                    KartBilgileri[2] = dr["Birim"].ToString();
                    KartBilgileri[3] = dr["Barkod"].ToString();
                    KartBilgileri[4] = dr["SatisFiyat1"].ToString();
                    KartBilgileri[5] = dr["SatissKdv1Oran"].ToString().Remove(0, 1);
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
        public string Gel_StokID(string _GeleStokKodu)
        {
            string StokAydi = "";
            SqlCommand dap = new SqlCommand("select StokID from Muhasebe_TBL_Stoklar where StokKodu=@SK", con);
            dap.Parameters.AddWithValue("@SK", _GeleStokKodu);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    StokAydi = dr["StokID"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return StokAydi;
        }
        #endregion

        #region CariHareketKayitIslemleri
        public void CariHareketKayit(string _FaturaNo, string _BelgeNo, string _Tarih, double _Borc, double _Alacak, string _Aciklama, string _VadeTarihi, string _Tipi, string _TipiValue, string _CariID, string _FaturaID, string _KullaniciID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_CariHareketler values(@FaturaNo,@BelgeNo,@Tarih,@Borc,@Alacak,@Aciklama,@VadeTarihi,@Tipi,@TipiValue,@CariID,@FaturaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate)", con);
            com.Parameters.AddWithValue("@FaturaNo", _FaturaNo);
            com.Parameters.AddWithValue("@BelgeNo", _FaturaNo);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@Borc", _Borc);
            com.Parameters.AddWithValue("@Alacak", _Alacak);
            com.Parameters.AddWithValue("@Aciklama", _Aciklama);
            com.Parameters.AddWithValue("@VadeTarihi", _VadeTarihi);
            com.Parameters.AddWithValue("@Tipi", _Tipi);
            com.Parameters.AddWithValue("@TipiValue", _TipiValue);
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@FaturaID", _FaturaID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }

        public string[] CariKarti_Bilgileri(string gelCariId)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select CariKodu,CariIsim from Muhasebe_TBL_Cariler where IsActive=1 and CariID=@ID", con);
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
        public string CariID_Donder(string _gelCariKod)
        {
            string KartID = "";
            SqlCommand dap = new SqlCommand("select CariID from Muhasebe_TBL_Cariler where IsActive=1 and CariKodu=@Kod", con);
            dap.Parameters.AddWithValue("@Kod", _gelCariKod);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartID = dr["CariID"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KartID;
        }
        public string[] BankaKarti_Bilgileri(string gelBankaID)
        {
            string[] KartBilgileri = new string[2];
            SqlCommand dap = new SqlCommand("select BankaAdi from Muhasebe_TBL_Banka where IsActive=1 and BankaID=@ID", con);
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
                    KartBilgileri[0] = dr["BankaAdi"].ToString();
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
        public string[] KasaKarti_Bilgileri(string gelKasaID)
        {
            string[] KartBilgileri = new string[3];
            SqlCommand dap = new SqlCommand("select KasaAdi from Muhasebe_TBL_Kasa where IsActive=1 and KasaID=@ID", con);
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
                    KartBilgileri[0] = dr["KasaAdi"].ToString();
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
        #endregion

        #region Güncellemeİşlemleri
        // Açık ve Kapalı Fatura İşlemleri...
        public int BankaHareketKayit(string _BelgeNo, string _Tarih, double _tutar, string _BankaID, int _KullaniciID, int _EvrakID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_BankaHareketleri values(@FisNo,@Makbuz,@Tarih,@GCKodu,@Tutar,@Aciklama,@Tipi,@CariID,@BankaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@EvrakTuru,@EvrakID,@IsActive); select scope_identity();", con);
            com.Parameters.AddWithValue("@FisNo", _BelgeNo);
            com.Parameters.AddWithValue("@Makbuz", DBNull.Value);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GCKodu", "G");
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", "Fatura Tahsilatı");
            com.Parameters.AddWithValue("@Tipi", "Fatura");
            com.Parameters.AddWithValue("@CariID", DBNull.Value);
            com.Parameters.AddWithValue("@BankaID", _BankaID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@EvrakTuru", "Alış iade Faturası");
            com.Parameters.AddWithValue("@EvrakID", _EvrakID);
            com.Parameters.AddWithValue("@IsActive", true);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int Aydicik = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            com.Dispose();
            return Aydicik;
        }
        public int KasaHareketKayit(string _fisno, string _Tarih, double _tutar, string _CariID, string _KasaID, int _KullaniciID, int _EvrakID)
        {
            SqlCommand com = new SqlCommand("insert into Muhasebe_TBL_KasaHareketleri values(@FisNo,@Makbuz,@Tarih,@GCKodu,@Tutar,@Aciklama,@Tipi,@CariID,@KasaID,@SaveUserID,@SaveDate,@EditUserID,@EditDate,@EvrakTuru,@EvrakID,@IsActive); select scope_identity();", con);
            com.Parameters.AddWithValue("@FisNo", _fisno);
            com.Parameters.AddWithValue("@Makbuz", DBNull.Value);
            com.Parameters.AddWithValue("@Tarih", _Tarih);
            com.Parameters.AddWithValue("@GCKodu", "G");
            com.Parameters.AddWithValue("@Tutar", _tutar);
            com.Parameters.AddWithValue("@Aciklama", "Fatura Tahsilatı");
            com.Parameters.AddWithValue("@Tipi", "Fatura");
            com.Parameters.AddWithValue("@CariID", _CariID);
            com.Parameters.AddWithValue("@KasaID", _KasaID);
            com.Parameters.AddWithValue("@SaveUserID", _KullaniciID);
            com.Parameters.AddWithValue("@SaveDate", DateTime.Now);
            com.Parameters.AddWithValue("@EditUserID", DBNull.Value);
            com.Parameters.AddWithValue("@EditDate", DBNull.Value);
            com.Parameters.AddWithValue("@EvrakTuru", "Alış iade Faturası");
            com.Parameters.AddWithValue("@EvrakID", _EvrakID);
            com.Parameters.AddWithValue("@IsActive", true);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int Aydicik = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            com.Dispose();
            return Aydicik;
        }
        public void CariHareketSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_CariHareketler where Tipi='Satış Faturası' and FaturaID=@FaturaID", con);
            com.Parameters.AddWithValue("@FaturaID", _FaturaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public void BankaHareketSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_BankaHareketleri where EvrakTuru='Satış Faturası' and EvrakID=@ID", con);
            com.Parameters.AddWithValue("@ID", _FaturaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public void KasaHareketSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_KasaHareketleri where EvrakTuru='Satış Faturası' and EvrakID=@ID", con);
            com.Parameters.AddWithValue("@ID", _FaturaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com.ExecuteNonQuery();
            con.Close();
            com.Dispose();
        }
        public string KasaAdi_Donder(string _KasaID)
        {
            string KasaAdi = "";
            SqlCommand dap = new SqlCommand("select KasaAdi from Muhasebe_TBL_Kasa where KasaID=(select KasaID from Muhasebe_TBL_KasaHareketleri where KasaHareketID=@ID)", con);
            dap.Parameters.AddWithValue("@ID", _KasaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KasaAdi = dr["KasaAdi"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return KasaAdi;
        }
        public string BankaAdi_Donder(string _BankaID)
        {
            string BankaAdi = "";
            SqlCommand dap = new SqlCommand("select BankaAdi from Muhasebe_TBL_Banka where BankaID=(select BankaID from Muhasebe_TBL_BankaHareketleri where BankaHareketID=@ID)", con);
            dap.Parameters.AddWithValue("@ID", _BankaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BankaAdi = dr["BankaAdi"].ToString();
                }
            }
            dap.Dispose();
            con.Close();
            dr.Close();
            return BankaAdi;
        }
        #endregion
        public bool FaturaSil(string _FaturaID)
        {
            SqlCommand com = new SqlCommand("delete from Muhasebe_TBL_Faturalar where FaturaID=@FaturaID", con);
            com.Parameters.AddWithValue("@FaturaID", _FaturaID);
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

        #region SatisFaturasiListelemeIslemleri
        public DataTable Gel_FaturaListe_Bilgileri()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_Cariler.CariIsim,Muhasebe_TBL_Faturalar.FaturaID,Muhasebe_TBL_Faturalar.FaturaNo,Muhasebe_TBL_Faturalar.BelgeNo,Muhasebe_TBL_Faturalar.Tarih,Muhasebe_TBL_Faturalar.GenelToplam,Muhasebe_TBL_Faturalar.Turu from Muhasebe_TBL_Faturalar inner join Muhasebe_TBL_Cariler on Muhasebe_TBL_Cariler.CariID=Muhasebe_TBL_Faturalar.CariID where Muhasebe_TBL_Faturalar.IsActive=1 and Muhasebe_TBL_Faturalar.TipiValue=3 order by Muhasebe_TBL_Faturalar.FaturaSayisi", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public DataTable Gel_FaturaListe_Bilgileri_Arama(string aranacakKelime)
        {
            SqlDataAdapter dap = new SqlDataAdapter(string.Format("select Muhasebe_TBL_Cariler.CariKodu,Muhasebe_TBL_Cariler.CariIsim,Muhasebe_TBL_Faturalar.FaturaID,Muhasebe_TBL_Faturalar.FaturaNo,Muhasebe_TBL_Faturalar.BelgeNo,Muhasebe_TBL_Faturalar.Tarih,Muhasebe_TBL_Faturalar.GenelToplam,Muhasebe_TBL_Faturalar.Turu from Muhasebe_TBL_Faturalar inner join Muhasebe_TBL_Cariler on Muhasebe_TBL_Cariler.CariID=Muhasebe_TBL_Faturalar.CariID where Muhasebe_TBL_Faturalar.IsActive=1 and Muhasebe_TBL_Faturalar.TipiValue=3 {0} order by Muhasebe_TBL_Faturalar.FaturaSayisi", aranacakKelime), con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public string[] FtBilgileri_Gel(string gelFaturaID)
        {
            string[] KartBilgileri = new string[10];
            SqlCommand dap = new SqlCommand("select Muhasebe_TBL_Faturalar.FaturaNo,Muhasebe_TBL_Faturalar.BelgeNo,Muhasebe_TBL_Faturalar.Tarih,Muhasebe_TBL_Faturalar.VadeTarihi,Muhasebe_TBL_Faturalar.Turu,Muhasebe_TBL_Faturalar.Aciklama,Muhasebe_TBL_Faturalar.CariID,Muhasebe_TBL_Faturalar.OdemeYeri,Muhasebe_TBL_Faturalar.OdemeID from Muhasebe_TBL_Faturalar inner join Muhasebe_TBL_Cariler on Muhasebe_TBL_Faturalar.CariID=Muhasebe_TBL_Cariler.CariID where Muhasebe_TBL_Faturalar.FaturaID=@ID", con);
            dap.Parameters.AddWithValue("@ID", gelFaturaID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = dap.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    KartBilgileri[0] = dr["FaturaNo"].ToString();
                    KartBilgileri[1] = dr["BelgeNo"].ToString();
                    KartBilgileri[2] = dr["Tarih"].ToString();
                    KartBilgileri[3] = dr["VadeTarihi"].ToString();
                    KartBilgileri[4] = dr["Aciklama"].ToString();
                    KartBilgileri[5] = dr["CariID"].ToString();
                    KartBilgileri[6] = dr["Turu"].ToString();
                    KartBilgileri[7] = dr["OdemeYeri"].ToString();
                    KartBilgileri[8] = dr["OdemeID"].ToString();
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
        public DataTable Gel_FaturaKalemleri(string _gelFtID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select Muhasebe_TBL_Stoklar.StokKodu,Muhasebe_TBL_Stoklar.StokAdi,Muhasebe_TBL_Stoklar.Birim,Muhasebe_TBL_Stoklar.Barkod,Muhasebe_TBL_Stoklar.SatisFiyat1 as Fiyat,Muhasebe_TBL_StokHareketleri.Miktar,Muhasebe_TBL_StokHareketleri.Isk1,Muhasebe_TBL_StokHareketleri.Isk2,Muhasebe_TBL_StokHareketleri.Kdv,((Muhasebe_TBL_Stoklar.SatisFiyat1*Muhasebe_TBL_StokHareketleri.Miktar)-((Muhasebe_TBL_Stoklar.SatisFiyat1*Muhasebe_TBL_StokHareketleri.Miktar)/100*Muhasebe_TBL_StokHareketleri.Isk1)-(((Muhasebe_TBL_Stoklar.SatisFiyat1*Muhasebe_TBL_StokHareketleri.Miktar)-((Muhasebe_TBL_Stoklar.SatisFiyat1*Muhasebe_TBL_StokHareketleri.Miktar)/100*Muhasebe_TBL_StokHareketleri.Isk1))/100*Muhasebe_TBL_StokHareketleri.Isk2)) as Toplam,Muhasebe_TBL_StokHareketleri.IsActive from Muhasebe_TBL_Stoklar inner join Muhasebe_TBL_StokHareketleri on Muhasebe_TBL_Stoklar.StokID=Muhasebe_TBL_StokHareketleri.StokID where Muhasebe_TBL_StokHareketleri.FaturaID=@ID", con); dap.SelectCommand.Parameters.AddWithValue("@ID", _gelFtID);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        #endregion

        public DataTable FaturaYazdir(string _ftID)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select * from View_FaturaDizayn where FaturaID=@ID", con);
            dap.SelectCommand.Parameters.AddWithValue("@ID", _ftID);
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

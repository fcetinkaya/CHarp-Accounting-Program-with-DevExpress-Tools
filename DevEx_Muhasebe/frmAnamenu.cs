using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System;
////using DevExpress.XtraPrinting.Export.Fakes;
using Gelisim_Muhasebe.BankaModulu;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.CekSenetModulu;
using Gelisim_Muhasebe.FaturaModulu.AlisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.frmSatisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisIadeFaturalari;
using Gelisim_Muhasebe.Kasa;
using Gelisim_Muhasebe.KasaModulu;
using Gelisim_Muhasebe.KullaniciModulu;
using Gelisim_Muhasebe.StokModulu;
using Gelisim_Muhasebe.StokModulu.Raporlar;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe
{
    public partial class frmAnamenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnamenu()
        {
            InitializeComponent();
        }
        public static int KullaniciID= 0;
        public static string AdSoyad = "";
        public static string SecilenKodAdi = "";
        public static string SecilenKodID = "";
        public static string SecilenCariAdi = "";
        public static string SecilenCariID = "";
        public static string SecilenFtID = "";
        public static string CorbaSecilenID = "";
        public static int Giris = 0;
        public static bool Server, Admin = false;
        void GirisIslemi()
        {
            frmGiris G = new frmGiris();
            G.ShowDialog();
            if (Giris == 1)
            {
                Show();
            }
            else if (Giris == 2)
            {
                G.ShowDialog();
                if (Giris == 1)
                {
                    Show();
                }
                else
                {
                    G.ShowDialog();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void frmAnamenu_Load(object sender, EventArgs e)
        {
            barBugunBtn.Caption = DateTime.Now.ToShortDateString();
            //Hide();
            //GirisIslemi();
            frmMasaustu M = new frmMasaustu();
            M.MdiParent = this;
            M.Show();
            Kullanicilar_KullaniciIslemleriGrup.Enabled = true;
            barUserBtn.Caption = AdSoyad;
        }

        #region Menu_StokIslemleri
        private void Menu_StokAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokAcilisKarti sta = new frmStokAcilisKarti();
            sta.ShowDialog();
        }
        private void Menu_StokListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokListesi sl = new frmStokListesi();
            sl.MdiParent = frmAnamenu.ActiveForm;
            sl.Show();
        }
        private void Menu_StokTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokTanitimKarti sl = new frmStokTanitimKarti();
            sl.ShowDialog();
        }
        private void Menu_StokHareketleriBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokHareketKayitlari shk = new frmStokHareketKayitlari();
            shk.MdiParent = frmAnamenu.ActiveForm;
            shk.Show();
        }
        private void Menu_StokHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
        private void Menu_TarihAraligiStokHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
        #endregion

        #region Menu_Cariİşlemleri
        private void Menu_CariTanitimKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariTanitimKarti CTK = new frmCariTanitimKarti();
            CTK.Show();
        }
        private void Menu_CariListelemeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariListesi CL = new frmCariListesi();
            CL.MdiParent = frmAnamenu.ActiveForm;
            CL.Show();
        }
        private void Menu_CariHareketleriBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariHareketleri CH = new frmCariHareketleri();
            CH.MdiParent = frmAnamenu.ActiveForm;
            CH.Show();
        }
        private void Menu_CariAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariAcilisKarti CAK = new frmCariAcilisKarti();
            CAK.Show();
        }
        private void Menu_CariHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void Menu_CariStokHareketRaporuBarBtn_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }
        private void Menu_OzelCariRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region Menu_FaturaIslemleri
        private void Menu_AlisFaturaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisFaturasiListesi AFL = new frmAlisFaturasiListesi();
            AFL.MdiParent = ActiveForm;
            AFL.Show();
        }
        private void Menu_AlisIadeFtBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisIadeFaturasi AIF = new frmAlisIadeFaturasi();
            AIF.MdiParent = ActiveForm;
            AIF.Show();
        }
        private void Menu_SatisIadeFtBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisIadeFaturasi SIF = new frmSatisIadeFaturasi();
            SIF.MdiParent = ActiveForm;
            SIF.Show();
        }
        private void Menu_AlisFaturasiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisFaturasi AF = new frmAlisFaturasi();
            AF.MdiParent = ActiveForm;
            AF.Show();
        }
        private void Menu_SatisFaturasiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisFaturasi sft = new frmSatisFaturasi();
            sft.MdiParent = frmAnamenu.ActiveForm;
            sft.Show();
        }
        private void Menu_SatisFaturaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisFaturasiListesi SFL = new frmSatisFaturasiListesi();
            SFL.MdiParent = ActiveForm;
            SFL.Show();
        }
        #endregion

        #region Menu_KasaIslemleri
        private void Menu_KasaTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTanitimKarti FK = new frmKasaTanitimKarti();
            FK.Show();
        }
        private void Menu_KasaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaListesi KL = new frmKasaListesi();
            KL.MdiParent = ActiveForm;
            KL.Show();
        }
        private void Menu_TahsilatBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTahsilat KT = new frmKasaTahsilat();
            KT.Show();
        }
        private void Menu_TediyeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTediye KT = new frmKasaTediye();
            KT.Show();
        }
        private void Menu_KasaIslemiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaIslemi KI = new frmKasaIslemi();
            KI.Show();
        }
        #endregion

        #region Menu_BankaIslemleri
        private void Menu_BankaTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaTanitimKarti BTK = new frmBankaTanitimKarti();
            BTK.Show();
        }
        private void Menu_BankaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaListesi BL = new frmBankaListesi();
            BL.MdiParent = ActiveForm;
            BL.Show();
        }
        private void Menu_GelenHavaleBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGelenHavale GH = new frmGelenHavale();
            GH.Show();
        }
        private void Menu_GonderilenHavaleBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGidenHavale GidH = new frmGidenHavale();
            GidH.Show();
        }
        private void Menu_BankaIslemiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaIslemi BI = new frmBankaIslemi();
            BI.Show();
        }
        #endregion

        private void Menu_GuvenliCikisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Application.Exit();
            }
        }
        //
        // Menü Tablar
        //
        #region Stok_StokIslemleri
        private void Stok_StokTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokTanitimKarti sl = new frmStokTanitimKarti();
            sl.ShowDialog();
        }
        private void Stok_StokListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokListesi sl = new frmStokListesi();
            sl.MdiParent = frmAnamenu.ActiveForm;
            sl.Show();
        }
        private void Stok_StokHareketKayitlariBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokHareketKayitlari shk = new frmStokHareketKayitlari();
            shk.MdiParent = frmAnamenu.ActiveForm;
            shk.Show();
        }
        private void Stok_StokAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokAcilisKarti sta = new frmStokAcilisKarti();
            sta.ShowDialog();
        }
        private void Stok_TopluStokAcmaBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTopluStokAcma tsa = new frmTopluStokAcma();
            tsa.MdiParent = frmAnamenu.ActiveForm;
            tsa.ShowDialog();
        }
        private void Stok_TopluStokGüncellemeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTopluStokGuncelleme tsg = new frmTopluStokGuncelleme();
            tsg.MdiParent = frmAnamenu.ActiveForm;
            tsg.ShowDialog();
        }
        private void Stok_StokKod1BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokKod1 SK = new frmStokKod1();
            SK.Show();
        }
        private void Stok_StokKod2BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokKod2 SK = new frmStokKod2();
            SK.Show();
        }
        private void Stok_StokKod3BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokKod3 SK = new frmStokKod3();
            SK.Show();
        }
        private void Stok_StokKod4BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokKod4 SK = new frmStokKod4();
            SK.Show();
        }
        private void Stok_StokKod5BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokKod5 SK = new frmStokKod5();
            SK.Show();
        }
        #endregion
        //
        #region FaturaIslemleri
        private void Fatura_SatisFtBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisFaturasi SF = new frmSatisFaturasi();
            SF.MdiParent = ActiveForm;
            SF.Show();
        }
        private void Fatura_SatisFtListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisFaturasiListesi SFL = new frmSatisFaturasiListesi();
            SFL.MdiParent = ActiveForm;
            SFL.Show();
        }
        private void Fatura_SatisIadeFtBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisIadeFaturasi SIF = new frmSatisIadeFaturasi();
            SIF.MdiParent = ActiveForm;
            SIF.Show();
        }
        private void Fatura_SatisFtIadeListeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisIadeFaturasiListesi SIFL = new frmSatisIadeFaturasiListesi();
            SIFL.MdiParent = ActiveForm;
            SIFL.Show();
        }
        private void Fatura_AlisFtBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisFaturasi AF = new frmAlisFaturasi();
            AF.MdiParent = ActiveForm;
            AF.Show();
        }
        private void Fatura_AlisFtListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisFaturasiListesi AFL = new frmAlisFaturasiListesi();
            AFL.MdiParent = ActiveForm;
            AFL.Show();
        }
        private void Fatura_AlisFtIadeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisIadeFaturasi AIF = new frmAlisIadeFaturasi();
            AIF.MdiParent = ActiveForm;
            AIF.Show();
        }
        private void Fatura_AlisIadeFtListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAlisIadeFaturasiListesi AIFL = new frmAlisIadeFaturasiListesi();
            AIFL.MdiParent = ActiveForm;
            AIFL.Show();
        }
        #endregion
        //
        #region CariIslemleri
        private void Cari_CariTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariTanitimKarti CTK = new frmCariTanitimKarti();
            CTK.Show();
        }
        private void Cari_CariListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariListesi CL = new frmCariListesi();
            CL.MdiParent = ActiveForm;
            CL.Show();
        }
        private void Cari_CariHareketKayitlariBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariHareketleri CH = new frmCariHareketleri();
            CH.MdiParent = ActiveForm;
            CH.Show();
        }
        private void Cari_CariAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariAcilisKarti CAK = new frmCariAcilisKarti();
            CAK.Show();
        }
        #endregion
        //
        #region KasaIslemleri
        private void Kasa_KasaTanitimKartibarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTanitimKarti KT = new frmKasaTanitimKarti();
            KT.Show();
        }
        private void Kasa_KasaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaListesi KL = new frmKasaListesi();
            KL.MdiParent = ActiveForm;
            KL.Show();
        }
        private void Kasa_KasaHareketleriBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaHareketleri KH = new frmKasaHareketleri();
            KH.MdiParent = ActiveForm;
            KH.Show();
        }
        private void Kasa_KasaAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaAcilisKarti KAK = new frmKasaAcilisKarti();
            KAK.MdiParent = ActiveForm;
            KAK.Show();
        }
        private void Kasa_TediyeGirisiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTediye KT = new frmKasaTediye();
            KT.Show();
        }
        private void Kasa_TahsilatGirisiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaTahsilat KTah = new frmKasaTahsilat();
            KTah.Show();
        }
        private void Kasa_BankaIslemiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaIslemi KI = new frmKasaIslemi();
            KI.Show();
        }
        #endregion
        //
        #region BankaIslemleri
        private void Banka_BankaTanitimKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaTanitimKarti KTK = new frmBankaTanitimKarti();
            KTK.Show();
        }
        private void Banka_BankaListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaListesi BL = new frmBankaListesi();
            BL.MdiParent = ActiveForm;
            BL.Show();
        }
        private void Banka_BankaIslemiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaIslemi BI = new frmBankaIslemi();
            BI.Show();
        }
        private void Banka_GelenHavaleBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGelenHavale GH = new frmGelenHavale();
            GH.Show();
        }
        private void Banka_GonderilenHavaleBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGidenHavale GidH = new frmGidenHavale();
            GidH.Show();
        }
        private void Banka_BankaHareketKayitlariBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaHareketleri BH = new frmBankaHareketleri();
            BH.MdiParent = ActiveForm;
            BH.Show();
        }
        private void Banka_BankaAcilisKartiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankaAcilisKarti BAK = new frmBankaAcilisKarti();
            BAK.Show();
        }
        #endregion
        //
        #region CekSenetIslemleri
        private void CekSenet_MusteriCekGirisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriCekGirisi MCG = new frmMusteriCekGirisi();
            MCG.Show();
        }
        private void CekSenet_CekBordroListeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCekBordroListesi CBL = new frmCekBordroListesi();
            CBL.MdiParent = ActiveForm;
            CBL.Show();
        }
        private void CekSenet_MusteriCekListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriCekListesi MCL = new frmMusteriCekListesi();
            MCL.MdiParent = ActiveForm;
            MCL.Show();
        }
        private void CekSenet_BankayaCekCikisiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankayaCekCikisi BCC = new frmBankayaCekCikisi();
            BCC.Show();
        }
        private void CekSenet_CariyeCekCikisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariyeCekCikisi CC = new frmCariyeCekCikisi();
            CC.MdiParent = ActiveForm;
            CC.Show();
        }
        private void CekSenet_KendiCekGirisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKendiCekGirisi KC = new frmKendiCekGirisi();
            KC.Show();
        }
        private void CekSenet_KendiCekListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKendiCekListesi KCL = new frmKendiCekListesi();
            KCL.MdiParent = ActiveForm;
            KCL.Show();
        }
        private void CekSenet_MusteriSenetGirisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriSenetGirisi MSG = new frmMusteriSenetGirisi();
            MSG.Show();
        }
        private void CekSenet_MusteriSenetBordroGirisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriSenetBordroGirisi MSBG = new frmMusteriSenetBordroGirisi();
            MSBG.Show();
        }
        private void CekSenet_SenetBordroListeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSenetBordroListesi SBL = new frmSenetBordroListesi();
            SBL.MdiParent = ActiveForm;
            SBL.Show();
        }
        private void CekSenet_MusteriSenetListeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriSenetListesi MSL = new frmMusteriSenetListesi();
            MSL.MdiParent = ActiveForm;
            MSL.Show();
        }
        private void CekSenet_BankayaSenetCikisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankayaSenetCikisi BSC = new frmBankayaSenetCikisi();
            BSC.Show();
        }
        private void CekSenet_CariyeSenetCikisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariyeCekCikisi CSC = new frmCariyeCekCikisi();
            CSC.Show();
        }
        private void CekSenet_SenetGirisBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriSenetGirisi SG = new frmMusteriSenetGirisi();
            SG.Show();
        }
        private void CekSenet_SenetListeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriSenetListesi SL = new frmMusteriSenetListesi();
            SL.MdiParent = ActiveForm;
            SL.Show();
        }
        #endregion
        //
        #region Raporlar
        private void Raporlar_CariStokHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariStokHareketRaporu CSR = new frmCariStokHareketRaporu();
            CSR.MdiParent = ActiveForm;
            CSR.Show();
        }
        private void Raporlar_CariHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariHareketRaporu CHR = new frmCariHareketRaporu();
            CHR.MdiParent = ActiveForm;
            CHR.Show();
        }
        private void Raporlar_OzelCariRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOzelCariRaporu OCR = new frmOzelCariRaporu();
            OCR.MdiParent = ActiveForm;
            OCR.Show();
        }
        private void Raporlar_StokHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStokHareketRaporu S = new frmStokHareketRaporu();
            S.MdiParent = ActiveForm;
            S.Show();
        }
        private void Raporlar_StokCariHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e){
            frmStokCariHareketRaporu CSHR = new frmStokCariHareketRaporu();
            CSHR.MdiParent = ActiveForm;
            CSHR.Show();
        }
        private void Raporlar_TarihAraligiStokHareketRaporuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTarihAraligiStokHareketRaporu SA = new frmTarihAraligiStokHareketRaporu();
            SA.MdiParent = ActiveForm;
            SA.Show();
        }
        #endregion
        //
        #region Kullanicilar
        private void Kullanicilar_KullaniciekleBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullanici K = new frmKullanici();
            K.Show();
        }
        private void Kullanicilar_KullaniciListesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciListesi KL = new frmKullaniciListesi();
            KL.MdiParent = ActiveForm;
            KL.Show();
        }
        private void Kullanicilar_KullaniciIzinleriBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciYetkileri KY = new frmKullaniciYetkileri();
            KY.MdiParent = ActiveForm;
            KY.Show();
        }
        private void Kullanicilar_SifreDegistirBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSifreDegistir SD = new frmSifreDegistir();
            SD.Show();
        }
        #endregion//
        //
        #region Ekstralar
        private void Ekstralar_HesapMakinesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("calc");
        }
        private void Ekstralar_MenuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMasaustu M = new frmMasaustu();
            M.MdiParent = this;
            M.Show();
        }
        private void Ekstralar_NotDefteriBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("notepad");
        }
        private void Ekstralar_WordBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("winword");
        }
        private void Ekstralar_ExcelBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("excel");
        }
        private void Ekstralar_WordPadBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("wordpad");
        }
        private void Ekstralar_BuyutecBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("magnify");
        }
        private void Ekstralar_KlavyeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("osk");
        }
        private void Ekstralar_EkranAlintisiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process snippingToolProcess = new Process();
            snippingToolProcess.EnableRaisingEvents = true;
            if (!Environment.Is64BitProcess)
            {
                snippingToolProcess.StartInfo.FileName = "C:\\Windows\\sysnative\\SnippingTool.exe";
                snippingToolProcess.Start();
            }
            else
            {
                snippingToolProcess.StartInfo.FileName = "C:\\Windows\\system32\\SnippingTool.exe";
                snippingToolProcess.Start();
            }
        }
        #endregion
        //
        #region Destekler
        private void Destek_KullanimKlavuzuBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath + "GelisimMuhasebe_EgitimKlavuzu.pdf");
        }
        private void Destek_UzaktanDestekBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void Destek_WebSitesiBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("www.gelisimsoft.com");
        }
        #endregion

        private void skinRibbonGalleryBarItem3_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            MessageBox.Show(e.Item.Caption);
        }
    }
}
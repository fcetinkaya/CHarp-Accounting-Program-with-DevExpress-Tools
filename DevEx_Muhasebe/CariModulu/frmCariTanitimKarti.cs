using System;
using System.Windows.Forms;
using Gelisim_Muhasebe.Cariler.Class;
using Gelisim_Muhasebe.StokModulu;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Cariler
{
    public partial class frmCariTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        cls_CariTanitimKarti CK = new cls_CariTanitimKarti();
        public static string CariID;
        public static string CariAdi;
        public static bool Edit = false;
        public frmCariTanitimKarti()
        {
            InitializeComponent();
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            CariKoduBox.Text = "";
            CariAdiBox.Text = "";
            AdresBox.Text = "";
            Ilcebox.Text = "";
            Sehirbox.Text = "";
            UlkeBox.Text = "";
            TelefonBox.Text = "";
            FaxBox.Text = "";
            VergiDairesiBox.Text = "";
            VergiNoBox.Text = "";
            TcKimlikNoBox.Text = "";
            PostaKoduBox.Text = "";
            EPostabox.Text = "";
            WebAdresbox.Text = "";
            MusteriTipiRadio.SelectedIndex = -1;
            frmAnamenu.SecilenCariAdi = string.Empty;
            frmAnamenu.SecilenCariID = string.Empty;
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CariKoduBox.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(CariKoduBox, "Boş Geçilmez.");
                }
                else
                {
                    if (CariAdiBox.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider2.SetError(CariAdiBox, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (AdresBox.Text.Trim() == String.Empty)
                        {
                            dxErrorProvider3.SetError(AdresBox, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (MusteriTipiRadio.SelectedIndex != -1)
                            {
                                int MusteriValue = Convert.ToInt32(MusteriTipiRadio.EditValue);
                                if (Edit)
                                {
                                    if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                    {
                                        if (
                                            CK.CariGuncelle(CariKoduBox.Text, CariAdiBox.Text, AdresBox.Text,
                                                Ilcebox.Text, Sehirbox.Text, UlkeBox.Text, TelefonBox.Text, FaxBox.Text,
                                                EPostabox.Text, WebAdresbox.Text, TcKimlikNoBox.Text, PostaKoduBox.Text,
                                                VergiDairesiBox.Text, VergiNoBox.Text,
                                                MusteriTipiRadio.Properties.Items[MusteriValue].Description,
                                                MusteriValue.ToString(), CariID, frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.GuncelleMesaji("Cari kartı güncellenmiştir.");
                                        }
                                    }
                                }
                                else
                                {
                                    if (cls_MesajBox.Sor("Kayıt etmek istediğinize emin misiniz ?"))
                                    {
                                        if (
                                               CK.CariKayit(CariKoduBox.Text, CariAdiBox.Text, AdresBox.Text, Ilcebox.Text,
                                                   Sehirbox.Text, UlkeBox.Text, TelefonBox.Text, FaxBox.Text,
                                                   EPostabox.Text, WebAdresbox.Text, TcKimlikNoBox.Text, PostaKoduBox.Text,
                                                   VergiDairesiBox.Text, VergiNoBox.Text,
                                                   MusteriTipiRadio.Properties.Items[MusteriValue].Description,
                                                   MusteriValue.ToString(), frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.GuncelleMesaji("Cari kartı kayıt edildi.");
                                            Close();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                cls_MesajBox.UyariMesaji("Müşteri Tipini Seçiniz.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Stok kartını silmek istediğine emin misiniz ?") == true)
                {
                    if (CK.CariKullanimdami(CariKoduBox.Text) == true)
                    {
                        cls_MesajBox.SilinemezMesaji("Cari kartı kullanımdadır.", "Cari Kartı Silinemez");
                    }
                    else
                    {
                        if (CK.CariKullanimdanKaldir(frmAnamenu.KullaniciID, CariID) == true)
                        {
                            cls_MesajBox.SilmeMesaji("Cari kartı silinmiştir.");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void StokListebtn_Click(object sender, EventArgs e)
        {
            try
            {
                frmCariListesiSec SL = new frmCariListesiSec();
                SL.ShowDialog();
                CariID = frmAnamenu.SecilenCariID;
                CariAdi = frmAnamenu.SecilenCariAdi;
                if (!string.IsNullOrEmpty(CariID) && !string.IsNullOrEmpty(CariAdi))
                {
                    var GeliyorBilgiler = cls_frmCariListesi.Gel_CariKarti_Bilgileri(CariID);
                    CariID = GeliyorBilgiler[0];
                    CariKoduBox.Text = GeliyorBilgiler[1];
                    CariAdiBox.Text = GeliyorBilgiler[2];
                    Ilcebox.Text = GeliyorBilgiler[3];
                    Sehirbox.Text = GeliyorBilgiler[4];
                    UlkeBox.Text = GeliyorBilgiler[5];
                    TelefonBox.Text = GeliyorBilgiler[6];
                    FaxBox.Text = GeliyorBilgiler[7];
                    EPostabox.Text = GeliyorBilgiler[8];
                    WebAdresbox.Text = GeliyorBilgiler[9];
                    TcKimlikNoBox.Text = GeliyorBilgiler[10];
                    PostaKoduBox.Text = GeliyorBilgiler[11];
                    VergiDairesiBox.Text = GeliyorBilgiler[12];
                    VergiNoBox.Text = GeliyorBilgiler[13];
                    MusteriTipiRadio.SelectedIndex = Convert.ToInt32(GeliyorBilgiler[14]);
                    AdresBox.Text = GeliyorBilgiler[15];
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void Kaptbtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void frmCariTanitimKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void frmCariTanitimKarti_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
                {
                    CariID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(CariID))
                    {
                        var GeliyorBilgiler = cls_frmCariListesi.Gel_CariKarti_Bilgileri(CariID);
                        CariID = GeliyorBilgiler[0];
                        CariKoduBox.Text = GeliyorBilgiler[1];
                        CariAdiBox.Text = GeliyorBilgiler[2];
                        Ilcebox.Text = GeliyorBilgiler[3];
                        Sehirbox.Text = GeliyorBilgiler[4];
                        UlkeBox.Text = GeliyorBilgiler[5];
                        TelefonBox.Text = GeliyorBilgiler[6];
                        FaxBox.Text = GeliyorBilgiler[7];
                        EPostabox.Text = GeliyorBilgiler[8];
                        WebAdresbox.Text = GeliyorBilgiler[9];
                        TcKimlikNoBox.Text = GeliyorBilgiler[10];
                        PostaKoduBox.Text = GeliyorBilgiler[11];
                        VergiDairesiBox.Text = GeliyorBilgiler[12];
                        VergiNoBox.Text = GeliyorBilgiler[13];
                        MusteriTipiRadio.SelectedIndex = Convert.ToInt32(GeliyorBilgiler[14]);
                        AdresBox.Text = GeliyorBilgiler[15];
                        Edit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmCariTanitimKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gelisim_Muhasebe.KullaniciModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.KullaniciModulu
{
    public partial class frmKullanici : DevExpress.XtraEditors.XtraForm
    {
        cls_frmKullanici K = new cls_frmKullanici();
        cls_frmKullaniciListesi KL = new cls_frmKullaniciListesi();
        public static bool Edit = false;
        public static string KullaniciID = "";
        public frmKullanici()
        {
            InitializeComponent();
        }
        private void Kaptbtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Kullanıcıyı silmek istediğinize emin misiniz ?"))
                {
                    if (K.Kullanici_KullanimdanKaldir(frmAnamenu.KullaniciID, KullaniciID))
                    {
                        cls_MesajBox.SilmeMesaji("Kullanıcı sistemden kaldırılmıştır.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdBox.Text))
            {
                dxErrorProvider1.SetError(AdBox, "Personel adını yazınız.");
            }
            else
            {
                if (string.IsNullOrEmpty(SoyadBox.Text))
                {
                    dxErrorProvider2.SetError(SoyadBox, "Personel soyadını yazınız.");
                }
                else
                {
                    if (string.IsNullOrEmpty(KulAdiBox.Text))
                    {
                        dxErrorProvider3.SetError(SoyadBox, "Kullanıcı adını yazınız.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(SifreBox.Text))
                        {
                            dxErrorProvider4.SetError(SoyadBox, "Kullanıcı şifresini yazınız.");
                        }
                        else
                        {
                            bool Yonetici = YoneticiCheck.Checked;
                            if (Edit)
                            {
                                if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                {
                                    if (K.Kullanici_Guncelle(AdBox.Text, SoyadBox.Text, EPostaBox.Text, TelefonBox.Text, KulAdiBox.Text, SifreBox.Text, AciklamaBox.Text, Yonetici, frmAnamenu.KullaniciID, KullaniciID))
                                    {
                                        cls_MesajBox.GuncelleMesaji("Kullanıcı bilgileri güncellendi.");
                                        Close();
                                    }
                                }
                            }
                            else
                            {
                                if (cls_MesajBox.Sor("Kayıt etmek istediğinize emin misiniz ?"))
                                {
                                    if (K.Kullanici_Kayit(AdBox.Text, SoyadBox.Text, EPostaBox.Text, TelefonBox.Text, KulAdiBox.Text, SifreBox.Text, AciklamaBox.Text, Yonetici, frmAnamenu.KullaniciID))
                                    {
                                        cls_MesajBox.GuncelleMesaji("Kullanıcı bilgileri kayıt edildi.");
                                        Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            AdBox.Text = "";
            SoyadBox.Text = "";
            EPostaBox.Text = "";
            TelefonBox.Text = "";
            KulAdiBox.Text = "";
            SifreBox.Text = "";
            AciklamaBox.Text = "";
            YoneticiCheck.Checked = false;
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void frmKullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void StokListebtn_Click(object sender, EventArgs e)
        {
            try
            {
                frmKullaniciListesi KLfrm = new frmKullaniciListesi();
                KLfrm.ShowDialog();
                KullaniciID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KullaniciID))
                {
                    var GeliyorBilgiler = KL.Gel_KullaniciKarti_Bilgileri(KullaniciID);
                    KullaniciID = GeliyorBilgiler[0];
                    AdBox.Text = GeliyorBilgiler[1];
                    SoyadBox.Text = GeliyorBilgiler[2];
                    EPostaBox.Text = GeliyorBilgiler[3];
                    TelefonBox.Text = GeliyorBilgiler[4];
                    KulAdiBox.Text = GeliyorBilgiler[5];
                    SifreBox.Text = GeliyorBilgiler[6];
                    AciklamaBox.Text = GeliyorBilgiler[7];
                    bool Gel = Convert.ToBoolean(GeliyorBilgiler[8]);
                    if (Gel)
                    {
                        YoneticiCheck.Checked = true;
                    }
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
                {
                    KullaniciID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(KullaniciID))
                    {
                        var GeliyorBilgiler = KL.Gel_KullaniciKarti_Bilgileri(KullaniciID);
                        KullaniciID = GeliyorBilgiler[0];
                        AdBox.Text = GeliyorBilgiler[1];
                        SoyadBox.Text = GeliyorBilgiler[2];
                        EPostaBox.Text = GeliyorBilgiler[3];
                        TelefonBox.Text = GeliyorBilgiler[4];
                        KulAdiBox.Text = GeliyorBilgiler[5];
                        SifreBox.Text = GeliyorBilgiler[6];
                        AciklamaBox.Text = GeliyorBilgiler[7];
                        bool Gel = Convert.ToBoolean(GeliyorBilgiler[8]);
                        if (Gel)
                        {
                            YoneticiCheck.Checked = true;
                        }
                        Edit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmKullanici_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
    }
}
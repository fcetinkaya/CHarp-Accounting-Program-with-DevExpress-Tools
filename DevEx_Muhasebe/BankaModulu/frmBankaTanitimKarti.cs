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
using Gelisim_Muhasebe.BankaModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.BankaModulu
{
    public partial class frmBankaTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaTanitimKarti()
        {
            InitializeComponent();
        }
        cls_frmBankaTanitimKarti B = new cls_frmBankaTanitimKarti();
        public static bool Edit = false;
        public static string BankaID, BankaKodu;
        public void Temizle()
        {
            BankaKoduBtn.EditValue = string.Empty;
            BankaKoduBtn.Text = string.Empty;
            BankaAdiBox.Text = string.Empty;
            HesapAdiBox.Text = string.Empty;
            HesapNoBox.Text = string.Empty;
            IBANBox.Text = string.Empty;
            SubeBox.Text = string.Empty;
            TelefonBox.Text = string.Empty;
            IlgiliBox.Text = string.Empty;
            BankaAciklamaBox.Text = string.Empty;
            gridControl1.DataSource = null;
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void frmBankaTanitimKarti_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(BankaID))
                {
                    string[] GelBilgiler = B.Gel_BankaKarti_Bilgileri(BankaID);
                    BankaKoduBtn.EditValue = GelBilgiler[0];
                    BankaKodu = GelBilgiler[0];
                    BankaAdiBox.Text = GelBilgiler[1];
                    BankaAciklamaBox.Text = GelBilgiler[2];
                    HesapAdiBox.Text = GelBilgiler[3];
                    HesapNoBox.Text = GelBilgiler[4];
                    IBANBox.Text = GelBilgiler[5];
                    SubeBox.Text = GelBilgiler[6];
                    TelefonBox.Text = GelBilgiler[7];
                    IlgiliBox.Text = GelBilgiler[8];
                    gridControl1.DataSource = B.Gel_BankaBakiye(BankaID);
                    Edit = true;
                }
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BankaKoduBtn.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(BankaKoduBtn, "Boş Geçilmez.");
                }
                else
                {
                    if (BankaAdiBox.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider2.SetError(BankaAdiBox, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (HesapAdiBox.Text.Trim() == String.Empty)
                        {
                            dxErrorProvider3.SetError(HesapAdiBox, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (Edit)
                            {
                                if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                {
                                    if (BankaKoduBtn.Text != BankaKodu)
                                    {
                                        if (B.Banka_KoduVarMi(BankaKoduBtn.Text.Trim())==false)
                                        {
                                            if (B.Banka_Guncelle(BankaKoduBtn.Text, BankaAdiBox.Text, BankaAciklamaBox.Text, HesapAdiBox.Text, HesapNoBox.Text, IBANBox.Text, SubeBox.Text, TelefonBox.Text, IlgiliBox.Text, frmAnamenu.KullaniciID, BankaID))
                                            {
                                                cls_MesajBox.KayitMesaji("Banka bilgileri güncellenmiştir.");
                                                Close();
                                            }
                                        }
                                        else
                                        {
                                            cls_MesajBox.UyariMesaji("Banka kodu kullanımdadır. Kodu değiştiriniz.");
                                        }
                                    }
                                    else
                                    {

                                        if (B.Banka_Guncelle(BankaKoduBtn.Text, BankaAdiBox.Text, BankaAciklamaBox.Text, HesapAdiBox.Text, HesapNoBox.Text, IBANBox.Text, SubeBox.Text, TelefonBox.Text, IlgiliBox.Text, frmAnamenu.KullaniciID, BankaID))
                                        {
                                            cls_MesajBox.KayitMesaji("Banka bilgileri güncellenmiştir.");
                                            Close();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (cls_MesajBox.Sor("Kaydetmek istediğinize emin misiniz ?"))
                                {
                                    if (B.Banka_KoduVarMi(BankaKoduBtn.Text.Trim())==false)
                                    {
                                        if (B.Banka_Kayit(BankaKoduBtn.Text, BankaAdiBox.Text, BankaAciklamaBox.Text, HesapAdiBox.Text, HesapNoBox.Text, IBANBox.Text, SubeBox.Text, TelefonBox.Text, IlgiliBox.Text, frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.KayitMesaji("Banka bilgileri başarı ile kayıt edilmiştir.");
                                            Close();
                                        }
                                    }
                                    else
                                    {
                                        cls_MesajBox.UyariMesaji("Banka kodu kullanımdadır. Kodu değiştiriniz.");
                                    }
                                }
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
        private void frmBankaTanitimKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Bankayı kullanımdan kaldırmak istediğinize emin misiniz ?"))
                {

                    if (!B.Banka_KullanimdaMi(BankaID))
                    {
                        if (B.Banka_KullanimdanKaldir(frmAnamenu.KullaniciID, BankaID))
                        {
                            cls_MesajBox.KayitMesaji("Banka kullanımdan kaldırılmıştır.");
                            Close();
                        }
                    }
                    else
                    {
                        cls_MesajBox.UyariMesaji("Banka kullanımdadır.");
                    }
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
        private void frmBankaTanitimKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void BankaKoduBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Temizle();
                frmBankaListesiSec BL = new frmBankaListesiSec();
                BL.ShowDialog();
                BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(BankaID))
                {
                    string[] GelBilgiler = B.Gel_BankaKarti_Bilgileri(BankaID);
                    BankaKoduBtn.EditValue = GelBilgiler[0];
                    BankaKodu = GelBilgiler[0];
                    BankaAdiBox.Text = GelBilgiler[1];
                    BankaAciklamaBox.Text = GelBilgiler[2];
                    HesapAdiBox.Text = GelBilgiler[3];
                    HesapNoBox.Text = GelBilgiler[4];
                    IBANBox.Text = GelBilgiler[5];
                    SubeBox.Text = GelBilgiler[6];
                    TelefonBox.Text = GelBilgiler[7];
                    IlgiliBox.Text = GelBilgiler[8];
                    gridControl1.DataSource = B.Gel_BankaBakiye(BankaID);
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
    }
}
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
using Gelisim_Muhasebe.Kasa.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Kasa
{
    public partial class frmKasaTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaTanitimKarti()
        {
            InitializeComponent();
        }
        cls_frmKasaTanitimKarti KTK = new cls_frmKasaTanitimKarti();
        public static bool Edit = false;
        public static string KasaID, KasaKodu, KasaAdi;
        public void Temizle()
        {
            KasaKoduBtn.EditValue = string.Empty;
            KasaKoduBtn.Text = string.Empty;
            KasaAdiBox.Text = string.Empty;
            KasaAciklamaBox.Text = string.Empty;
            gridControl1.DataSource = null;
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KasaKoduBtn.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(KasaKoduBtn, "Boş Geçilmez.");
                }
                else
                {
                    if (KasaAdiBox.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider2.SetError(KasaAdiBox, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (KasaAciklamaBox.Text.Trim() == String.Empty)
                        {
                            dxErrorProvider3.SetError(KasaAciklamaBox, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (Edit)
                            {
                                if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                {
                                    if (KasaKoduBtn.Text != KasaKodu)
                                    {
                                        if (KTK.Kasa_KoduVarMi(KasaKoduBtn.Text.Trim())==false)
                                        {
                                            if (KTK.Kasa_Guncelle(KasaKoduBtn.Text, KasaAdiBox.Text, KasaAciklamaBox.Text,
                                               frmAnamenu.KullaniciID, KasaID))
                                            {
                                                cls_MesajBox.KayitMesaji("Kasa bilgileri güncellenmiştir.");
                                                Close();
                                            }
                                        }
                                        else
                                        {
                                            cls_MesajBox.UyariMesaji("Kasa kodu kullanımdadır. Kodu değiştiriniz.");
                                        }
                                    }
                                    else
                                    {

                                        if (KTK.Kasa_Guncelle(KasaKoduBtn.Text, KasaAdiBox.Text, KasaAciklamaBox.Text,
                                            frmAnamenu.KullaniciID, KasaID))
                                        {
                                            cls_MesajBox.KayitMesaji("Kasa bilgileri güncellenmiştir.");
                                            Close();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (cls_MesajBox.Sor("Kaydetmek istediğinize emin misiniz ?"))
                                {
                                    if (KTK.Kasa_KoduVarMi(KasaKoduBtn.Text.Trim())==false)
                                    {
                                        if (KTK.Kasa_Kayit(KasaKoduBtn.Text, KasaAdiBox.Text, KasaAciklamaBox.Text,
                                            frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.KayitMesaji("Kasa bilgileri başarı ile kayıt edilmiştir.");
                                            Close();
                                        }
                                    }
                                }
                                else
                                {
                                    cls_MesajBox.UyariMesaji("Kasa kodu kullanımdadır. Kodu değiştiriniz.");
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
        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Kasayı kullanımdan kaldırmak istediğinize emin misiniz ?"))
                {

                    if (!KTK.Kasa_KullanimdaMi(KasaID))
                    {
                        if (KTK.Kasa_KullanimdanKaldir(frmAnamenu.KullaniciID, KasaID))
                        {
                            cls_MesajBox.KayitMesaji("Kasa kullanımdan kaldırılmıştır.");
                            Close();
                        }
                    }
                    else
                    {
                        cls_MesajBox.UyariMesaji("Kasa kullanımdadır.");
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
        private void frmKasaTanitimKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void frmKasaTanitimKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void frmKasaTanitimKarti_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                try
                {
                    KasaID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(KasaID))
                    {
                        string[] GelBilgiler = KTK.Gel_KasaKarti_Bilgileri(KasaID);
                        KasaID = GelBilgiler[0];
                        KasaKoduBtn.EditValue = GelBilgiler[1];
                        KasaKodu = GelBilgiler[1];
                        KasaAdiBox.Text = GelBilgiler[2];
                        KasaAdi = GelBilgiler[2];
                        KasaAciklamaBox.Text = GelBilgiler[3];
                        gridControl1.DataSource = KTK.Gel_KasaBakiye(KasaID);
                        Edit = true;
                    }
                }
                catch (Exception ex)
                {
                    cls_MesajBox.HataMesaji(ex);
                }
            }
        }
        private void KasaKoduBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Temizle();
                frmKasaListesi KL = new frmKasaListesi();
                KL.ShowDialog();
                KasaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KasaID))
                {
                    string[] GelBilgiler = KTK.Gel_KasaKarti_Bilgileri(KasaID);
                    KasaID = GelBilgiler[0];
                    KasaKoduBtn.EditValue = GelBilgiler[1];
                    KasaKodu = GelBilgiler[1];
                    KasaAdiBox.Text = GelBilgiler[2];
                    KasaAdi = GelBilgiler[2];
                    KasaAciklamaBox.Text = GelBilgiler[3];
                    gridControl1.DataSource = KTK.Gel_KasaBakiye(KasaID);
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
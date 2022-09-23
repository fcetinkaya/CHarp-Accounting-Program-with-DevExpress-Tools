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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }
        cls_frmBankaAcilisKarti KA = new cls_frmBankaAcilisKarti();
        public static string GelenAcilisID;
        public static bool Edit = false;
        public void Temizle(){
            txtBankaKodu.Text = "";
            txtBankaAdi.Text = "";
            txtTarih.Text = "";
            txtTarih.EditValue = DateTime.Now;
            txtTutar.Text = "";
            BakiyeRadio.SelectedIndex = -1;
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            if (txtBankaKodu.Text.Trim() == String.Empty)
            {
                dxErrorProvider1.SetError(txtBankaKodu, "Boş Geçilmez.");
            }
            else
            {

                if (txtTarih.Text.Trim() == String.Empty)
                {
                    dxErrorProvider3.SetError(txtTarih, "Tarih Seçiniz");
                }
                else
                {
                    if (txtTutar.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider4.SetError(txtTutar, "Boş Geçilmez");
                    }
                    else
                    {
                        #region Kodlar

                        string BankaID = KA.BankaID_Donder(txtBankaKodu.Text);
                        string Kod = "G";
                        if (BakiyeRadio.SelectedIndex != -1)
                        {
                            if (BakiyeRadio.SelectedIndex == 1)
                            {
                                Kod = "C";
                            }
                            try
                            {
                                if (Edit)
                                {
                                    if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                    {
                                        if (KA.BankaHareketGuncelle(txtTarih.Text, Kod,
                                            Convert.ToDouble(txtTutar.Text), BankaID, frmAnamenu.KullaniciID, GelenAcilisID))
                                        {
                                            cls_MesajBox.GuncelleMesaji("Bilgiler güncellendi.");
                                            Temizle();
                                            Close();
                                        }
                                    }
                                }
                                else
                                {
                                    if (cls_MesajBox.Sor("Kaydetmek istediğinize emin misiniz ?"))
                                    {
                                        if (KA.BankaHareketKayit(txtTarih.Text, Kod, Convert.ToDouble(txtTutar.Text),
                                            BankaID, frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.GuncelleMesaji("Bilgiler kayıt edildi.");
                                            Temizle();
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
                        else
                        {
                            cls_MesajBox.UyariMesaji("Giriş Tipini Seçiniz.");
                        }

                        #endregion
                    }
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    KA.BankaHareketSil(GelenAcilisID);
                    cls_MesajBox.GuncelleMesaji("Bilgiler silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void frmBankaAcilisKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankaListesiSec CL = new frmBankaListesiSec();
                CL.ShowDialog();
                string _BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(_BankaID))
                {
                    string[] gelenCari = KA.BankaKarti_Bilgileri(_BankaID);
                    txtBankaKodu.Text = gelenCari[0];
                    txtBankaAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            try
            {
                GelenAcilisID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(GelenAcilisID))
                {
                    Edit = true;
                    string[] gelenBilgi = KA.BankaHareket_Bilgileri(GelenAcilisID);
                    string[] gelenCari = KA.BankaKarti_Bilgileri(GelenAcilisID);
                    txtBankaKodu.Text = gelenCari[0];
                    txtBankaAdi.Text = gelenCari[1];

                    // Kart Bilgileri
                    txtTarih.Text = gelenBilgi[0];
                    if (gelenBilgi[1] != "C")
                    {
                        BakiyeRadio.SelectedIndex = 0;
                    }
                    else
                    {
                        BakiyeRadio.SelectedIndex = 1;
                    }
                    txtTutar.Text = gelenBilgi[2];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmBankaAcilisKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
    }
}
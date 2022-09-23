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
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.BankaModulu
{
    public partial class frmGidenHavale : DevExpress.XtraEditors.XtraForm
    {
        public frmGidenHavale()
        {
            InitializeComponent();
        }
        cls_frmGidenHavale B = new cls_frmGidenHavale();
        public static string GelenAcilisID;
        public static bool Edit = false;
        public void Temizle()
        {
            txtBelgeNo.Text = "";
            TxtMakbuzNo.Text = "";
            txtBankaKodu.Text = "";
            txtBankaAdi.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtTarih.Text = "";
            txtTarih.EditValue = DateTime.Now;
            txtTutar.Text = "";
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void frmGidenHavale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void frmGidenHavale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void btnBankaSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankaListesiSec CL = new frmBankaListesiSec();
                CL.ShowDialog();
                string _BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(_BankaID))
                {
                    string[] gelenCari = B.BankaKarti_Bilgileri(_BankaID);
                    txtBankaKodu.Text = gelenCari[0];
                    txtBankaAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void CariSecBtn_Click(object sender, EventArgs e)
        {
            try
            {
                frmCariListesi CL = new frmCariListesi();
                CL.ShowDialog();
                string CariId = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(CariId))
                {
                    string[] gelenCari = B.CariKarti_Bilgileri(CariId);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmGidenHavale_Load(object sender, EventArgs e)
        {
            try
            {
                GelenAcilisID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(GelenAcilisID))
                {
                    Edit = true;
                    string[] gelenBilgi = B.BankaHareket_Bilgileri(GelenAcilisID);
                    string[] gelenBanka = B.BankaKarti_Bilgileri(gelenBilgi[7]);
                    txtBankaKodu.Text = gelenBanka[0];
                    txtBankaAdi.Text = gelenBanka[1];

                    string[] gelenCari = B.CariKarti_Bilgileri(gelenBilgi[6]);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariAdi.Text = gelenCari[1];
                    // Kart Bilgileri
                    txtBelgeNo.Text = gelenBilgi[0];
                    TxtMakbuzNo.Text = gelenBilgi[1];
                    txtTarih.Text = gelenBilgi[2];
                    txtTutar.Text = gelenBilgi[4];
                    txtAciklama.Text = gelenBilgi[5];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text.Trim() == String.Empty)
            {
                dxErrorProvider1.SetError(txtBankaKodu, "Boş Geçilmez.");
            }
            else
            {
                if (txtBankaKodu.Text.Trim() == String.Empty)
                {
                    dxErrorProvider2.SetError(txtBankaAdi, "Boş Geçilmez.");
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

                            string BankaID = B.BankaID_Donder(txtBankaKodu.Text);
                            string CariID = B.CariID_Donder(txtCariKodu.Text);
                            try
                            {
                                if (Edit)
                                {
                                    if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                    {
                                        if (B.BankaHareketGuncelle(txtBelgeNo.Text, TxtMakbuzNo.Text, txtTarih.Text,
                                            Convert.ToDouble(txtTutar.Text), txtAciklama.Text, CariID, BankaID, frmAnamenu.KullaniciID, GelenAcilisID))
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
                                        if (B.BankaHareketKayit(txtBelgeNo.Text, TxtMakbuzNo.Text, txtTarih.Text,
                                            Convert.ToDouble(txtTutar.Text), txtAciklama.Text, CariID, BankaID, frmAnamenu.KullaniciID))
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
                            #endregion
                        }
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
                    B.BankaHareketSil(GelenAcilisID);
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
    }
}
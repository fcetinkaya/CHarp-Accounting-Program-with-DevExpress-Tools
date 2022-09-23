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
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }
        cls_frmKasaAcilisKarti KA = new cls_frmKasaAcilisKarti();
        public static string GelenAcilisID;
        public static bool Edit = false;
        public void Temizle()
        {
            txtKasaKodu.Text = "";
            txtKasaAdi.Text = "";
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

            if (txtKasaKodu.Text.Trim() == String.Empty)
            {
                dxErrorProvider1.SetError(txtKasaKodu, "Boş Geçilmez.");
            }
            else
            {
                if (txtTutar.Text.Trim() == String.Empty)
                {
                    dxErrorProvider2.SetError(txtKasaAdi, "Boş Geçilmez.");
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

                            string KasaID = KA.KasaID_Donder(txtKasaKodu.Text);
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
                                            if (KA.KasaHareketGuncelle(txtTarih.Text, Kod,
                                                Convert.ToDouble(txtTutar.Text), KasaID, frmAnamenu.KullaniciID))
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
                                            if (KA.KasaHareketKayit(txtTarih.Text, Kod, Convert.ToDouble(txtTutar.Text),
                                                KasaID, frmAnamenu.KullaniciID))
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
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    KA.KasaHareketSil(GelenAcilisID);
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
        private void frmKasaAcilisKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmKasaListesi CL = new frmKasaListesi();
                CL.ShowDialog();
                string _KasaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(_KasaID))
                {
                    string[] gelenCari = KA.KasaKarti_Bilgileri(_KasaID);
                    txtKasaKodu.Text = gelenCari[0];
                    txtKasaAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmKasaAcilisKarti_Load(object sender, EventArgs e){
            try
            {
                GelenAcilisID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(GelenAcilisID))
                {
                    Edit = true;
                    string[] gelenBilgi = KA.KasaHareket_Bilgileri(GelenAcilisID);
                    string[] gelenKasa = KA.KasaKarti_Bilgileri(gelenBilgi[5]);
                    txtKasaKodu.Text = gelenKasa[0];
                    txtKasaAdi.Text = gelenKasa[1];
                    
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
        private void frmKasaAcilisKarti_KeyDown(object sender, KeyEventArgs e)
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
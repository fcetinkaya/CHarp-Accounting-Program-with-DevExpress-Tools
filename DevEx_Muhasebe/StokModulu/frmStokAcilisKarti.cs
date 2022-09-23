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
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu
{
    public partial class frmStokAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmStokAcilisKarti()
        {
            InitializeComponent();
        }
        public static string GelenAcilisID;
        public static bool Edit = false;
        cls_StokAcilisKarti SA = new cls_StokAcilisKarti();
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            if (txtStokKodu.Text.Trim() == String.Empty)
            {
                dxErrorProvider1.SetError(txtStokKodu, "Boş Geçilmez.");
            }
            else
            {
                if (txtTutar.Text.Trim() == String.Empty)
                {
                    dxErrorProvider2.SetError(txtTutar, "Boş Geçilmez.");
                }
                else
                {
                    if (txtTarih.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider3.SetError(txtTarih, "Tarih Seçiniz");
                    }
                    else
                    {
                        if (txtMiktar.Text.Trim() == String.Empty)
                        {
                            dxErrorProvider4.SetError(txtMiktar, "Boş Geçilmez");
                        }
                        else
                        {
                            #region Kodlar

                            string StokID = SA.Gel_StokID(txtStokKodu.Text);
                            string GCKOD = "C";

                            if (BakiyeRadio.SelectedIndex != -1)
                            {
                                if (BakiyeRadio.SelectedIndex == 0)
                                {
                                    GCKOD = "G";
                                }
                                try
                                {
                                    if (Edit == true)
                                    {
                                        GelenAcilisID = frmAnamenu.CorbaSecilenID;
                                        if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                        {
                                            if (SA.stokHareketGuncelle(GCKOD, Convert.ToDouble(txtMiktar.Text),
                                                Convert.ToDouble(txtTutar.Text), txtAciklama.Text, txtTarih.Text, StokID,
                                                frmAnamenu.KullaniciID, GelenAcilisID))
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
                                            if (SA.stokHareketKayit(GCKOD, Convert.ToDouble(txtMiktar.Text), Convert.ToDouble(txtTutar.Text), txtAciklama.Text, txtTarih.Text, StokID, frmAnamenu.KullaniciID))
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
                                cls_MesajBox.UyariMesaji("Bakiye Tipini Seçiniz.");
                            }
                        }
                    }
                            #endregion
                }
            }
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtTarih.Text = "";
            txtTarih.EditValue = DateTime.Now;
            txtTutar.Text = "";
            txtTutar.Text = "";
            BakiyeRadio.SelectedIndex = -1;
            txtAciklama.Text = "";
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    SA.stokHareketSil(GelenAcilisID);
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
        private void frmStokAcilisKarti_Load(object sender, EventArgs e)
        {
            try
            {
                GelenAcilisID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(GelenAcilisID))
                {
                    Edit = true;
                    string[] gelenBilgi = SA.Gel_StokHareketleri_Bilgileri(GelenAcilisID);
                    string[] gelenStok = SA.Gel_StokKarti_Bilgileri(gelenBilgi[5]);
                    txtStokKodu.Text = gelenStok[0];
                    txtStokAdi.Text = gelenStok[1];
                    if (gelenBilgi[0] == "G")
                    {
                        BakiyeRadio.SelectedIndex = 0;
                    }
                    else
                    {
                        BakiyeRadio.SelectedIndex = 1;
                    }
                    txtMiktar.Text = gelenBilgi[1];
                    txtTutar.Text = gelenBilgi[2];
                    txtAciklama.Text = gelenBilgi[3];
                    txtTarih.Text = gelenBilgi[4];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmStokListesi CL = new frmStokListesi();
                CL.ShowDialog();
                string StokID = frmAnamenu.SecilenKodID;
                if (!string.IsNullOrEmpty(StokID))
                {
                    string[] gelenCari = SA.Gel_StokKarti_Bilgileri(StokID);
                    txtStokKodu.Text = gelenCari[0];
                    txtStokAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmStokAcilisKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void frmStokAcilisKarti_KeyDown(object sender, KeyEventArgs e)
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
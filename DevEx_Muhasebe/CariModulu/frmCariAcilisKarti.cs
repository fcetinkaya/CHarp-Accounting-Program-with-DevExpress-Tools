using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.CariModulu
{
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }
        cls_frmCariAcilisKarti CA = new cls_frmCariAcilisKarti();
        public static string GelenAcilisID;
        public static bool Edit = false;
        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            try
            {
                GelenAcilisID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(GelenAcilisID))
                {
                    Edit = true;
                    string[] gelenBilgi = CA.CariHareket_Bilgileri(GelenAcilisID);
                    string[] gelenCari = CA.CariKarti_Bilgileri(gelenBilgi[0]);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariIsim.Text = gelenCari[1];
                    txtTarih.Text = gelenBilgi[1];
                    if (gelenBilgi[2] != "0.00")
                    {
                        txtTutar.Text = gelenBilgi[2];
                        BakiyeRadio.SelectedIndex = 1;
                    }
                    else
                    {
                        txtTutar.Text = gelenBilgi[3];
                        BakiyeRadio.SelectedIndex = 0;
                    }
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
        public void Temizle()
        {
            txtCariKodu.Text = "";
            txtCariIsim.Text = "";
            txtTarih.Text = "";
            txtTarih.EditValue = DateTime.Now;
            txtTutar.Text = "";
            BakiyeRadio.SelectedIndex = -1;
            txtAciklama.Text = "";
            frmAnamenu.CorbaSecilenID = string.Empty;
            Edit = false;
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            if (txtCariKodu.Text.Trim() == String.Empty)
            {
                dxErrorProvider1.SetError(txtCariKodu, "Boş Geçilmez.");
            }
            else
            {
                if (txtTutar.Text.Trim() == String.Empty)
                {
                    dxErrorProvider2.SetError(txtCariIsim, "Boş Geçilmez.");
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
                            string CariId = CA.CariID_Donder(txtCariKodu.Text);
                            double borc = 0;
                            double alacak = 0;
                            if (BakiyeRadio.SelectedIndex != -1)
                            {
                                if (BakiyeRadio.SelectedIndex == 0)
                                {
                                    alacak = Convert.ToDouble(txtTutar.Text);
                                }
                                else
                                {
                                    borc = Convert.ToDouble(txtTutar.Text);
                                }
                                try
                                {
                                    if (Edit == true)
                                    {
                                        if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                        {
                                            if (CA.cariHareketGuncelle(txtTarih.Text, borc, alacak, txtAciklama.Text, CariId,
                                                   frmAnamenu.KullaniciID))
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
                                            if (CA.CariHareketKayit(txtTarih.Text, borc, alacak, txtAciklama.Text, CariId,
                                                frmAnamenu.KullaniciID))
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
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    CA.cariHareketSil(GelenAcilisID);
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
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmCariListesiSec CL = new frmCariListesiSec();
                CL.ShowDialog();
                string CariId = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(CariId))
                {
                    string[] gelenCari = CA.CariKarti_Bilgileri(CariId);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariIsim.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmCariAcilisKarti_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Temizle();
        }
        private void frmCariAcilisKarti_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
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
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.Kasa.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Kasa
{
    public partial class frmKasaTediye : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaTediye()
        {
            InitializeComponent();
        }
        public static string SecilenKasaID;
        public static string SecilenCariID;
        public static string KasaHareketID;
        public static bool Edit = false;
        cls_frmKasaTediye KD = new cls_frmKasaTediye();
        private void frmKasaTediye_Load(object sender, EventArgs e)
        {
            try
            {
                txtTarih.Text = DateTime.Now.ToShortDateString();
                KasaHareketID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KasaHareketID))
                {
                    Edit = true;
                    string[] Gel = KD.KasaHareket_Bilgileri(KasaHareketID);
                    txtBelgeNo.Text = Gel[0];
                    TxtMakbuzNo.Text = Gel[1];
                    txtTarih.Text = Gel[2];
                    txtTutar.Text = Gel[3];
                    txtAciklama.Text = Gel[4];
                    string[] gelenCari = KD.CariKarti_Bilgileri(Gel[5]);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariAdi.Text = gelenCari[1];
                    SecilenCariID = Gel[5];

                    string[] gelenKasa = KD.KasaKarti_Bilgileri(Gel[6]);
                    txtKasaKodu.Text = gelenKasa[0];
                    txtKasaAdi.Text = gelenKasa[1];
                    SecilenKasaID = Gel[6];
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
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek istediğinize emin misiniz ?"))
                {
                    KD.KasaHareketSil(KasaHareketID);
                    cls_MesajBox.GuncelleMesaji("Bilgiler silindi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKasaKodu.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(txtKasaKodu, "Boş Geçilmez.");
                }
                else
                {
                    if (txtCariKodu.Text.Trim() == String.Empty)
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
                                if (Edit)
                                {
                                    if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                    {
                                        if (KD.KasaHareketGuncelle(txtBelgeNo.Text, TxtMakbuzNo.Text, txtTarih.Text,
                                            Convert.ToDouble(txtTutar.Text), txtAciklama.Text, SecilenKasaID, SecilenCariID, frmAnamenu.KullaniciID, KasaHareketID))
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
                                        if (KD.KasaHareketKayit(txtBelgeNo.Text, TxtMakbuzNo.Text, txtTarih.Text, "C",
                                            Convert.ToDouble(txtTutar.Text), txtAciklama.Text, "Tediye", SecilenKasaID, SecilenCariID, frmAnamenu.KullaniciID))
                                        {
                                            cls_MesajBox.GuncelleMesaji("Bilgiler kayıt edildi.");
                                            Temizle();
                                            Close();
                                        }
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
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            txtBelgeNo.Text = "";
            TxtMakbuzNo.Text = "";
            txtKasaKodu.Text = "";
            txtKasaAdi.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "";
            txtAciklama.Text = "";
            SecilenKasaID = "";
            SecilenCariID = "";
            frmAnamenu.SecilenCariID = "";
            frmAnamenu.CorbaSecilenID = "";

        }
        private void frmKasaTediye_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmKasaListesi KL = new frmKasaListesi();
                KL.ShowDialog();
                string KasaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KasaID))
                {
                    string[] gelenCari = KD.KasaKarti_Bilgileri(KasaID);
                    txtKasaKodu.Text = gelenCari[0];
                    txtKasaAdi.Text = gelenCari[1];
                    SecilenKasaID = gelenCari[2];
                    frmAnamenu.SecilenCariID = "";
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
                frmCariListesi CL = new frmCariListesi();
                CL.ShowDialog();
                SecilenCariID = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(SecilenCariID))
                {
                    string[] gelenCari = KD.CariKarti_Bilgileri(SecilenCariID);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariAdi.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmKasaTediye_KeyDown(object sender, KeyEventArgs e)
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
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
    public partial class frmSifreDegistir : DevExpress.XtraEditors.XtraForm
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }
        cls_frmSifreDegistir SD = new cls_frmSifreDegistir();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EskiParaloTxt.Text))
                {
                    dxErrorProvider1.SetError(EskiParaloTxt, "Boş Geçilmez.");
                }
                else
                {
                    if (string.IsNullOrEmpty(YeniParolaTxt.Text))
                    {
                        dxErrorProvider2.SetError(YeniParolaTxt, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(YeniTekrarParola.Text))
                        {
                            dxErrorProvider3.SetError(YeniTekrarParola, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (YeniParolaTxt.Text == YeniTekrarParola.Text)
                            {
                                if (SD.Kullanici_Sifredogrula(frmAnamenu.KullaniciID.ToString(), EskiParaloTxt.Text))
                                {
                                    if (SD.Kullanici_SifreGuncelle(frmAnamenu.KullaniciID.ToString(),
                                        YeniTekrarParola.Text))
                                    {
                                        cls_MesajBox.KayitMesaji("Şifre başara ile güncellendi.");
                                        Close();
                                    }
                                }
                                else
                                {
                                    cls_MesajBox.UyariMesaji("Eski parola uyuşmuyor.");
                                }
                            }
                            else
                            {
                                cls_MesajBox.UyariMesaji("Yeni parola uyuşmuyor.");
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
        private void Kaptbtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void frmSifreDegistir_KeyDown(object sender, KeyEventArgs e)
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
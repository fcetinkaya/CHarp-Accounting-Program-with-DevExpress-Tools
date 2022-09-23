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
using Gelisim_Muhasebe.BankaModulu;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.Kasa;
using Gelisim_Muhasebe.StokModulu;

namespace Gelisim_Muhasebe
{
    public partial class frmMasaustu : DevExpress.XtraEditors.XtraForm
    {
        public frmMasaustu()
        {
            InitializeComponent();
        }

        private void frmMasaustu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yetkiler..");
        }

        private void SatisFtBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSatisFaturasi sft = new frmSatisFaturasi();
            sft.MdiParent = frmAnamenu.ActiveForm;
            sft.Show();
        }

        private void CariListesiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariListesi CL = new frmCariListesi();
            CL.ShowDialog();
        }

        private void CariTanitimKartiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariTanitimKarti CK = new frmCariTanitimKarti();
            CK.MdiParent = frmAnamenu.ActiveForm;
            CK.Show();
        }

        private void CariHareketleriItemBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariHareketleri ch = new frmCariHareketleri();
            ch.MdiParent = frmAnamenu.ActiveForm;
            ch.Show();
        }

        private void StokHareketleriBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokHareketKayitlari sh = new frmStokHareketKayitlari();
            sh.MdiParent = frmAnamenu.ActiveForm;
            sh.Show();
        }

        private void StokListesiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokListesi sl = new frmStokListesi();
            sl.MdiParent = frmAnamenu.ActiveForm;
            sl.Show();
        }

        private void TopluStokAcmaBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTopluStokAcma tsa = new frmTopluStokAcma();
            tsa.MdiParent = frmAnamenu.ActiveForm;
            tsa.Show();
        }
        private void StokTanitimBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokTanitimKarti frmStok = new frmStokTanitimKarti();
            frmStok.ShowDialog();
        }

        private void TopluFiyatGuncellmeBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTopluStokGuncelleme tsa = new frmTopluStokGuncelleme();
            tsa.MdiParent = frmAnamenu.ActiveForm;
            tsa.Show();
        }

        private void KasaTanitimKartiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaTanitimKarti KTK = new frmKasaTanitimKarti();
            KTK.Show();
        }

        private void KasaListesiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaListesi KL = new frmKasaListesi();
            KL.MdiParent = frmAnamenu.ActiveForm;
            KL.Show();
        }

        private void KasaHareketKayitlariBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaHareketleri KH = new frmKasaHareketleri();
            KH.MdiParent = frmAnamenu.ActiveForm;
            KH.Show();
        }

        private void TahsilatBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaTahsilat KT = new frmKasaTahsilat();
            KT.ShowDialog();
        }

        private void TediyeGirisiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaTediye KD = new frmKasaTediye();
            KD.ShowDialog();
        }

        private void Yan_BankaTanitimKartiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaTanitimKarti KTK = new frmKasaTanitimKarti();
            KTK.Show();
        }

        private void Yan_BankaListesiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBankaListesi BL = new frmBankaListesi();
            BL.MdiParent = frmAnamenu.ActiveForm;
            BL.Show();
        }

        private void Yan_BankaIslemiBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBankaIslemi BI = new frmBankaIslemi();
            BI.ShowDialog();
        }

        private void Yan_GelenHaveleBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGelenHavale GH = new frmGelenHavale();
            GH.ShowDialog();
        }

        private void Yan_GonderilenHavaleBtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGidenHavale GH = new frmGidenHavale();
            GH.ShowDialog();
        }
    }
}
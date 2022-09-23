using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using Gelisim_Muhasebe.Cariler.Class;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.StokModulu.Raporlar;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Cariler
{
    public partial class frmCariListesiSec : DevExpress.XtraEditors.XtraForm
    {
        private cls_frmCariListesi CL = new cls_frmCariListesi();

        public frmCariListesiSec()
        {
            InitializeComponent();
        }

        private void frmCariListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BeklemeEkraniGoster();
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void CariArama()
        {
            string AraKelime = "";
            if (comboMusteriTipi.Text == "Seçiniz")
            {
                AraKelime = "and CariKodu like '%" + CariKoduBox.Text + "%' and CariIsim like '%" + CariAdiBox.Text +
                            "%' and Sehir like '%" + SehirBox.Text + "%' and Ilce like '%" + IlceBox.Text +
                            "%' and Tc like '%" + TcKimlikBox.Text + "%'";
            }
            else
            {
                AraKelime = "and CariKodu like '%" + CariKoduBox.Text + "%' and CariIsim like '%" + CariAdiBox.Text +
                            "%' and Sehir like '%" + SehirBox.Text + "%' and Ilce like '%" + IlceBox.Text +
                            "%' and Tc like '%" + TcKimlikBox.Text + "%' and Tipi='" + comboMusteriTipi.Text + "'";
            }
            DataTable dt = CL.Gel_CariKarti_Bilgileri_Arama(AraKelime);
            gridControl1.DataSource = dt;
        }
        public void BeklemeEkraniGoster()
        {
            SplashScreenManager.ShowForm(typeof(frmWait));
            CariArama();
            SplashScreenManager.CloseForm();
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            CariKoduBox.Text = "";
            CariAdiBox.Text = "";
            SehirBox.Text = "";
            IlceBox.Text = "";
            TcKimlikBox.Text = "";
            comboMusteriTipi.Text = "Seçiniz";
            DataTable dt = CL.Gel_CariListe_Bilgileri();
            gridControl1.DataSource = dt;

        }
        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CL.Gel_CariListe_Bilgileri();
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.SecilenCariAdi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariKodu").ToString();
            frmAnamenu.SecilenCariID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            Close();
        }
    }
}
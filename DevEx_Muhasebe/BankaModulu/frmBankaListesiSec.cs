using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Gelisim_Muhasebe.BankaModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.BankaModulu
{
    public partial class frmBankaListesiSec : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaListesiSec()
        {
            InitializeComponent();
        }

        private cls_frmBankaListesi BL = new cls_frmBankaListesi();

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BL.Gel_BankaListesi();
        }

        public void Temizle()
        {
            BankaAdiBox.Text = string.Empty;
            HesapAdiBox.Text = string.Empty;
            HesapNoBox.Text = string.Empty;
            BankaAciklamaBox.Text = string.Empty;
            frmAnamenu.CorbaSecilenID = string.Empty;
            gridControl1.DataSource = BL.Gel_BankaListesi();
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            string AraKelime = " BankaAdi like '%" + BankaAdiBox.Text +
                               "%' and BankaAciklama Like '%" + BankaAciklamaBox.Text + "%' and '% HesapAdi like '%" +
                               HesapAdiBox.Text + "%' and HesapNo like '%" + HesapNoBox.Text + "%'";
            DataTable dt = BL.Gel_BankaListesi_Arama(AraKelime);
            gridControl1.DataSource = dt;
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankaID").ToString();
            Close();
        }
    }
}
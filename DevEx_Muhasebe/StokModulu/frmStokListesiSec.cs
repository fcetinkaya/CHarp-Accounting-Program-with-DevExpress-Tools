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
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu
{
    public partial class frmStokListesiSec : DevExpress.XtraEditors.XtraForm
    {
        cls_frmStokListesi StokListesi = new cls_frmStokListesi();
        public frmStokListesiSec()
        {
            InitializeComponent();
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string AraKelime = "and Muhasebe_TBL_Stoklar.StokKodu like '%" + StokKoduBox.Text + "%' and Muhasebe_TBL_Stoklar.StokAdi like '%" + StokAdiBox.Text + "%' and Muhasebe_TBL_Stoklar.Kod1 like '%" + Kod1Box.Text + "%' and Muhasebe_TBL_Stoklar.Kod2 like '%" + Kod2Box.Text + "%' and Muhasebe_TBL_Stoklar.Kod3 like '%" + Kod3Box.Text + "%' and Muhasebe_TBL_Stoklar.Kod4 like '%" + Kod4Box.Text + "%' and Muhasebe_TBL_Stoklar.Kod5 like '%" + Kod5Box.Text + "%'";
                DataTable dt = StokListesi.Gel_StokListe_Bilgileri_Arama(AraKelime);
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            StokAdiBox.Text = string.Empty;
            StokKoduBox.Text = string.Empty;
            Kod1Box.Text = string.Empty;
            Kod2Box.Text = string.Empty;
            Kod3Box.Text = string.Empty;
            Kod4Box.Text = string.Empty;
            Kod5Box.Text = string.Empty;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
            DataTable dt = StokListesi.Gel_StokListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = StokListesi.Gel_StokListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.Columns.Count != 0)
            {
                frmAnamenu.SecilenKodAdi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokKodu").ToString();
                frmAnamenu.SecilenKodID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
               Close();
            }
        }
    }
}
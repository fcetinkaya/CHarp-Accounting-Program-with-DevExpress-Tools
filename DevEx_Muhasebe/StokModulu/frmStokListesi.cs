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
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        cls_frmStokListesi StokListesi = new cls_frmStokListesi();
        public frmStokListesi()
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
      
        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokTanitimKarti STK = new frmStokTanitimKarti();
            STK.ShowDialog();
            DataTable dt = StokListesi.Gel_StokListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
            frmStokTanitimKarti STK = new frmStokTanitimKarti();
            STK.ShowDialog();
            DataTable dt = StokListesi.Gel_StokListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
            frmStokHareketKayitlari CTK = new frmStokHareketKayitlari();
            CTK.MdiParent = frmAnamenu.ActiveForm;
            CTK.Show();
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.Columns.Count != 0)
            {
                frmAnamenu.SecilenKodAdi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokKodu").ToString();
                frmAnamenu.SecilenKodID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
                this.Close();
            }
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "StokListesi.xls";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToXls(sfd.FileName);
            }
        }
        private void excel2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xlsx (*.xlsx)|*.xlsx";
            sfd.FileName = "StokListesi.xlsx";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToXlsx(sfd.FileName);
            }
        }
        private void pdfAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".pdf (*.pdf)|*.pdf";
            sfd.FileName = "StokListesi.pdf";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreatePDF(gridControl1, sfd);
            }
        }
        private void csvAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".csv (*.csv)|*.csv";
            sfd.FileName = "StokListesi.csv";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                gridView1.ExportToCsv(sfd.FileName);
            }
        }
        public void CreatePDF(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToPdf(S.FileName);
        }
        public void CreateHTML(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToHtml(S.FileName);
        }
        public void CreateImage(GridControl gridControl, SaveFileDialog S)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = gridControl;
            link.Landscape = true;
            link.CreateDocument();
            link.PrintingSystemBase.ExportToImage(S.FileName);
        }
        private void htmlAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".html (*.html)|*.html";
            sfd.FileName = "StokListesi.html";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateHTML(gridControl1, sfd);
            }
        }
        private void resimOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".jpg (*.jpg)|*.jpg";
            sfd.FileName = "StokListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Hazırlanacak");
        }
    }
}
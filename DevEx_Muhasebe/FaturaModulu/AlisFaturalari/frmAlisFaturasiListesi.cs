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
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.FaturaModulu.Class;
using Gelisim_Muhasebe.StokModulu.Raporlar;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.FaturaModulu.AlisFaturalari
{
    public partial class frmAlisFaturasiListesi : DevExpress.XtraEditors.XtraForm
    {
        cls_AlisFaturasi SF = new cls_AlisFaturasi();
        public frmAlisFaturasiListesi()
        {
            InitializeComponent();
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Kelime = " and Muhasebe_TBL_Faturalar.FaturaNo like '%" + txtFtNo.Text + "%'  and Muhasebe_TBL_Cariler.CariIsim like '%" + txtCariIsim.Text + "%'  and Muhasebe_TBL_Cariler.CariKodu like '%" + txtCariKodu.Text + "%'";
                DataTable dtA = SF.Gel_FaturaListe_Bilgileri_Arama(Kelime);
                gridControl1.DataSource = dtA;
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            txtFtNo.Text = string.Empty;
            txtCariIsim.Text = string.Empty;
            txtCariKodu.Text = string.Empty;
            DataTable dt = SF.Gel_FaturaListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void frmSatisFaturasiListesi_Load(object sender, EventArgs e)
        {
            DataTable dtG = SF.Gel_FaturaListe_Bilgileri();
            gridControl1.DataSource = dtG;
        }
        private void yeniKasaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlisFaturasi Sf = new frmAlisFaturasi();
            Sf.MdiParent = frmAnamenu.ActiveForm;
            Sf.Show();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.SecilenFtID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FaturaID").ToString();
            frmAlisFaturasi Sf = new frmAlisFaturasi();
            Sf.MdiParent = frmAnamenu.ActiveForm;
            Sf.Show();
        }
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.SecilenFtID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FaturaID").ToString();
            Close();
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Hazırlanacak");
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "AlıışFatura_Listesi.xls";
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
            sfd.FileName = "AlıışFatura_Listesi.xlsx";
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
            sfd.FileName = "AlıışFatura_Listesi.pdf";
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
            sfd.FileName = "AlıışFatura_Listesi.csv";
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
            sfd.FileName = "AlıışFatura_Listesi.html";
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
            sfd.FileName = "AlıışFatura_Listesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void cariFaturaListesiToolStripMenuItem_Click(object sender, EventArgs e){
            try
            {
                string Kodu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariKodu").ToString();
                string Kelime = " and Muhasebe_TBL_Cariler.CariKodu='" + Kodu + "'";
                DataTable dtA = SF.Gel_FaturaListe_Bilgileri_Arama(Kelime);
                gridControl1.DataSource = dtA;
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void cariHareketRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariHareketRaporu c = new frmCariHareketRaporu();
            c.MdiParent = frmAnamenu.ActiveForm;
            c.Show();
        }
        private void ToolTipCariStokHareketRaporu_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariStokHareketRaporu c = new frmCariStokHareketRaporu();
            c.MdiParent = frmAnamenu.ActiveForm;
            c.Show();
        }
        private void cariHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariHareketleri c = new frmCariHareketleri();
            c.MdiParent = frmAnamenu.ActiveForm;
            c.Show();
        }
    }
}
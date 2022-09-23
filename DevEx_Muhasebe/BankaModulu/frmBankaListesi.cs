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
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaListesi()
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
        private void yeniKasaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaTanitimKarti KTK = new frmBankaTanitimKarti();
            KTK.ShowDialog();
            gridControl1.DataSource = BL.Gel_BankaListesi();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankaID").ToString();
            frmBankaTanitimKarti KTK = new frmBankaTanitimKarti();
            KTK.ShowDialog();
            gridControl1.DataSource = BL.Gel_BankaListesi();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankaID").ToString();
            frmBankaHareketleri KH = new frmBankaHareketleri();
            KH.MdiParent = frmAnamenu.ActiveForm;
            KH.Show();
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
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "BankaListesi_Listesi.xls";
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
            sfd.FileName = "BankaListesi_Listesi.xlsx";
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
            sfd.FileName = "BankaListesi_Listesi.pdf";
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
            sfd.FileName = "BankaListesi_Listesi.csv";
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
            sfd.FileName = "BankaListesi_Listesi.html";
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
            sfd.FileName = "BankaListesi_Listesi.jpg";
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
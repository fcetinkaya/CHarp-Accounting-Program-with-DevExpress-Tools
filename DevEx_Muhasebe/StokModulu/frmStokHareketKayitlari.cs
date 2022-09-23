using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.FaturaModulu.AlisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.frmSatisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.StokModulu.Raporlar;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu
{
    public partial class frmStokHareketKayitlari : DevExpress.XtraEditors.XtraForm
    {
        public frmStokHareketKayitlari()
        {
            InitializeComponent();
        }

        private cls_frmStokHareketleri SH = new cls_frmStokHareketleri();
        public static string Secilen_StokID;
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmStokListesi CL = new frmStokListesi();
                CL.ShowDialog();
                string StokID = frmAnamenu.SecilenKodID;
                if (!string.IsNullOrEmpty(StokID))
                {
                    string[] gelenCari = SH.StokKarti_Bilgileri(StokID);
                    txtStokKodu.Text = gelenCari[0];
                    txtStokIsmi.Text = gelenCari[1];
                    Secilen_StokID = gelenCari[2];
                    string[] Bakiyeler = SH.StokKarti_Bakiyeler(Secilen_StokID);
                    txtGiris.Text = Bakiyeler[0];
                    txtCikis.Text = Bakiyeler[1];
                    txtBakiye.Text = Bakiyeler[2];
                    decimal Bakiyem = Convert.ToDecimal(Bakiyeler[2]);
                    if (Bakiyem < 0)
                    {
                        txtBakiye.BackColor = Color.Red;
                        txtBakiye.ForeColor = Color.White;
                    } gridControl1.DataSource = SH.Gel_Stok_Hareketleri(StokID);
                    gridView1.ClearSelection();
                }
                frmAnamenu.SecilenKodID = "";
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmStokHareketKayitlari_Load(object sender, EventArgs e)
        {
            string StokID = frmAnamenu.CorbaSecilenID;
            if (!string.IsNullOrEmpty(StokID))
            {
                string[] gelenCari = SH.StokKarti_Bilgileri(StokID);
                txtStokKodu.Text = gelenCari[0];
                txtStokIsmi.Text = gelenCari[1];
                Secilen_StokID = gelenCari[2];
                string[] Bakiyeler = SH.StokKarti_Bakiyeler(Secilen_StokID);
                txtGiris.Text = Bakiyeler[0];
                txtCikis.Text = Bakiyeler[1];
                txtBakiye.Text = Bakiyeler[2];
                decimal Bakiyem = Convert.ToDecimal(Bakiyeler[2]);
                if (Bakiyem < 0)
                {
                    txtBakiye.BackColor = Color.Red;
                    txtBakiye.ForeColor = Color.White;
                }
                gridControl1.DataSource = SH.Gel_Stok_Hareketleri(StokID);
                gridView1.ClearSelection();
            }
            frmAnamenu.CorbaSecilenID = "";
        }
        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokTanitimKarti T = new frmStokTanitimKarti();
            T.ShowDialog();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    string CH_Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipi").ToString();
                    string Stok_hareketID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokHareketID").ToString();
                    string _FtID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FaturaID").ToString();
                    if (CH_Tipi == "Alış Faturası")
                    {
                        frmAnamenu.SecilenFtID = _FtID;
                        frmAlisFaturasi aft = new frmAlisFaturasi();
                        aft.MdiParent = frmAnamenu.ActiveForm;
                        aft.Show();
                    }
                    else if (CH_Tipi == "Alış iade Faturası")
                    {
                        frmAnamenu.SecilenFtID = _FtID;
                        frmAlisIadeFaturasi sft = new frmAlisIadeFaturasi();
                        sft.MdiParent = frmAnamenu.ActiveForm;
                        sft.Show();
                    }
                    else if (CH_Tipi == "Satış Faturası")
                    {
                        frmAnamenu.SecilenFtID = _FtID;
                        frmSatisFaturasi sft = new frmSatisFaturasi();
                        sft.MdiParent = frmAnamenu.ActiveForm;
                        sft.Show();
                    }
                    else if (CH_Tipi == "Satış iade Faturası")
                    {
                        frmAnamenu.SecilenFtID = _FtID;
                        frmSatisIadeFaturasi sft = new frmSatisIadeFaturasi();
                        sft.MdiParent = frmAnamenu.ActiveForm;
                        sft.Show();
                    }
                    else
                    {
                        frmAnamenu.CorbaSecilenID = Stok_hareketID;
                        frmStokAcilisKarti SAK = new frmStokAcilisKarti();
                        SAK.ShowDialog();
                    }
                    frmAnamenu.CorbaSecilenID = "";
                    frmAnamenu.SecilenFtID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void StokHareketRaporutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string Aydicik = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
                frmAnamenu.CorbaSecilenID = Aydicik;
                frmStokHareketRaporu HK = new frmStokHareketRaporu();
                HK.MdiParent = ActiveForm;
                HK.Show();
            }
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Report Tasarlanacak !!!");
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.xls";
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
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.xlsx";
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
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.pdf";
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
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.csv";
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
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.html";
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
            sfd.FileName = "StokHareketKayitlari_ExcelListesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void cariHareketKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    string Aydicik = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
                    frmAnamenu.CorbaSecilenID = Aydicik;
                    frmCariHareketleri CHK = new frmCariHareketleri();
                    CHK.MdiParent = ActiveForm;
                    CHK.Show();
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
    }
}
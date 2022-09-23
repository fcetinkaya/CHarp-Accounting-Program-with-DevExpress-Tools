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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.FaturaModulu.AlisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.frmSatisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu.Raporlar
{
    public partial class frmCariStokHareketRaporu : DevExpress.XtraEditors.XtraForm
    {
        public frmCariStokHareketRaporu()
        {
            InitializeComponent();
        }
        cls_StokCariHareketRaporu R = new cls_StokCariHareketRaporu();
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string AraKelime = "where";
                if (!string.IsNullOrEmpty(CariKoduBox.Text) || !string.IsNullOrEmpty(CariAdiBox.Text))
                {
                    AraKelime += string.Format(" CariKodu like '%{0}%' or CariIsim like '%{1}%'", CariKoduBox.Text, CariAdiBox.Text);
                }
                if (!string.IsNullOrEmpty(CariTipiCheck.Text))
                {
                    if (AraKelime == "where")
                    {

                        AraKelime += string.Format(" Tipi like '%{0}%'", CariTipiCheck.EditValue);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Tipi like '%{0}%'", CariTipiCheck.EditValue);
                    }
                }
                if (AraKelime == "where")
                {
                    AraKelime = "";
                }

                DataTable dt = R.Gel_StokListe_Bilgileri_Arama(AraKelime);
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
            frmAnamenu.CorbaSecilenID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenCariID = string.Empty;
            frmAnamenu.SecilenCariAdi = string.Empty;
            CariAdiBox.Text = string.Empty;
            CariKoduBox.Text = string.Empty;
            CariTipiCheck.EditValue = string.Empty;
            CariTipiCheck.Text = string.Empty;
            gridControl1.DataSource = null;
        }
        private void frmStokHareketRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
                frmStokTanitimKarti T = new frmStokTanitimKarti();
                T.ShowDialog();
            }
        }
        private void StokHareketleritoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StokID").ToString();
            frmStokHareketKayitlari HK = new frmStokHareketKayitlari();
            HK.MdiParent = ActiveForm;
            HK.Show();
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Report Tasarlanacak !!!");
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "CariStokHareket_Raporu.xls";
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
            sfd.FileName = "CariStokHareket_Raporu.xlsx";
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
            sfd.FileName = "CariStokHareket_Raporu.pdf";
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
            sfd.FileName = "CariStokHareket_Raporu.csv";
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
            sfd.FileName = "CariStokHareket_Raporu.html";
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
            sfd.FileName = "CariStokHareket_Raporu.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void frmStokHareketRaporu_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
                {
                    string[] gelenCari = R.CariKarti_Bilgileri(frmAnamenu.CorbaSecilenID);
                    CariKoduBox.Text = gelenCari[0];
                    CariAdiBox.Text = gelenCari[1];
                    //
                    string AraKelime = string.Format("where CariKodu like '%{0}%'", CariKoduBox.Text);
                    DataTable dt = R.Gel_StokListe_Bilgileri_Arama(AraKelime);
                    gridControl1.DataSource = dt;
                    frmAnamenu.CorbaSecilenID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void cariHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void CariKoduBox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmCariListesiSec CL = new frmCariListesiSec();
                CL.ShowDialog();
                string CariID = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(CariID))
                {
                    string[] gelenCari = R.CariKarti_Bilgileri(CariID);
                    CariKoduBox.Text = gelenCari[0];
                    CariAdiBox.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void yeniCariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariTanitimKarti c = new frmCariTanitimKarti();
            c.ShowDialog();
        }
        private void faturaDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    string CH_Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipi").ToString();
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
                    frmAnamenu.SecilenFtID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }




        }
    }
}
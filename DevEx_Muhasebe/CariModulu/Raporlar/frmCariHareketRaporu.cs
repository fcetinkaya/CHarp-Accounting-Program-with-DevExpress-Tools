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
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe.CariModulu.Class;
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu.Raporlar
{
    public partial class frmCariHareketRaporu : DevExpress.XtraEditors.XtraForm
    {
        public frmCariHareketRaporu()
        {
            InitializeComponent();
        }
        cls_CariHareketRaporu R = new cls_CariHareketRaporu();
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string AraKelime = "where";
                if (!string.IsNullOrEmpty(CariKoduBox.Text))
                {
                    AraKelime += string.Format(" CariKodu like '%{0}%'", CariKoduBox.Text);
                }
                if (!string.IsNullOrEmpty(CariAdiBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" CariIsim like '%{0}%'", CariAdiBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and CariIsim like '%{0}%'", CariAdiBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(IlBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Sehir like '%{0}%'", IlBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Sehir like '%{0}%'", IlBox.Text);
                    }

                }
                if (!string.IsNullOrEmpty(IlceBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Ilce like '%{0}%'", IlceBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Ilce like '%{0}%'", IlceBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(VergiDairesiBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" VergiDairesi like '%{0}%'", VergiDairesiBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and VergiDairesi like '%{0}%'", VergiDairesiBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(VergiNoBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" VergiNo like '%{0}%'", VergiNoBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and VergiNo like '%{0}%'", VergiNoBox.Text);
                    }
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

                DataTable dt = R.Gel_CariListe_Bilgileri_Arama(AraKelime);
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
            IlBox.Text = string.Empty;
            VergiDairesiBox.Text = string.Empty;
            VergiNoBox.Text = string.Empty;
            IlBox.Text = string.Empty;
            IlceBox.Text = string.Empty;
            CariTipiCheck.EditValue = string.Empty;
            CariTipiCheck.Text = string.Empty;
            gridControl1.DataSource = null;
        }
        private void frmStokHareketRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariTanitimKarti T = new frmCariTanitimKarti();
            T.ShowDialog();
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
                frmCariTanitimKarti T = new frmCariTanitimKarti();
                T.ShowDialog();
            }
        }
        private void StokHareketleritoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariHareketleri HK = new frmCariHareketleri();
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
            sfd.FileName = "CariHareketleri_Listesi.xls";
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
            sfd.FileName = "CariHareketleri_Listesi.xlsx";
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
            sfd.FileName = "CariHareketleri_Listesi.pdf";
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
            sfd.FileName = "CariHareketleri_Listesi.csv";
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
            sfd.FileName = "CariHareketleri_Listesi.html";
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
            sfd.FileName = "CariHareketleri_Listesi.jpg";
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
                    DataTable dt = R.Gel_CariListe_Bilgileri_Arama(AraKelime);
                    gridControl1.DataSource = dt;
                    frmAnamenu.CorbaSecilenID = "";
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
        private void cariStokHareketRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariStokHareketRaporu c = new frmCariStokHareketRaporu();
            c.MdiParent = frmAnamenu.ActiveForm;
            c.Show();
        }
    }
}
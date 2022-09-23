using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.CariModulu.Class;
using Gelisim_Muhasebe.FaturaModulu.AlisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.frmSatisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.CariModulu
{
    public partial class frmCariHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmCariHareketleri()
        {
            InitializeComponent();
        }
        cls_frmCariHareketler CH = new cls_frmCariHareketler();
        public static string Secilen_cariID;
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmCariListesiSec CL = new frmCariListesiSec();
                CL.ShowDialog();
                string CariId = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(CariId))
                {
                    string[] gelenCari = CH.CariKarti_Bilgileri(CariId);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariIsmi.Text = gelenCari[1];
                    Secilen_cariID = gelenCari[2];

                    string[] Bakiyeler = CH.CariKarti_Bakiyeler(CariId);
                    txtBorc.Text = Bakiyeler[0];
                    txtAlacak.Text = Bakiyeler[1];
                    txtBakiye.Text = Bakiyeler[2];
                    decimal Bakiyem = 0;
                    if (!string.IsNullOrEmpty(Bakiyeler[2]))
                    {
                        Bakiyem = Convert.ToDecimal(Bakiyeler[2]);
                    }
                    if (Bakiyem < 0)
                    {
                        txtBakiye.BackColor = Color.Red;
                        txtBakiye.ForeColor = Color.White;
                    }
                    gridControl1.DataSource = CH.Gel_Cari_Hareketleri(CariId);
                    frmAnamenu.SecilenCariID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmCariHareketleri_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
                {
                    string CariId = frmAnamenu.CorbaSecilenID;
                    string[] gelenCari = CH.CariKarti_Bilgileri(CariId);
                    txtCariKodu.Text = gelenCari[0];
                    txtCariIsmi.Text = gelenCari[1];
                    Secilen_cariID = gelenCari[2];

                    string[] Bakiyeler = CH.CariKarti_Bakiyeler(CariId);
                    txtBorc.Text = Bakiyeler[0];
                    txtAlacak.Text = Bakiyeler[1];
                    txtBakiye.Text = Bakiyeler[2];
                    decimal Bakiyem = Convert.ToDecimal(Bakiyeler[2]);
                    if (Bakiyem < 0)
                    {
                        txtBakiye.BackColor = Color.Red;
                        txtBakiye.ForeColor = Color.White;
                    }
                    else
                    {
                        txtBakiye.BackColor = Color.LightGreen;
                        txtBakiye.ForeColor = Color.Black;
                    }
                    gridControl1.DataSource = CH.Gel_Cari_Hareketleri(CariId);
                    frmAnamenu.CorbaSecilenID = "";
                }
            }
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
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
                    else
                    {
                        string Cari_hareketID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariHareketID").ToString();
                        frmAnamenu.CorbaSecilenID = Cari_hareketID;
                        frmCariAcilisKarti CAK = new frmCariAcilisKarti();
                        CAK.ShowDialog();
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
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Hazırlanacak");
        }

        private void frmCariHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnamenu.CorbaSecilenID = "";
            frmAnamenu.SecilenFtID = "";
            gridControl1.DataSource = null;
        }
    }
}
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
using Gelisim_Muhasebe.BankaModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.BankaModulu
{
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaHareketleri()
        {
            InitializeComponent();
        }
        cls_frmBankaHareketleri KH = new cls_frmBankaHareketleri();
        public static string SecilenBankaID;
        private void btnBankaSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankaListesiSec KL = new frmBankaListesiSec();
                KL.ShowDialog();
                string BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(BankaID))
                {
                    string[] gelenCari = KH.BankaKarti_Bilgileri(BankaID);
                    txtBankaKodu.Text = gelenCari[0];
                    txtBankaIsmi.Text = gelenCari[1];
                    SecilenBankaID = gelenCari[2];

                    string[] Bakiyeler = KH.BankaKarti_Bakiyeler(BankaID); if (!string.IsNullOrEmpty(Bakiyeler[0]))
                    {
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
                        gridControl1.DataSource = KH.Banka_Hareketleri(BankaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                    else
                    {
                        txtBakiye.BackColor = Color.White;
                        txtBakiye.ForeColor = Color.Black;
                        txtBorc.Text = "";
                        txtAlacak.Text = "";
                        txtBakiye.Text = "";
                        gridControl1.DataSource = KH.Banka_Hareketleri(BankaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                    gridView1.ClearSelection();}
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                string BankaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(BankaID))
                {
                    string[] gelenCari = KH.BankaKarti_Bilgileri(BankaID);
                    txtBankaKodu.Text = gelenCari[0];
                    txtBankaIsmi.Text = gelenCari[1];
                    SecilenBankaID = gelenCari[2];

                    string[] Bakiyeler = KH.BankaKarti_Bakiyeler(BankaID);
                    if (!string.IsNullOrEmpty(Bakiyeler[0]))
                    {
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
                        gridControl1.DataSource = KH.Banka_Hareketleri(BankaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                    else
                    {
                        txtBakiye.BackColor = Color.White;
                        txtBakiye.ForeColor = Color.Black;
                        txtBorc.Text = "";
                        txtAlacak.Text = "";
                        txtBakiye.Text = "";
                        gridControl1.DataSource = KH.Banka_Hareketleri(BankaID);
                        frmAnamenu.SecilenCariID = "";
                        frmAnamenu.CorbaSecilenID = "";
                    }
                    gridView1.ClearSelection();
                }
            }
        }
        private void frmBankaHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            SecilenBankaID = "";
            txtBankaKodu.Text = "";
            txtBankaIsmi.Text = "";
            txtBakiye.BackColor = Color.White;
            txtBakiye.ForeColor = Color.Black;
            txtBorc.Text = "";
            txtAlacak.Text = "";
            txtBakiye.Text = "";
            gridControl1.DataSource = null;
            frmAnamenu.SecilenCariID = "";
            frmAnamenu.CorbaSecilenID = "";
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "BankaHareketleri_Listesi.xls";
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
            sfd.FileName = "BankaHareketleri_Listesi.xlsx";
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
            sfd.FileName = "BankaHareketleri_Listesi.pdf";
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
            sfd.FileName = "BankaHareketleri_Listesi.csv";
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
            sfd.FileName = "BankaHareketleri_Listesi.html";
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
            sfd.FileName = "BankaHareketleri_Listesi.jpg";
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
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    string KH_Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipi").ToString();
                    string Banka_hareketID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankaHareketID").ToString();
                    frmAnamenu.CorbaSecilenID = Banka_hareketID;
                    string _BankaID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BankaID").ToString();
                    if (KH_Tipi == "Giden")
                    {
                        frmGidenHavale aft = new frmGidenHavale();
                        aft.ShowDialog();
                    }
                    else if (KH_Tipi == "Gelen")
                    {
                        frmGelenHavale sft = new frmGelenHavale();
                        sft.ShowDialog();
                    }
                    else if (KH_Tipi == "İşlem")
                    {
                        frmBankaIslemi sft = new frmBankaIslemi();
                        sft.ShowDialog();
                    }
                    else
                    {
                        frmBankaAcilisKarti KAK = new frmBankaAcilisKarti();
                        KAK.ShowDialog();
                    }
                    string[] Bakiyeler = KH.BankaKarti_Bakiyeler(_BankaID);
                    if (!string.IsNullOrEmpty(Bakiyeler[0]))
                    {
                        txtBorc.Text = Bakiyeler[0];
                        txtAlacak.Text = Bakiyeler[1];
                        txtBakiye.Text = Bakiyeler[2];
                        decimal Bakiyem = 0;
                        if (!string.IsNullOrEmpty(Bakiyeler[2]))
                        {
                            Bakiyem = Convert.ToDecimal(Bakiyeler[2]);
                            txtBakiye.BackColor = Color.LightGreen;
                            txtBakiye.ForeColor = Color.Black;
                        }
                        if (Bakiyem < 0)
                        {
                            txtBakiye.BackColor = Color.Red;
                            txtBakiye.ForeColor = Color.White;
                        }
                    }
                    gridControl1.DataSource = KH.Banka_Hareketleri(SecilenBankaID);
                    frmAnamenu.CorbaSecilenID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        }
}
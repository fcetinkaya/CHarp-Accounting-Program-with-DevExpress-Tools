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
using Gelisim_Muhasebe.Kasa.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Kasa
{
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaHareketleri()
        {
            InitializeComponent();
        }
        cls_frmKasaHareketleri KH = new cls_frmKasaHareketleri();
        public static string SecilenKasaID;
        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                string KasaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KasaID))
                {
                    string[] gelenCari = KH.KasaKarti_Bilgileri(KasaID);
                    txtKasaKodu.Text = gelenCari[0];
                    txtKasaIsmi.Text = gelenCari[1];
                    SecilenKasaID = gelenCari[2];

                    string[] Bakiyeler = KH.KasaKarti_Bakiyeler(KasaID);
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
                        gridControl1.DataSource = KH.Kasa_Hareketleri(KasaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                    else
                    {
                        txtBakiye.BackColor = Color.White;
                        txtBakiye.ForeColor = Color.Black;
                        txtBorc.Text = "";
                        txtAlacak.Text = "";
                        txtBakiye.Text = "";
                        gridControl1.DataSource = KH.Kasa_Hareketleri(KasaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                }
            }
        }
        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            try
            {
                frmKasaListesi KL = new frmKasaListesi();
                KL.ShowDialog();
                string KasaID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KasaID))
                {
                    string[] gelenCari = KH.KasaKarti_Bilgileri(KasaID);
                    txtKasaKodu.Text = gelenCari[0];
                    txtKasaIsmi.Text = gelenCari[1];
                    SecilenKasaID = gelenCari[2];

                    string[] Bakiyeler = KH.KasaKarti_Bakiyeler(KasaID);
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
                        gridControl1.DataSource = KH.Kasa_Hareketleri(KasaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                    else
                    {
                        txtBakiye.BackColor = Color.White;
                        txtBakiye.ForeColor = Color.Black;
                        txtBorc.Text = "";
                        txtAlacak.Text = "";
                        txtBakiye.Text = "";
                        gridControl1.DataSource = KH.Kasa_Hareketleri(KasaID);
                        frmAnamenu.SecilenCariID = "";
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
     private void frmKasaHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            SecilenKasaID = "";
            txtKasaKodu.Text = "";
            txtKasaIsmi.Text = "";
            txtBakiye.BackColor = Color.White;
            txtBakiye.ForeColor = Color.Black;
            txtBorc.Text = "";
            txtAlacak.Text = "";
            txtBakiye.Text = "";
            gridControl1.DataSource = null;
            frmAnamenu.SecilenCariID = "";
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    string KH_Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipi").ToString();
                    string Kasa_hareketID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KasaHareketID").ToString();
                    string _KasaID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KasaID").ToString();
                    if (KH_Tipi == "Tediye")
                    {
                        frmAnamenu.CorbaSecilenID = Kasa_hareketID;
                        frmKasaTediye aft = new frmKasaTediye();
                        aft.ShowDialog();
                    }
                    else if (KH_Tipi == "Tahsilat")
                    {
                        frmAnamenu.CorbaSecilenID = Kasa_hareketID;
                        frmKasaTahsilat sft = new frmKasaTahsilat();
                        sft.ShowDialog();
                    }
                    else
                    {
                        frmAnamenu.CorbaSecilenID = Kasa_hareketID;
                        frmKasaAcilisKarti KAK = new frmKasaAcilisKarti();
                        KAK.ShowDialog();
                    }
                    string[] Bakiyeler = KH.KasaKarti_Bakiyeler(_KasaID);
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
                    gridControl1.DataSource = KH.Kasa_Hareketleri(SecilenKasaID);
                    frmAnamenu.CorbaSecilenID = "";
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_MesajBox.UyariMesaji("Hazırlanacak");
        }
        private void excel2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "KasaHareketleri_Listesi.xls";
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
            sfd.FileName = "KasaHareketleri_Listesi.xlsx";
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
            sfd.FileName = "KasaHareketleri_Listesi.pdf";
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
            sfd.FileName = "KasaHareketleri_Listesi.csv";
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
            sfd.FileName = "KasaHareketleri_Listesi.html";
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
            sfd.FileName = "KasaHareketleri_Listesi.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
    }
}
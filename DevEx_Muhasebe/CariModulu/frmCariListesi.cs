using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using Gelisim_Muhasebe.Cariler.Class;
using Gelisim_Muhasebe.CariModulu;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.StokModulu.Raporlar;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.Cariler
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        private cls_frmCariListesi CL = new cls_frmCariListesi();

        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BeklemeEkraniGoster();
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void CariArama()
        {
            string AraKelime = "";
            if (comboMusteriTipi.Text == "Seçiniz")
            {
                AraKelime = "and CariKodu like '%" + CariKoduBox.Text + "%' and CariIsim like '%" + CariAdiBox.Text +
                            "%' and Sehir like '%" + SehirBox.Text + "%' and Ilce like '%" + IlceBox.Text +
                            "%' and Tc like '%" + TcKimlikBox.Text + "%'";
            }
            else
            {
                AraKelime = "and CariKodu like '%" + CariKoduBox.Text + "%' and CariIsim like '%" + CariAdiBox.Text +
                            "%' and Sehir like '%" + SehirBox.Text + "%' and Ilce like '%" + IlceBox.Text +
                            "%' and Tc like '%" + TcKimlikBox.Text + "%' and Tipi='" + comboMusteriTipi.Text + "'";
            }
            DataTable dt = CL.Gel_CariKarti_Bilgileri_Arama(AraKelime);
            gridControl1.DataSource = dt;
        }
        public void BeklemeEkraniGoster()
        {
            SplashScreenManager.ShowForm(typeof(frmWait));
            CariArama();
            SplashScreenManager.CloseForm();
        }
        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            CariKoduBox.Text = "";
            CariAdiBox.Text = "";
            SehirBox.Text = "";
            IlceBox.Text = "";
            TcKimlikBox.Text = "";
            comboMusteriTipi.Text = "Seçiniz";
            DataTable dt = CL.Gel_CariListe_Bilgileri();
            gridControl1.DataSource = dt;

        }
        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CL.Gel_CariListe_Bilgileri();
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariTanitimKarti STK = new frmCariTanitimKarti();
            STK.ShowDialog();
            DataTable dt = CL.Gel_CariListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariTanitimKarti CTK = new frmCariTanitimKarti();
            CTK.ShowDialog();
            DataTable dt = CL.Gel_CariListe_Bilgileri();
            gridControl1.DataSource = dt;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariHareketleri ch = new frmCariHareketleri();
            ch.MdiParent = frmAnamenu.ActiveForm;
            ch.Show();
        }
        private void CariStokHareketRaporuTooltip_Click(object sender, EventArgs e)
        {
            frmAnamenu.CorbaSecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CariID").ToString();
            frmCariHareketRaporu ch = new frmCariHareketRaporu();
            ch.MdiParent = frmAnamenu.ActiveForm;
            ch.Show();
        }
        private void excel97ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = "CariListesi.xls";
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
            sfd.FileName = "CariListesi.xlsx";
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
            sfd.FileName = "CariListesi.pdf";
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
            sfd.FileName = "CariListesi.csv";
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
            sfd.FileName = "CariListesi.html";
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
            sfd.FileName = "CariListesi.jpg";
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
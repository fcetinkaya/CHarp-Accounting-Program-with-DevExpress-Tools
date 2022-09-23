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
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu.Raporlar
{
    public partial class frmTarihAraligiStokHareketRaporu : DevExpress.XtraEditors.XtraForm
    {
        public frmTarihAraligiStokHareketRaporu()
        {
            InitializeComponent();
        }
        cls_TarihAraligiStokHareketRaporu R = new cls_TarihAraligiStokHareketRaporu();
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string AraKelime = "where";
                if (!string.IsNullOrEmpty(IlkTarihBox.Text) || !string.IsNullOrEmpty(IkinciTarihBox.Text))
                {
                    AraKelime += string.Format(" convert(DATE,Tarih,104) between convert(DATE,'{0}',104) and convert(DATE,'{1}',104)", IlkTarihBox.Text,IkinciTarihBox.Text);
                }
               if (!string.IsNullOrEmpty(StokKoduBox.Text) || !string.IsNullOrEmpty(StokAdiBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" StokKodu like '%{0}%' or StokAdi like '%{1}%'", StokKoduBox.Text, StokAdiBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and StokKodu like '%{0}%' or StokAdi like '%{1}%'", StokKoduBox.Text, StokAdiBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(Kod1Box.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Kod1 like '%{0}%'", Kod1Box.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Kod1 like '%{0}%'", Kod1Box.Text);
                    }

                }
                if (!string.IsNullOrEmpty(Kod2Box.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Kod2 like '%{0}%'", Kod2Box.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Kod2 like '%{0}%'", Kod2Box.Text);
                    }
                }
                if (!string.IsNullOrEmpty(Kod3Box.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Kod3 like '%{0}%'", Kod3Box.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Kod3 like '%{0}%'", Kod3Box.Text);
                    }
                }
                if (!string.IsNullOrEmpty(Kod4Box.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Kod4 like '%{0}%'", Kod4Box.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Kod4 like '%{0}%'", Kod4Box.Text);
                    }
                }
                if (!string.IsNullOrEmpty(Kod5Box.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Kod5 like '%{0}%'", Kod5Box.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Kod5 like '%{0}%'", Kod5Box.Text);
                    }
                }
                if (AraKelime == "where")
                {
                    AraKelime = "";
                }DataTable dt = R.Gel_StokListe_Bilgileri_Arama(AraKelime);
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
            StokAdiBox.Text = string.Empty;
            StokKoduBox.Text = string.Empty;
            Kod1Box.Text = string.Empty;
            Kod2Box.Text = string.Empty;
            Kod3Box.Text = string.Empty;
            Kod4Box.Text = string.Empty;
            Kod5Box.Text = string.Empty;
            IlkTarihBox.EditValue = string.Empty;
            IkinciTarihBox.EditValue = string.Empty;
            gridControl1.DataSource = null;
        }
        private void frmStokHareketRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        private void Kod1Box_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod1 = new frmStokKod1();
            frmKod1.ShowDialog();
            Kod1Box.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void Kod2Box_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod2 = new frmStokKod2();
            frmKod2.ShowDialog();
            Kod2Box.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void Kod3Box_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod3 = new frmStokKod3();
            frmKod3.ShowDialog();
            Kod3Box.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void Kod4Box_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod4 = new frmStokKod4();
            frmKod4.ShowDialog();
            Kod4Box.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void Kod5Box_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod5 = new frmStokKod5();
            frmKod5.ShowDialog();
            Kod5Box.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokTanitimKarti T = new frmStokTanitimKarti();
            T.ShowDialog();
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
            sfd.FileName = "StokCariHareket_Raporu.xls";
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
            sfd.FileName = "StokCariHareket_Raporu.xlsx";
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
            sfd.FileName = "StokCariHareket_Raporu.pdf";
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
            sfd.FileName = "StokCariHareket_Raporu.csv";
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
            sfd.FileName = "StokCariHareket_Raporu.html";
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
            sfd.FileName = "StokCariHareket_Raporu.jpg";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.OptionsPrint.ExpandAllDetails = true;
                CreateImage(gridControl1, sfd);
            }
        }
        private void frmStokHareketRaporu_Load(object sender, EventArgs e){
            try
            {
                if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
                {
                    string[] gelenStok = R.Gel_StokKarti_Bilgileri(frmAnamenu.CorbaSecilenID);
                    StokKoduBox.Text = gelenStok[0];
                    StokAdiBox.Text = gelenStok[1];
                    //
                    string AraKelime = string.Format("where StokKodu like '%{0}%'", StokKoduBox.Text);
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
        private void StokKoduBox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmStokListesi CL = new frmStokListesi();
                CL.ShowDialog();
                string StokID = frmAnamenu.SecilenKodID;
                if (!string.IsNullOrEmpty(StokID))
                {
                    string[] gelenStok = R.Gel_StokKarti_Bilgileri(StokID);
                    StokKoduBox.Text = gelenStok[0];
                    StokAdiBox.Text = gelenStok[1];
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
    }
}
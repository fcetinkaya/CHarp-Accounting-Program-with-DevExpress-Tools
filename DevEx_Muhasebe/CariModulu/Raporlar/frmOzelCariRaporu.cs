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
using Gelisim_Muhasebe.CariModulu.Class;
using Gelisim_Muhasebe.FaturaModulu.AlisFaturalari;
using Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.frmSatisIadeFaturalari;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.StokModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu.Raporlar
{
    public partial class frmOzelCariRaporu : DevExpress.XtraEditors.XtraForm
    {
        public frmOzelCariRaporu()
        {
            InitializeComponent();
        }
        cls_OzelCariRaporu R = new cls_OzelCariRaporu();
        private void AraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string AraKelime = "where";
                if (!string.IsNullOrEmpty(CariKoduBox.Text) || !string.IsNullOrEmpty(CariKoduBox.Text))
                {
                    AraKelime += string.Format(" CariKodu like '%{0}%' and CariIsim like '%{1}%'", CariKoduBox.Text, CariAdiBox.Text);
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
                if (!string.IsNullOrEmpty(SehirBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Sehir like '%{0}%'", SehirBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Sehir like '%{0}%'", SehirBox.Text);
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
                if (!string.IsNullOrEmpty(IlkTarihBox.Text) || !string.IsNullOrEmpty(IkinciTarihBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" convert(DATE,Tarih,104) between convert(DATE,'{0}',104) and convert(DATE,'{1}',104)", IlkTarihBox.Text, IkinciTarihBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and convert(DATE,Tarih,104) between convert(DATE,'{0}',104) and convert(DATE,'{1}',104)", IlkTarihBox.Text, IkinciTarihBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(VadeTarihIlkBox.Text) || !string.IsNullOrEmpty(VadeTarihiIkiBox.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" convert(DATE,VadeTarihi,104) between convert(DATE,'{0}',104) and convert(DATE,'{1}',104)", VadeTarihIlkBox.Text, VadeTarihiIkiBox.Text);
                    }
                    else
                    {
                        AraKelime += string.Format(" and convert(DATE,VadeTarihi,104) between convert(DATE,'{0}',104) and convert(DATE,'{1}',104)", VadeTarihIlkBox.Text, VadeTarihiIkiBox.Text);
                    }
                }
                if (!string.IsNullOrEmpty(CariTipiCheck.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" CariTipi like '%{0}%'", CariTipiCheck.EditValue);
                    }
                    else
                    {
                        AraKelime += string.Format(" and CariTipi like '%{0}%'", CariTipiCheck.EditValue);
                    }
                }
                if (!string.IsNullOrEmpty(FaturaTipiCheck.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" FaturaTipi like '%{0}%'", FaturaTipiCheck.EditValue);
                    }
                    else
                    {
                        AraKelime += string.Format(" and FaturaTipi like '%{0}%'", FaturaTipiCheck.EditValue);
                    }
                }
                if (!string.IsNullOrEmpty(FaturaTuruCombo.Text))
                {
                    if (AraKelime == "where")
                    {
                        AraKelime += string.Format(" Turu like '%{0}%'", FaturaTuruCombo.EditValue);
                    }
                    else
                    {
                        AraKelime += string.Format(" and Turu like '%{0}%'", FaturaTuruCombo.EditValue);
                    }
                }
                if (AraKelime == "where")
                {
                    AraKelime = "";
                }

                DataTable dt = R.Gel_OzelCariRaporu(AraKelime);
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
            CariKoduBox.Text = string.Empty;
            CariAdiBox.Text = string.Empty;
            StokAdiBox.Text = string.Empty;
            StokKoduBox.Text = string.Empty;
            SehirBox.Text = string.Empty;
            IlceBox.Text = string.Empty;
            IlkTarihBox.EditValue = string.Empty;
            IkinciTarihBox.EditValue = string.Empty;
            VadeTarihIlkBox.EditValue = string.Empty;
            VadeTarihiIkiBox.EditValue = string.Empty;
            CariTipiCheck.EditValue = string.Empty;
            CariTipiCheck.Text = string.Empty;
            FaturaTipiCheck.EditValue = string.Empty;
            FaturaTipiCheck.Text = string.Empty;
            FaturaTuruCombo.EditValue = string.Empty;
            FaturaTuruCombo.Text = string.Empty;
            gridControl1.DataSource = null;
        }
        private void frmStokHareketRaporu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
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
            sfd.FileName = "OzelCari_Raporu.xls";
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
            sfd.FileName = "OzelCari_Raporu.xlsx";
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
            sfd.FileName = "OzelCari_Raporu.pdf";
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
            sfd.FileName = "OzelCari_Raporu.csv";
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
            sfd.FileName = "OzelCari_Raporu.html";
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
            sfd.FileName = "OzelCari_Raporu.jpg";
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
                    string[] gelenCari = R.StokKarti_Bilgileri(frmAnamenu.CorbaSecilenID);
                    StokKoduBox.Text = gelenCari[0];
                    StokAdiBox.Text = gelenCari[1];
                    //
                    string AraKelime = string.Format("where StokKodu like '%{0}%'", StokKoduBox.Text);
                    DataTable dt = R.Gel_OzelCariRaporu(AraKelime);
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
        private void StokKoduBox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmStokListesiSec CL = new frmStokListesiSec();
                CL.ShowDialog();
                string StokID = frmAnamenu.SecilenKodID;
                if (!string.IsNullOrEmpty(StokID))
                {
                    string[] gelenStok = R.StokKarti_Bilgileri(StokID);
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
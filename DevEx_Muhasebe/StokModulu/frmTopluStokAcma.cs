using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.StokModulu
{
    public partial class frmTopluStokAcma : DevExpress.XtraEditors.XtraForm
    {
        public frmTopluStokAcma()
        {
            InitializeComponent();
        }
        cls_StokTanitimKarti STK = new cls_StokTanitimKarti();
        cls_StokKod1 clsKod1 = new cls_StokKod1();
        cls_StokKod2 clsKod2 = new cls_StokKod2();
        cls_StokKod3 clsKod3 = new cls_StokKod3();
        cls_StokKod4 clsKod4 = new cls_StokKod4();
        cls_StokKod5 clsKod5 = new cls_StokKod5();
        private DataTable ReadFromExcelData(string filePath)
        {
            OleDbDataAdapter da;
            DataTable dTableExcel = new DataTable();

            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;";
            //    OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0");
            try
            {
                da = new OleDbDataAdapter("SELECT * FROM [Sheet1$A:Z]", strConn);
                da.Fill(dTableExcel);
            }
            catch (Exception)
            {
                da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$A:Z]", strConn);
                da.Fill(dTableExcel);
            }
            return dTableExcel;
        }
        private void AcbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog Ac = new OpenFileDialog();
                Ac.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx";
                if (Ac.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = ReadFromExcelData(Ac.FileName);
                    if (dt != null)
                    {
                        gridControl1.DataSource = dt;
                    }
                }
                foreach (Control Nesne in splitContainerControl1.Panel1.Controls)
                {
                    if (Nesne is ComboBoxEdit)
                    {
                        SutunAl((ComboBoxEdit)Nesne);
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        public void SutunAl(ComboBoxEdit Nesne)
        {
            ComboBoxItemCollection Sutunlar = Nesne.Properties.Items;
            Sutunlar.Clear();
            Sutunlar.BeginUpdate();
            Sutunlar.Add("");
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                Sutunlar.Add(gridView1.Columns[i].FieldName.ToString());
            }
            Nesne.SelectedIndex = 0;
            Sutunlar.EndUpdate();
        }
        public string DegerAl(ComboBoxEdit Nesne, int SatirID)
        {
            string Deger = "";
            if (Nesne.SelectedIndex > 0)
            {
                Deger = gridView1.GetRowCellValue(SatirID, Nesne.SelectedItem.ToString()).ToString();
            }
            return Deger;
        }
        public void IceAktar()
        {
            string StokKodu,
                StokAdi,
                IngilizceAdi,
                Kod1,
                Kod2,
                Kod3,
                Kod4,
                Kod5,
                Birim,
                Barkod,
                AlisFiyat1,
                AlisKdv1Oran,
                AlisFiyat2,
                AlisKdv2Oran,
                SatisFiyat1,
                SatissKdv1Oran,
                SatisFiyat2,
                SatissKdv2Oran;

            double SatisKDV1 = 0;
            double AlisKDV2 = 0;
            double SatisKDV2 = 0;
            double AlisKDV1 = 0; double AlisF1D = 0;
            double AlisF2D = 0;
            double SatisF1D = 0;
            double SatisF2D = 0;

            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                StokKodu = DegerAl(StokKoducombo, i);
                StokAdi = DegerAl(StokAdicombo, i);
                IngilizceAdi = DegerAl(IngilizceAdicombo, i);
                Kod1 = DegerAl(Kod1combo, i);
                Kod2 = DegerAl(Kod2combo, i);
                Kod3 = DegerAl(Kod3combo, i);
                Kod4 = DegerAl(Kod4combo, i);
                Kod5 = DegerAl(Kod5combo, i);
                Birim = DegerAl(Birimcombo, i);
                Barkod = DegerAl(Barkodcombo, i);
                AlisFiyat1 = DegerAl(AlisFiyat1combo, i);
                AlisKdv1Oran = DegerAl(AlisKDV1Orancombo, i);
                AlisFiyat2 = DegerAl(AlisFiyat2combo, i);
                AlisKdv2Oran = DegerAl(AlisKDV2Orancombo, i);
                SatisFiyat1 = DegerAl(SatisFiyat1combo, i);
                SatissKdv1Oran = DegerAl(SatisKDV1Orancombo, i);
                SatisFiyat2 = DegerAl(SatisFiyat2combo, i);
                SatissKdv2Oran = DegerAl(SatisKDV2Orancombo, i);

                // Alış Fiyatları
                if (!string.IsNullOrEmpty(AlisFiyat1) && (!string.IsNullOrEmpty(AlisKdv1Oran)))
                {
                    AlisF1D = Convert.ToDouble(AlisFiyat1);
                    double AlisKDVOran1D = Convert.ToDouble(AlisKdv1Oran);
                    double AlisKdv1D = AlisF1D / 100 * AlisKDVOran1D;
                    AlisKDV1 = AlisKdv1D;
                    AlisKdv1Oran = "% " + AlisKdv1Oran;
                }
                if (!string.IsNullOrEmpty(AlisFiyat2) && (!string.IsNullOrEmpty(AlisKdv2Oran)))
                {
                    AlisF2D = Convert.ToDouble(AlisFiyat2);
                    double AlisKDVOran2D = Convert.ToDouble(AlisKdv2Oran);
                    double AlisKdv2D = AlisF2D / 100 * AlisKDVOran2D;
                    AlisKDV2 = AlisKdv2D;
                    AlisKdv2Oran = "%" + AlisKdv2Oran;
                }
                if (!string.IsNullOrEmpty(SatisFiyat1) && (!string.IsNullOrEmpty(SatissKdv1Oran)))
                {
                    SatisF1D = Convert.ToDouble(SatisFiyat1);
                    double SatisKDVOran1D = Convert.ToDouble(SatissKdv1Oran);
                    double SatisKdv1D = SatisF1D / 100 * SatisKDVOran1D;
                    SatisKDV1 = SatisKdv1D;
                    SatissKdv1Oran = "%" + SatissKdv1Oran;
                }
                if (!string.IsNullOrEmpty(SatisFiyat2) && (!string.IsNullOrEmpty(SatissKdv2Oran)))
                {
                    SatisF2D = Convert.ToDouble(SatisFiyat2);
                    double SatisKDVOran2D = Convert.ToDouble(SatissKdv2Oran);
                    double SatisKdv2D = SatisF2D / 100 * SatisKDVOran2D;
                    SatisKDV2 = SatisKdv2D;
                    SatissKdv2Oran = "%" + SatissKdv2Oran;
                }
                //Satış Fiyaları
                if (!string.IsNullOrEmpty(Kod1))
                {
                    Kod1 = clsKod1.TopluStokEkleme_StokKodKullanimdami(Kod1, frmAnamenu.KullaniciID);
                }
                if (!string.IsNullOrEmpty(Kod2))
                {
                    Kod2 = clsKod2.TopluStokEkleme_StokKodKullanimdami(Kod2, frmAnamenu.KullaniciID);
                }
                if (!string.IsNullOrEmpty(Kod3))
                {
                    Kod3 = clsKod3.TopluStokEkleme_StokKodKullanimdami(Kod3, frmAnamenu.KullaniciID);
                }
                if (!string.IsNullOrEmpty(Kod4))
                {
                    Kod4 = clsKod4.TopluStokEkleme_StokKodKullanimdami(Kod4, frmAnamenu.KullaniciID);

                }
                if (!string.IsNullOrEmpty(Kod5))
                {
                    Kod5 = clsKod5.TopluStokEkleme_StokKodKullanimdami(Kod5, frmAnamenu.KullaniciID);
                }
                STK.StokKodKayit(StokKodu, StokAdi, IngilizceAdi, Kod1, Kod2, Kod3, Kod4, Kod5, Birim, Barkod, AlisF1D.ToString(), AlisKDV1.ToString(), AlisKdv1Oran, AlisF2D.ToString(), AlisKDV2.ToString(),
                     AlisKdv2Oran, SatisF1D.ToString(), SatisKDV1.ToString(), SatissKdv1Oran,
                    SatisF2D.ToString(), SatisKDV2.ToString(), SatissKdv2Oran, frmAnamenu.KullaniciID);
            }
            Cursor = Cursors.Default;
        }
        private void IceAktarbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    if (cls_MesajBox.Sor("Kayıt etmek istediğinize emin misiniz ?"))
                    {
                        IceAktar();
                        cls_MesajBox.KayitMesaji("Bilgiler Kayıt Edildi.");
                    }
                }
                else
                {
                    cls_MesajBox.UyariMesaji("Excel dosyasını seçiniz.");
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
                Cursor = Cursors.Default;
            }
        }
        private void KapatbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
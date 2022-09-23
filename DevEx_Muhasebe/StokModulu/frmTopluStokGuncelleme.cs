using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
    public partial class frmTopluStokGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        public frmTopluStokGuncelleme()
        {
            InitializeComponent();
        }
        cls_StokKod1 clsKod1 = new cls_StokKod1();
        cls_StokKod2 clsKod2 = new cls_StokKod2();
        cls_StokKod3 clsKod3 = new cls_StokKod3();
        cls_StokKod4 clsKod4 = new cls_StokKod4();
        cls_StokKod5 clsKod5 = new cls_StokKod5();
        cls_StokTanitimKarti STK = new cls_StokTanitimKarti();
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
                //if (!string.IsNullOrEmpty(AlisFiyat1) && (!string.IsNullOrEmpty(AlisKdv1Oran)))
                //{
                //    AlisF1D = Convert.ToDouble(AlisFiyat1);
                //    double AlisKDVOran1D = Convert.ToDouble(AlisKdv1Oran);
                //    double AlisKdv1D = AlisF1D / 100 * AlisKDVOran1D;
                //    AlisKDV1 = AlisKdv1D;
                //    AlisKdv1Oran = "% " + AlisKdv1Oran;
                //}
                //if (!string.IsNullOrEmpty(AlisFiyat2) && (!string.IsNullOrEmpty(AlisKdv2Oran)))
                //{
                //    AlisF2D = Convert.ToDouble(AlisFiyat2);
                //    double AlisKDVOran2D = Convert.ToDouble(AlisKdv2Oran);
                //    double AlisKdv2D = AlisF2D / 100 * AlisKDVOran2D;
                //    AlisKDV2 = AlisKdv2D;
                //    AlisKdv2Oran = "%" + AlisKdv2Oran;
                //}
                //if (!string.IsNullOrEmpty(SatisFiyat1) && (!string.IsNullOrEmpty(SatissKdv1Oran)))
                //{
                    //SatisF1D = Convert.ToDouble(SatisFiyat1);
                    //double SatisKDVOran1D = Convert.ToDouble(SatissKdv1Oran);
                    //double SatisKdv1D = SatisF1D / 100 * SatisKDVOran1D;
                    //SatisKDV1 = SatisKdv1D;
                    //SatissKdv1Oran = "%" + SatissKdv1Oran;
                //}
                //if (!string.IsNullOrEmpty(SatisFiyat2) && (!string.IsNullOrEmpty(SatissKdv2Oran)))
                //{
                //    SatisF2D = Convert.ToDouble(SatisFiyat2);
                //    double SatisKDVOran2D = Convert.ToDouble(SatissKdv2Oran);
                //    double SatisKdv2D = SatisF2D / 100 * SatisKDVOran2D;
                //    SatisKDV2 = SatisKdv2D;
                //    SatissKdv2Oran = "%" + SatissKdv2Oran;
                //}
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
                string SQL = "update Muhasebe_TBL_Stoklar set ";
                if (checkStokAdi.Checked)
                {
                    SQL += "StokAdi='" + StokAdi + "',";
                }
                if (checkIngAdi.Checked)
                {
                    SQL += "IngilizceAdi='" + IngilizceAdi + "',";
                }
                if (checkKod1.Checked)
                {
                    SQL += "Kod1='" + Kod1 + "',";
                }
                if (checkKod2.Checked)
                {
                    SQL += "Kod2='" + Kod2 + "',";
                }
                if (checkKod3.Checked)
                {
                    SQL += "Kod3'" + Kod3 + "',";
                }
                if (checkKod4.Checked)
                {
                    SQL += "Kod4='" + Kod4 + "',";
                }
                if (checkKod5.Checked)
                {
                    SQL += "Kod5='" + Kod5 + "',";
                }
                if (checkBirim.Checked)
                {
                    SQL += "Birim='" + Birim + "',";
                }
                if (checkBarkod.Checked)
                {
                    SQL += "Barkod='" + Barkod + "',";
                }
                if (checkAlisFiyat1.Checked)
                {
                    AlisF1D = Convert.ToDouble(AlisFiyat1);
                    SQL += "AlisFiyat1='" + AlisF1D.ToString() + "',";
                }
                if (checkalisKDV1Oran.Checked)
                {
                    AlisF1D = Convert.ToDouble(AlisFiyat1);
                    double AlisKDVOran1D = Convert.ToDouble(AlisKdv1Oran);
                    double AlisKdv1D = AlisF1D / 100 * AlisKDVOran1D;
                    AlisKDV1 = AlisKdv1D;
                    AlisKdv1Oran = "% " + AlisKdv1Oran;

                    SQL += "AlisKdv1Oran='" + AlisKdv1Oran + "',";
                    SQL += "AlisKdv1='" + AlisKDV1.ToString() + "',";
                }
                if (checkAlisFiyat2.Checked)
                {
                    AlisF2D = Convert.ToDouble(AlisFiyat2);
                    SQL += "AlisFiyat2='" + AlisF2D.ToString() + "',";
                }
                if (checkAlisKDV2Oran.Checked)
                {
                    AlisF2D = Convert.ToDouble(AlisFiyat2);
                    double AlisKDVOran2D = Convert.ToDouble(AlisKdv2Oran);
                    double AlisKdv2D = AlisF2D / 100 * AlisKDVOran2D;
                    AlisKDV2 = AlisKdv2D;
                    AlisKdv2Oran = "%" + AlisKdv2Oran;

                    SQL += "AlisKdv2Oran='" + AlisKdv2Oran + "',";
                    SQL += "AlisKdv2='" + AlisKDV2.ToString() + "',";
                }
                if (checkSatisFiyat1.Checked)
                {
                    SatisF1D = Convert.ToDouble(SatisFiyat1);
                    SQL += "SatisFiyat1='" + SatisF1D.ToString() + "',";
                }
                if (checkSatisKDV1Oran.Checked)
                {
                    SatisF1D = Convert.ToDouble(SatisFiyat1);
                    double SatisKDVOran1D = Convert.ToDouble(SatissKdv1Oran);
                    double SatisKdv1D = SatisF1D / 100 * SatisKDVOran1D;
                    SatisKDV1 = SatisKdv1D;
                    SatissKdv1Oran = "%" + SatissKdv1Oran;

                    SQL += "SatissKdv1Oran='" + SatissKdv1Oran + "',";
                    SQL += "SatisKdv1='" + SatisKDV1.ToString() + "',";
                }
                if (checkSatisFiyat2.Checked)
                {
                    SatisF2D = Convert.ToDouble(SatisFiyat2);
                    SQL += "SatisFiyat2='" + SatisF2D.ToString() + "',";
                }
                if (checkSatisKDV2Oran.Checked)
                {
                    SatisF2D = Convert.ToDouble(SatisFiyat2);
                    double SatisKDVOran2D = Convert.ToDouble(SatissKdv2Oran);
                    double SatisKdv2D = SatisF2D / 100 * SatisKDVOran2D;
                    SatisKDV2 = SatisKdv2D;
                    SatissKdv2Oran = "%" + SatissKdv2Oran;
                    SQL += "SatissKdv2Oran='" + SatissKdv2Oran + "',";
                    SQL += "SatisKdv2='" + SatisKDV2.ToString() + "',";
                }

                SQL += "EditUserID='" + frmAnamenu.KullaniciID + "',";
                SQL += "EditDate='" + DateTime.Now + "',";
                SQL = SQL.Substring(0, SQL.Length - 1);
                SQL += " where StokKodu='" + StokKodu + "'";
                STK.TopluStokGuncelle(SQL);
            }
            cls_MesajBox.KayitMesaji("Bilgiler güncellendi.");
            Cursor = Cursors.Default;
        }
        private void IceAktarbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                    {
                        IceAktar();
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
        private void checkStokAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStokAdi.Checked)
            {
                StokAdicombo.Enabled = true;
            }
            else
            {
                StokAdicombo.Enabled = false;
            }
        }
        private void checkIngAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIngAdi.Checked)
            {
                IngilizceAdicombo.Enabled = true;
            }
            else
            {
                IngilizceAdicombo.Enabled = false;
            }
        }
        private void checkKod1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKod1.Checked)
            {
                Kod1combo.Enabled = true;
            }
            else
            {
                Kod1combo.Enabled = false;
            }
        }
        private void checkKod2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKod2.Checked)
            {
                Kod2combo.Enabled = true;
            }
            else
            {
                Kod2combo.Enabled = false;
            }
        }
        private void checkKod3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKod3.Checked)
            {
                Kod3combo.Enabled = true;
            }
            else
            {
                Kod3combo.Enabled = false;
            }
        }
        private void checkKod4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKod4.Checked)
            {
                Kod4combo.Enabled = true;
            }
            else
            {
                Kod4combo.Enabled = false;
            }
        }
        private void checkKod5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKod5.Checked)
            {
                Kod5combo.Enabled = true;
            }
            else
            {
                Kod5combo.Enabled = false;
            }
        }
        private void checkBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBirim.Checked)
            {
                Birimcombo.Enabled = true;
            }
            else
            {
                Birimcombo.Enabled = false;
            }
        }
        private void checkBarkod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBarkod.Checked)
            {
                Barkodcombo.Enabled = true;
            }
            else
            {
                Barkodcombo.Enabled = false;
            }
        }
        private void checkAlisFiyat1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAlisFiyat1.Checked)
            {
                AlisFiyat1combo.Enabled = true;
            }
            else
            {
                AlisFiyat1combo.Enabled = false;
            }
        }
        private void checkalisKDV1Oran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkalisKDV1Oran.Checked)
            {
                AlisKDV1Orancombo.Enabled = true;
            }
            else
            {
                AlisKDV1Orancombo.Enabled = false;
            }
        }
        private void checkAlisFiyat2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAlisFiyat2.Checked)
            {
                AlisFiyat2combo.Enabled = true;
            }
            else
            {
                AlisFiyat2combo.Enabled = false;
            }
        }
        private void checkAlisKDV2Oran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAlisKDV2Oran.Checked)
            {
                AlisKDV2Orancombo.Enabled = true;
            }
            else
            {
                AlisKDV2Orancombo.Enabled = false;
            }
        }
        private void checkSatisFiyat1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSatisFiyat1.Checked)
            {
                SatisFiyat1combo.Enabled = true;
            }
            else
            {
                SatisFiyat1combo.Enabled = false;
            }
        }
        private void checkSatisKDV1Oran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSatisKDV1Oran.Checked)
            {
                SatisKDV1Orancombo.Enabled = true;
            }
            else
            {
                SatisKDV1Orancombo.Enabled = false;
            }
        }
        private void checkSatisFiyat2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSatisFiyat2.Checked)
            {
                SatisFiyat2combo.Enabled = true;
            }
            else
            {
                SatisFiyat2combo.Enabled = false;
            }
        }
        private void checkSatisKDV2Oran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSatisKDV2Oran.Checked)
            {
                SatisKDV2Orancombo.Enabled = true;
            }
            else
            {
                SatisKDV2Orancombo.Enabled = false;
            }
        }
    }
}
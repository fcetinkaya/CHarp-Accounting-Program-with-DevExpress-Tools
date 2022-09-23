using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Gelisim_Muhasebe.BankaModulu;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.FaturaModulu.Class;
using Gelisim_Muhasebe.FaturaModulu.Dizaynlar;
using Gelisim_Muhasebe.Kasa;
using Gelisim_Muhasebe.StokModulu;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.FaturaModulu.AlisIadeFaturalari
{

    public partial class frmAlisIadeFaturasi : DevExpress.XtraEditors.XtraForm
    {
        public frmAlisIadeFaturasi()
        {
            InitializeComponent();
        }

        public string _ftID, gelenFtNo;
        cls_AlisIadeFaturasi S = new cls_AlisIadeFaturasi();
        cls_Numaralar N = new cls_Numaralar();
        private bool Edit = false;
        public string StokId, CariId, BankaID, KasaID;
        public bool StokSecim = false;
        private void frmSatisFaturasi_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(frmAnamenu.SecilenFtID))
                {
                    _ftID = frmAnamenu.SecilenFtID;
                    string[] x = S.FtBilgileri_Gel(_ftID);
                    if (!string.IsNullOrEmpty(x[0]))
                    {
                        Temizle();
                        txtFtNo.Text = x[0];
                        gelenFtNo = x[0];
                        txtBelgeNumarasi.Text = x[1];
                        txtTarih.Text = x[2];
                        txtVadeTarihi.Text = x[3];
                        txtAciklama.Text = x[4];
                        comboFtTuru.Text = x[6];
                        if (x[7] == "Kasa")
                        {
                            OdemeturuCombo.SelectedIndex = 0;
                            KasaID = x[8];
                            FtKapama_EditBtn.Text = S.KasaAdi_Donder(KasaID);
                        }
                        else
                        {
                            OdemeturuCombo.SelectedIndex = 1;
                            BankaID = x[8];
                            FtKapama_EditBtn.Text = S.BankaAdi_Donder(BankaID);
                        }//
                        string[] gelenCari = S.CariKarti_Bilgileri(x[5]);
                        cariKodBtn.Text = gelenCari[0];
                        txtCariIsim.Text = gelenCari[1];
                        DataTable dtFtK = S.Gel_FaturaKalemleri(_ftID);
                        gridControl1.DataSource = dtFtK;
                        Edit = true;
                    }
                }
                else
                {
                    txtTarih.Text = DateTime.Now.ToShortDateString();
                    txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
                    txtFtNo.Text = N.GetYeniAlisIadeFtNumarasi();
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFtNo.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(txtFtNo, "Boş Geçilmez.");
                }
                else
                {
                    if (txtBelgeNumarasi.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider2.SetError(txtBelgeNumarasi, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (cariKodBtn.Text.Trim() == String.Empty)
                        {
                            dxErrorProvider3.SetError(cariKodBtn, "Cari Kodunu Seçiniz.");
                        }
                        else
                        {
                            if (txtCariIsim.Text.Trim() == String.Empty)
                            {
                                dxErrorProvider4.SetError(txtCariIsim, "Cari Kodunu Seçiniz.");
                            }
                            else
                            {
                                if (comboFtTuru.SelectedItem.ToString() == "Fatura Türü")
                                {
                                    dxErrorProvider5.SetError(comboFtTuru, "Fatura Türünü Seçiniz.");
                                }
                                else
                                {
                                    if (comboFtTuru.SelectedIndex == 1 && (OdemeturuCombo.SelectedIndex == -1 || string.IsNullOrEmpty(FtKapama_EditBtn.Text)))
                                    {
                                        cls_MesajBox.UyariMesaji("Ödeme türünü seçiniz.");
                                    }
                                    else
                                    {
                                        if (gridView1.RowCount == 0)
                                        {
                                            cls_MesajBox.UyariMesaji("Ürün ekleyin.");
                                        }
                                        else
                                        {
                                            if (Edit == false)
                                            {
                                                if (cls_MesajBox.Sor("Kayıt etmek istediğinize emin misiniz ?"))
                                                {
                                                    FtKayit();
                                                }
                                            }
                                            else
                                            {
                                                if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                                {
                                                    CariId = S.CariID_Donder(cariKodBtn.Text);
                                                    if (gelenFtNo == txtFtNo.Text)
                                                    {
                                                        FtGuncelle();
                                                    }
                                                    else
                                                    {
                                                        if (!S.FtNumarasiKontrol(txtFtNo.Text))
                                                        {
                                                            FtGuncelle();
                                                        }
                                                        else
                                                        {
                                                            cls_MesajBox.UyariMesaji("Fatura numarası kullanılıyor. Yeni numara ataması yapılmıştır.");
                                                            txtFtNo.Text = N.GetYeniStFtNumarasi();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        public void FtKayit()
        {
            int FSayi = Convert.ToInt32(txtFtNo.Text.Remove(0, 2));

            if (!S.FtNumarasiKontrol(txtFtNo.Text))
            {
                int aydiGel = Convert.ToInt32(S.faturaKayit(txtFtNo.Text, txtBelgeNumarasi.Text, cariKodBtn.Text, txtTarih.Text, txtVadeTarihi.Text, comboFtTuru.SelectedItem.ToString(), "Alış iade Faturası", 3, txtAciklama.Text, Convert.ToDouble(txtGenelToplam.Text), CariId, frmAnamenu.KullaniciID.ToString(), FSayi, DBNull.Value.ToString(), DBNull.Value.ToString()));
                if (aydiGel > 0)
                {
                    FtUrunKalemleriKayit(aydiGel.ToString());
                    S.CariHareketKayit(txtFtNo.Text, txtBelgeNumarasi.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), 0, txtAciklama.Text, txtVadeTarihi.Text, "Alış iade Faturası", "3", CariId, aydiGel.ToString(), frmAnamenu.KullaniciID.ToString());

                    if (comboFtTuru.SelectedIndex == 1)
                    {
                        S.CariHareketKayit(txtFtNo.Text, txtBelgeNumarasi.Text, txtTarih.Text, 0, Convert.ToDouble(txtGenelToplam.Text), txtAciklama.Text, txtVadeTarihi.Text, "Alış iade Faturası", "3", CariId, aydiGel.ToString(), frmAnamenu.KullaniciID.ToString());
                        if (OdemeturuCombo.SelectedIndex == 0)
                        {
                            int GeldiKID = S.KasaHareketKayit(txtFtNo.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), CariId, KasaID, frmAnamenu.KullaniciID, aydiGel);
                            S.faturaGuncelle_Odeme("Kasa", GeldiKID, aydiGel);
                        }
                        else if (OdemeturuCombo.SelectedIndex == 1)
                        {
                            int GeldiBID = S.BankaHareketKayit(txtFtNo.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), BankaID, frmAnamenu.KullaniciID, aydiGel);
                            S.faturaGuncelle_Odeme("Banka", GeldiBID, aydiGel);
                        }
                    }
                    cls_MesajBox.KayitMesaji("Kayıt edildi.");
                    this.Text = txtFtNo.Text;
                    Edit = true;
                }
            }
            else
            {
                cls_MesajBox.UyariMesaji("Fatura numarası kullanılıyor. Yeni numara ataması yapılmıştır.");
                txtFtNo.Text = N.GetYeniStFtNumarasi();
            }
        }
        public void FtGuncelle()
        {
            int FSayi = Convert.ToInt32(txtFtNo.Text.Remove(0, 2));
            if (S.faturaGuncelle(txtFtNo.Text, txtBelgeNumarasi.Text, cariKodBtn.Text, txtTarih.Text, txtVadeTarihi.Text, comboFtTuru.SelectedItem.ToString(), txtAciklama.Text, Convert.ToDouble(txtGenelToplam.Text), CariId, FSayi, frmAnamenu.KullaniciID.ToString(), _ftID))
            {
                S.stokHareketSil(_ftID);
                S.CariHareketSil(_ftID);
                S.BankaHareketSil(_ftID);
                S.KasaHareketSil(_ftID);

                FtUrunKalemleriKayit(_ftID);
                S.CariHareketKayit(txtFtNo.Text, txtBelgeNumarasi.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), 0, txtAciklama.Text, txtVadeTarihi.Text, "Alış iade Faturası", "3", CariId, _ftID, frmAnamenu.KullaniciID.ToString());

                if (comboFtTuru.SelectedIndex == 1)
                {
                    S.CariHareketKayit(txtFtNo.Text, txtBelgeNumarasi.Text, txtTarih.Text, 0, Convert.ToDouble(txtGenelToplam.Text), txtAciklama.Text, txtVadeTarihi.Text, "Alış iade Faturası", "3", CariId, _ftID, frmAnamenu.KullaniciID.ToString());
                    if (OdemeturuCombo.SelectedIndex == 0)
                    {
                        int GeldiKID = S.KasaHareketKayit(txtFtNo.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), CariId, KasaID, frmAnamenu.KullaniciID, Convert.ToInt32(_ftID));
                        S.faturaGuncelle_Odeme("Kasa", GeldiKID, Convert.ToInt32(_ftID));
                    }
                    else if (OdemeturuCombo.SelectedIndex == 1)
                    {
                        int GeldiBID = S.BankaHareketKayit(txtFtNo.Text, txtTarih.Text, Convert.ToDouble(txtGenelToplam.Text), BankaID, frmAnamenu.KullaniciID, Convert.ToInt32(_ftID));
                        S.faturaGuncelle_Odeme("Banka", GeldiBID, Convert.ToInt32(_ftID));
                    }
                }
                Edit = true;
                Text = txtFtNo.Text;
                cls_MesajBox.KayitMesaji("Kayıt güncellendi.");
            }
        }
        public void FtUrunKalemleriKayit(string gelenFtID)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string _stokKodu = gridView1.GetRowCellValue(i, "StokKodu").ToString();
                string _GelenStokID = S.Gel_StokID(_stokKodu);
                double _gelenMiktar = Convert.ToDouble(gridView1.GetRowCellValue(i, "Miktar"));
                double _gelenFiyat = Convert.ToDouble(gridView1.GetRowCellValue(i, "Fiyat"));
                double _gelenIsk1Oran = Convert.ToDouble(gridView1.GetRowCellValue(i, "Isk1"));
                double _gelenIsk2Oran = Convert.ToDouble(gridView1.GetRowCellValue(i, "Isk2"));
                double _gelenKdvOrani = Convert.ToDouble(gridView1.GetRowCellValue(i, "Kdv"));
                S.stokHareketKayit(txtFtNo.Text, txtBelgeNumarasi.Text, "C", _gelenMiktar, _gelenFiyat, _gelenIsk1Oran, _gelenIsk2Oran, _gelenKdvOrani, txtAciklama.Text, "Alış iade Faturası", txtTarih.Text, frmAnamenu.SecilenCariID, _GelenStokID, gelenFtID, frmAnamenu.KullaniciID.ToString());
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                this.Close();
            }
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            txtFtNo.Text = N.GetYeniAlisIadeFtNumarasi();
            txtBelgeNumarasi.Text = "";
            DataTable dtFtK = S.Gel_FaturaKalemleri("-1");
            gridControl1.DataSource = dtFtK;
            txtAciklama.Text = "";
            txtCariIsim.Text = "";
            cariKodBtn.Text = "";
            txtTarih.EditValue = DateTime.Now.ToShortDateString();
            txtVadeTarihi.EditValue = DateTime.Now.ToShortDateString();
            comboFtTuru.Text = "Fatura Türü";
            txtAraToplam.Text = "0.00";
            txtIskonton.Text = "0.00";
            txttoplam.Text = "0.00";
            txtKDV.Text = "0.00";
            txtGenelToplam.Text = "0.00";
            txtFtNo.Focus();
            StokSecim = false;
            FtKapama_EditBtn.Text = "";
            OdemeturuCombo.SelectedIndex = -1;
            OdemeturuCombo.SelectedIndex = -1;
            FtKapama_Label.Visible = false;
            FtKapama_EditBtn.Visible = false;
            FtKapama_Grop.Visible = false;
            frmAnamenu.SecilenCariID = "";
            frmAnamenu.SecilenCariAdi = "";
            frmAnamenu.CorbaSecilenID = "";
            frmAnamenu.SecilenFtID = "";
            Edit = false;
        }
        public void Hesapla()
        {
            double gelenMiktar = 0;
            double gelenFiyat = 0;
            double gelenToplamFiyat;
            double gelenToplam = 0;
            double gelenKdvOrani = 0;
            double gelenKdvToplam = 0;
            double gelenIsk1Oran = 0;
            double gelenIsk2Oran = 0;
            double gelenIsk1Fiyat = 0;
            double gelenIsk2Fiyat = 0;
            double hesaplananToplamFiyat = 0;
            double hesaplananAraToplamFiyat = 0;
            double hesaplananKdvToplamFiyat = 0;
            double hesaplananIsk1ToplamFiyat = 0;
            double hesaplananIsk2ToplamFiyat = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gelenFiyat = Convert.ToDouble(gridView1.GetRowCellValue(i, "Fiyat"));
                gelenMiktar = Convert.ToDouble(gridView1.GetRowCellValue(i, "Miktar"));
                gelenToplamFiyat = gelenFiyat * gelenMiktar;
                gelenIsk1Oran = Convert.ToDouble(gridView1.GetRowCellValue(i, "Isk1"));
                gelenIsk2Oran = Convert.ToDouble(gridView1.GetRowCellValue(i, "Isk2"));

                //Gridview'den Verileri Çek
                gelenToplam = Convert.ToDouble(gridView1.GetRowCellValue(i, "Toplam"));
                gelenKdvOrani = Convert.ToDouble(gridView1.GetRowCellValue(i, "Kdv"));

                //Oranları Hesapla
                gelenIsk1Fiyat = (gelenToplamFiyat / 100) * gelenIsk1Oran;
                gelenIsk2Fiyat = ((gelenToplamFiyat - gelenIsk1Fiyat) / 100) * gelenIsk2Oran;
                gelenKdvToplam = (gelenToplam / 100) * gelenKdvOrani;

                //Hesapları Fiyata Dök
                hesaplananAraToplamFiyat += gelenToplamFiyat;
                hesaplananKdvToplamFiyat += gelenKdvToplam;
                hesaplananIsk1ToplamFiyat += gelenIsk1Fiyat;
                hesaplananIsk2ToplamFiyat += gelenIsk2Fiyat;
                hesaplananToplamFiyat += gelenToplam + gelenKdvToplam;

            }
            txtAraToplam.Text = hesaplananAraToplamFiyat.ToString("0.00");
            txtIskonton.Text = (hesaplananIsk1ToplamFiyat + hesaplananIsk2ToplamFiyat).ToString("0.00");
            txttoplam.Text =
                (hesaplananAraToplamFiyat - (hesaplananIsk1ToplamFiyat + hesaplananIsk2ToplamFiyat)).ToString("0.00");
            txtKDV.Text = hesaplananKdvToplamFiyat.ToString("0.00");
            txtGenelToplam.Text = hesaplananToplamFiyat.ToString("0.00");
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Bitti", 1);

        }
        private void btnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmStokListesi SL = new frmStokListesi();
                SL.ShowDialog();
                StokId = frmAnamenu.SecilenKodID;
                if (!string.IsNullOrEmpty(StokId))
                {
                    var GeliyorBilgiler = S.Gel_StokKarti_Bilgileri(StokId);
                    gridView1.AddNewRow();
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "StokKodu", GeliyorBilgiler[0]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "StokAdi", GeliyorBilgiler[1]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Birim", GeliyorBilgiler[2]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Barkod", GeliyorBilgiler[3]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Fiyat", GeliyorBilgiler[4]);
                    double BirimFiyat = Convert.ToDouble(GeliyorBilgiler[4]);
                    double Miktar = 1;
                    double AraToplama = BirimFiyat * Miktar;
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Kdv", GeliyorBilgiler[5]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplama);
                    StokSecim = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double BirimFiyat, Miktar;
                double AraToplam, Isk1, Isk2 = 0;
                #region StokSecimIslemleri
                if (StokSecim)
                {
                    switch (e.Column.FieldName)
                    {
                        case "Miktar":
                            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("Miktar").ToString()))
                            {
                                BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                AraToplam = BirimFiyat * Miktar;
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                            }
                            else
                            {
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Miktar", 1);
                                BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                AraToplam = BirimFiyat * Miktar;
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                            }
                            break;
                        case "Fiyat":
                            BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                            Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("Fiyat").ToString()))
                            {
                                AraToplam = BirimFiyat * Miktar;
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                            }
                            else
                            {
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Fiyat", 0);
                                AraToplam = BirimFiyat * Miktar;
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                            }
                            break;
                        case "Isk1":

                            BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                            Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("Isk1").ToString()))
                            {
                                Isk1 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk1"));
                                if (Isk1 > 0)
                                {
                                    AraToplam = BirimFiyat * Miktar;
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                                else
                                {
                                    Isk2 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk2"));
                                    if (Isk2 > 0)
                                    {
                                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk1", Isk2);
                                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk2", 0);
                                        AraToplam = BirimFiyat * Miktar;
                                        AraToplam = AraToplam - (AraToplam / 100 * Isk2);
                                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                    }
                                    else
                                    {
                                        AraToplam = BirimFiyat * Miktar;
                                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                    }
                                }
                            }
                            else
                            {
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk1", 0);
                                Isk2 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk2"));
                                if (Isk2 > 0)
                                {
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk1", Isk2);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk2", 0);
                                    AraToplam = BirimFiyat * Miktar;
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk2);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                                else
                                {
                                    AraToplam = BirimFiyat * Miktar;
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                            }
                            break;
                        case "Isk2":
                            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("Isk2").ToString()))
                            {
                                Isk2 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk2"));
                                Isk1 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk1"));
                                if (Isk1 == 0.00 && Isk2 == 0.00)
                                {
                                    BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                    Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                    AraToplam = BirimFiyat * Miktar;
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                    break;
                                }
                                else if (Isk1 > 0 && Isk2 == 0.00)
                                {
                                    BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                    Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                    AraToplam = BirimFiyat * Miktar;
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                                else if (Isk1 > 0.00 && Isk2 > 0)
                                {
                                    BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                    Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                    AraToplam = BirimFiyat * Miktar;
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk2);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                                else
                                {
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk1", Isk2);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk2", 0);
                                    cls_MesajBox.UyariMesaji("Öncelikle iskonto 1 kutusunu kullanınız.");
                                }
                            }
                            else
                            {
                                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk2", 0);
                                Isk1 = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Isk1"));
                                if (Isk1 > 0)
                                {

                                    BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                    Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                    AraToplam = BirimFiyat * Miktar;
                                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                                else
                                {
                                    BirimFiyat = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Fiyat"));
                                    Miktar = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Miktar"));
                                    AraToplam = BirimFiyat * Miktar;
                                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Toplam", AraToplam);
                                }
                            }
                            break;
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Miktar", 1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk1", 0);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Isk2", 0);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "IsActive", false);

        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                StokSecim = false;
                Hesapla();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "IsActive", true);
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void SatisFtListesiSecBtn_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlisIadeFaturasiListesi SF = new frmAlisIadeFaturasiListesi();
                SF.ShowDialog();
                _ftID = frmAnamenu.SecilenFtID;
                string[] x = S.FtBilgileri_Gel(_ftID);
                if (!string.IsNullOrEmpty(x[0]))
                {
                    Temizle();
                    txtFtNo.Text = x[0];
                    gelenFtNo = x[0];
                    txtBelgeNumarasi.Text = x[1];
                    txtTarih.Text = x[2];
                    txtVadeTarihi.Text = x[3];
                    txtAciklama.Text = x[4];
                    comboFtTuru.Text = x[6];
                    if (x[7] == "Kasa")
                    {
                        OdemeturuCombo.SelectedIndex = 0;
                        KasaID = x[8];
                        FtKapama_EditBtn.Text = S.KasaAdi_Donder(KasaID);
                    }
                    else
                    {
                        OdemeturuCombo.SelectedIndex = 1;
                        BankaID = x[8];
                        FtKapama_EditBtn.Text = S.BankaAdi_Donder(BankaID);
                    }//
                    string[] gelenCari = S.CariKarti_Bilgileri(x[5]);
                    cariKodBtn.Text = gelenCari[0];
                    txtCariIsim.Text = gelenCari[1];
                    DataTable dtFtK = S.Gel_FaturaKalemleri(_ftID);
                    gridControl1.DataSource = dtFtK;
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                bool Bitti_Ade = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsActive"));
                if (Bitti_Ade)
                {
                    e.Cancel = true;
                }
            }
        }
        private void comboFtTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFtTuru.SelectedIndex == 0)
            {
                FtKapama_Grop.Visible = false;
            }
            else if (comboFtTuru.SelectedIndex == 1)
            {
                FtKapama_Grop.Visible = true;
            }
        }
        private void OdemeturuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OdemeturuCombo.SelectedIndex == 0)
            {
                FtKapama_Label.Text = "Kasa Seçimi";
                FtKapama_EditBtn.Text = "";
                FtKapama_Label.Visible = true;
                FtKapama_EditBtn.Visible = true;
            }
            else if (OdemeturuCombo.SelectedIndex == 1)
            {
                FtKapama_Label.Text = "Banka Seçimi";
                FtKapama_EditBtn.Text = "";
                FtKapama_Label.Visible = true;
                FtKapama_EditBtn.Visible = true;
            }
        }
        private void frmSatisFaturasi_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Temizle();
        }
        private void FtSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Faturayı silmek istediğinize emin misiniz ?"))
                {
                    if (S.FaturaSil(_ftID))
                    {
                        S.stokHareketSil(_ftID);
                        S.CariHareketSil(_ftID);
                        S.BankaHareketSil(_ftID);
                        S.KasaHareketSil(_ftID);
                        cls_MesajBox.KayitMesaji("Fatura başarı ile silindi.");
                        Temizle();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void YazdirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Report_SatisIadeFaturasi StFt = new Report_SatisIadeFaturasi();
                StFt.PrintingSystem.ShowMarginsWarning = false;
                StFt.DataSource = S.FaturaYazdir(_ftID);
                StFt.ShowPreview();
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void cariKodBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmCariListesi CL = new frmCariListesi();
                CL.ShowDialog();
                CariId = frmAnamenu.SecilenCariID;
                if (!string.IsNullOrEmpty(CariId))
                {
                    string[] gelenCari = S.CariKarti_Bilgileri(CariId);
                    cariKodBtn.Text = gelenCari[0];
                    txtCariIsim.Text = gelenCari[1];
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void FtKapama_EditBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (OdemeturuCombo.SelectedIndex == 0)
                {
                    FtKapama_EditBtn.Text = "";
                    frmAnamenu.CorbaSecilenID = "0";
                    frmKasaListesi KL = new frmKasaListesi();
                    KL.ShowDialog();
                    KasaID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(KasaID))
                    {
                        string[] gelenCari = S.KasaKarti_Bilgileri(KasaID);
                        FtKapama_EditBtn.Text = gelenCari[0];
                    }
                }
                else if (OdemeturuCombo.SelectedIndex == 1)
                {
                    FtKapama_EditBtn.Text = "";
                    frmAnamenu.CorbaSecilenID = "0";
                    frmBankaListesi CL = new frmBankaListesi();
                    CL.ShowDialog();
                    BankaID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(BankaID))
                    {
                        string[] gelenCari = S.BankaKarti_Bilgileri(BankaID);
                        FtKapama_EditBtn.Text = gelenCari[0];
                    }
                }
                else
                {
                    cls_MesajBox.UyariMesaji("Ödeme türünü seçiniz.");
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
    }
}
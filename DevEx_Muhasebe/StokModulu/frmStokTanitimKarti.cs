using System;
using System.Windows.Forms;
using Gelisim_Muhasebe.StokModulu;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe
{
    public partial class frmStokTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        private cls_StokTanitimKarti SK = new cls_StokTanitimKarti();
        public static string StokID;
        public static string StokAdi;
        public static bool Edit = false;
        public frmStokTanitimKarti()
        {
            InitializeComponent();
        }
        public string SecilenKod1 = DBNull.Value.ToString();
        public string SecilenKod2 = DBNull.Value.ToString();
        public string SecilenKod3 = DBNull.Value.ToString();
        public string SecilenKod4 = DBNull.Value.ToString();
        public string SecilenKod5 = DBNull.Value.ToString();
        private void BtnKodSec1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod1 = new frmStokKod1();
            frmKod1.ShowDialog();
            SecilenKod1 = frmAnamenu.SecilenKodID;
            BtnKodSec1.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void BtnKodSec2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod2 = new frmStokKod2();
            frmKod2.ShowDialog();
            SecilenKod2 = frmAnamenu.SecilenKodID;
            BtnKodSec2.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void BtnKodSec3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod3 = new frmStokKod3();
            frmKod3.ShowDialog();
            SecilenKod3 = frmAnamenu.SecilenKodID;
            BtnKodSec3.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void BtnKodSec4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod4 = new frmStokKod4();
            frmKod4.ShowDialog();
            SecilenKod4 = frmAnamenu.SecilenKodID;
            BtnKodSec4.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void BtnKodSec5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmKod5 = new frmStokKod5();
            frmKod5.ShowDialog();
            SecilenKod5 = frmAnamenu.SecilenKodID;
            BtnKodSec5.Text = frmAnamenu.SecilenKodAdi;
            frmAnamenu.SecilenKodID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
        }
        private void frmStokTanitimKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void Kaptbtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void KaydetBtn_Click(object sender, EventArgs e){
            try
            {
                if (StokKoduBox.Text.Trim() == String.Empty)
                {
                    dxErrorProvider1.SetError(StokKoduBox, "Boş Geçilmez.");
                }
                else
                {
                    if (StokAdiBox.Text.Trim() == String.Empty)
                    {
                        dxErrorProvider2.SetError(StokAdiBox, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (BirimCombo.SelectedItem.ToString() == "Birim Seçiniz")
                        {
                            dxErrorProvider3.SetError(BirimCombo, "Birim Seçiniz.");
                        }
                        else
                        {
                            if (comboAlisKdv1.Text == "Oran" && alisfiyatBox.Text != "0,00")
                            {
                                MessageBox.Show("Alış Fiyat 1 için KDV oranını seçiniz.");
                            }
                            else
                            {
                                if (comboAlisKdv2.Text == "Oran" && AlisFiyat2Box.Text != "0,00")
                                {
                                    MessageBox.Show("Alış Fiyat 2 için KDV oranını seçiniz.");
                                }
                                else
                                {
                                    if (comboSatisKdv1.Text == "Oran" && SatisFiyat1Box.Text != "0,00")
                                    {
                                        MessageBox.Show("Satış Fiyat 1 için KDV oranını seçiniz.");
                                    }
                                    else
                                    {
                                        if (comboSatisKdv2.Text == "Oran" && SatisFiyat2Box.Text != "0,00")
                                        {
                                            MessageBox.Show("Satış Fiyat 2 için KDV oranını seçiniz.");
                                        }
                                        else
                                        {
                                            if (Edit)
                                            {
                                                if (cls_MesajBox.Sor("Güncellemek istediğinize emin misiniz ?"))
                                                {
                                                    if (SK.StokGuncelle(StokKoduBox.Text, StokAdiBox.Text, IngilizceAdiBox.Text,
                                                        SecilenKod1, SecilenKod2, SecilenKod3, SecilenKod4, SecilenKod5, BirimCombo.Text,
                                                        Barkodbox.Text, alisfiyatBox.Text, alisKDVBox.Text, comboAlisKdv1.Text,
                                                        AlisFiyat2Box.Text, AlisKdv2Box.Text, comboAlisKdv2.Text, SatisFiyat1Box.Text,
                                                        SatisKdvBox.Text, comboSatisKdv1.SelectedText, SatisFiyat2Box.Text, SatisKDVBox2.Text,
                                                        comboSatisKdv2.SelectedText, frmAnamenu.KullaniciID, StokID))
                                                    {
                                                        cls_MesajBox.GuncelleMesaji("Stok kartı güncellenmiştir.");
                                                        Close();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (cls_MesajBox.Sor("Kayıt etmek istediğinize emin misiniz ?"))
                                                {
                                                    if (SK.StokKodKayit(StokKoduBox.Text, StokAdiBox.Text, IngilizceAdiBox.Text,
                                                        SecilenKod1, SecilenKod2, SecilenKod3, SecilenKod4, SecilenKod5, BirimCombo.Text,
                                                        Barkodbox.Text, alisfiyatBox.Text, alisKDVBox.Text, comboAlisKdv1.Text,
                                                        AlisFiyat2Box.Text, AlisKdv2Box.Text, comboAlisKdv2.Text, SatisFiyat1Box.Text,
                                                        SatisKdvBox.Text, comboSatisKdv1.Text, SatisFiyat2Box.Text, SatisKDVBox2.Text,
                                                        comboSatisKdv2.Text, frmAnamenu.KullaniciID))
                                                    {
                                                        cls_MesajBox.GuncelleMesaji("Stok kartı kayıt edildi.");
                                                        Close();
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
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            frmAnamenu.CorbaSecilenID = string.Empty;
            frmAnamenu.SecilenKodAdi = string.Empty;
            frmAnamenu.SecilenKodID = string.Empty;
            StokID = string.Empty;
            StokAdi = string.Empty;
            IngilizceAdiBox.Text = string.Empty;
            StokAdiBox.Text = string.Empty;
            StokKoduBox.Text = string.Empty;
            BtnKodSec1.Text = string.Empty;
            BtnKodSec2.Text = string.Empty;
            BtnKodSec3.Text = string.Empty;
            BtnKodSec4.Text = string.Empty;
            BtnKodSec5.Text = string.Empty;
            BirimCombo.Text = "Birim Seçiniz";
            Barkodbox.Text = string.Empty;
            alisfiyatBox.EditValue = "0";
            alisKDVBox.EditValue = "0";
            AlisFiyat2Box.EditValue = "0";
            AlisKdv2Box.EditValue = "0";
            SatisFiyat1Box.EditValue = "0";
            SatisKdvBox.EditValue = "0";
            SatisFiyat2Box.EditValue = "0";
            SatisKDVBox2.EditValue = "0";
            comboAlisKdv1.Text = "Oran";
            comboAlisKdv2.Text = "Oran";
            comboSatisKdv1.Text = "Oran";
            comboSatisKdv2.Text = "Oran";
            Edit = false;
        }
        private void StokListebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var SL = new frmStokListesi();
                SL.ShowDialog();
                StokID = frmAnamenu.SecilenKodID;
                StokAdi = frmAnamenu.SecilenKodAdi;
                if (!string.IsNullOrEmpty(StokID) && !string.IsNullOrEmpty(StokAdi))
                {
                    var GeliyorBilgiler = cls_frmStokListesi.Gel_StokKarti_Bilgileri(StokID);
                    StokKoduBox.Text = GeliyorBilgiler[0];
                    StokAdiBox.Text = GeliyorBilgiler[1];
                    SecilenKod1 = GeliyorBilgiler[2];
                    BtnKodSec1.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod1, "Muhasebe_TBL_StokKodBir", "Kod1", "Kod1ID");
                    SecilenKod2 = GeliyorBilgiler[3];
                    BtnKodSec2.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod2, "Muhasebe_TBL_StokKodIki", "Kod2", "Kod2ID");
                    SecilenKod3 = GeliyorBilgiler[4];
                    BtnKodSec3.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod3, "Muhasebe_TBL_StokKodUc", "Kod3", "Kod3ID");
                    SecilenKod4 = GeliyorBilgiler[5];
                    BtnKodSec4.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod4, "Muhasebe_TBL_StokKodDort", "Kod4", "Kod4ID");
                    SecilenKod5 = GeliyorBilgiler[6];
                    BtnKodSec5.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod5, "Muhasebe_TBL_StokKodBes", "Kod5", "Kod5ID");
                    BirimCombo.Text = GeliyorBilgiler[7];
                    Barkodbox.Text = GeliyorBilgiler[8];
                    alisfiyatBox.Text = GeliyorBilgiler[9];
                    alisKDVBox.Text = GeliyorBilgiler[10];
                    AlisFiyat2Box.Text = GeliyorBilgiler[11];
                    AlisKdv2Box.Text = GeliyorBilgiler[12];
                    SatisFiyat1Box.Text = GeliyorBilgiler[13];
                    SatisKdvBox.Text = GeliyorBilgiler[14];
                    SatisFiyat2Box.Text = GeliyorBilgiler[15];
                    SatisKDVBox2.Text = GeliyorBilgiler[16];
                    IngilizceAdiBox.Text = GeliyorBilgiler[18];
                    comboAlisKdv1.Text = GeliyorBilgiler[19];
                    comboAlisKdv2.Text = GeliyorBilgiler[20];
                    comboSatisKdv1.Text = GeliyorBilgiler[21];
                    comboSatisKdv2.Text = GeliyorBilgiler[22];
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void SilBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Stok kartını silmek istediğine emin misiniz ?"))
                {
                    if (SK.StokKullanimdami(StokKoduBox.Text))
                    {
                        cls_MesajBox.SilinemezMesaji("Stok kartı kullanımdadır.", "Stok Kartı Silinemez");
                    }
                    else
                    {
                        if (SK.StokKullanimdanKaldir(frmAnamenu.KullaniciID, StokID))
                        {
                            cls_MesajBox.SilmeMesaji("Stok kartı silinmiştir.");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void comboAlisKdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alisfiyatBox.Text != "0")
            {
                double Oran = Convert.ToDouble(comboAlisKdv1.Text.Remove(0, 1));
                double alisFiyati = Convert.ToDouble(alisfiyatBox.Text);
                alisKDVBox.Text = (alisFiyati / 100 * Oran).ToString();
            }
        }
        private void comboAlisKdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlisFiyat2Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboAlisKdv2.Text.Remove(0, 1));
                double AlisFiyati = Convert.ToDouble(AlisFiyat2Box.Text);
                AlisKdv2Box.Text = (AlisFiyati / 100 * Oran).ToString();
            }
        }
        private void comboSatisKdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SatisFiyat1Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboSatisKdv1.Text.Remove(0, 1));
                double SatisFiyati = Convert.ToDouble(SatisFiyat1Box.Text);
                SatisKdvBox.Text = (SatisFiyati / 100 * Oran).ToString();
            }
        }
        private void comboSatisKdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SatisFiyat2Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboSatisKdv2.Text.Remove(0, 1));
                double SatisFiyati = Convert.ToDouble(SatisFiyat2Box.Text);
                SatisKDVBox2.Text = (SatisFiyati / 100 * Oran).ToString();
            }
        }
        private void alisfiyatBox_EditValueChanged(object sender, EventArgs e)
        {
            if (comboAlisKdv1.Text != "Oran" && alisfiyatBox.Text != "0")
            {
                double Oran = Convert.ToDouble(comboAlisKdv1.Text.Remove(0, 1));
                string gelenFiyat = alisfiyatBox.Text.Substring(0, alisfiyatBox.Text.Length - 3);
                double alisFiyati = Convert.ToDouble(gelenFiyat);
                alisKDVBox.Text = (alisFiyati / 100 * Oran).ToString();
            }
        }
        private void AlisFiyat2Box_EditValueChanged(object sender, EventArgs e)
        {
            if (comboAlisKdv2.Text != "Oran" && AlisFiyat2Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboAlisKdv2.Text.Remove(0, 1));
                string gelenFiyat = AlisFiyat2Box.Text.Substring(0, AlisFiyat2Box.Text.Length - 3);
                double alisFiyati = Convert.ToDouble(gelenFiyat);
                AlisKdv2Box.Text = (alisFiyati / 100 * Oran).ToString();
            }
        }
        private void SatisFiyat1Box_EditValueChanged(object sender, EventArgs e)
        {
            if (comboSatisKdv1.Text != "Oran" && SatisFiyat1Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboSatisKdv1.Text.Remove(0, 1));
                string gelenFiyat = SatisFiyat1Box.Text.Substring(0, SatisFiyat1Box.Text.Length - 3);
                double alisFiyati = Convert.ToDouble(gelenFiyat);
                SatisKdvBox.Text = (alisFiyati / 100 * Oran).ToString();
            }
        }
        private void SatisFiyat2Box_EditValueChanged(object sender, EventArgs e)
        {
            if (comboSatisKdv2.Text != "Oran" && SatisFiyat2Box.Text != "0")
            {
                double Oran = Convert.ToDouble(comboSatisKdv2.Text.Remove(0, 1));
                string gelenFiyat = SatisFiyat2Box.Text.Substring(0, SatisFiyat2Box.Text.Length - 3);
                double alisFiyati = Convert.ToDouble(gelenFiyat);
                SatisKDVBox2.Text = (alisFiyati / 100 * Oran).ToString();
            }
        }
        private void frmStokTanitimKarti_Load(object sender, EventArgs e)
        {
            try
            {
                StokID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(StokID))
                {
                    var GeliyorBilgiler = cls_frmStokListesi.Gel_StokKarti_Bilgileri(StokID);
                    StokKoduBox.Text = GeliyorBilgiler[0];
                    StokAdiBox.Text = GeliyorBilgiler[1];
                    SecilenKod1 = GeliyorBilgiler[2];
                    BtnKodSec1.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod1, "Muhasebe_TBL_StokKodBir", "Kod1", "Kod1ID");
                    SecilenKod2 = GeliyorBilgiler[3];
                    BtnKodSec2.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod2, "Muhasebe_TBL_StokKodIki", "Kod2", "Kod2ID");
                    SecilenKod3 = GeliyorBilgiler[4];
                    BtnKodSec3.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod3, "Muhasebe_TBL_StokKodUc", "Kod3", "Kod3ID");
                    SecilenKod4 = GeliyorBilgiler[5];
                    BtnKodSec4.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod4, "Muhasebe_TBL_StokKodDort", "Kod4", "Kod4ID");
                    SecilenKod5 = GeliyorBilgiler[6];
                    BtnKodSec5.Text = cls_frmStokListesi.StokKodBilgileri(SecilenKod5, "Muhasebe_TBL_StokKodBes", "Kod5", "Kod5ID");
                    BirimCombo.Text = GeliyorBilgiler[7];
                    Barkodbox.Text = GeliyorBilgiler[8];
                    alisfiyatBox.Text = GeliyorBilgiler[9];
                    alisKDVBox.Text = GeliyorBilgiler[10];
                    AlisFiyat2Box.Text = GeliyorBilgiler[11];
                    AlisKdv2Box.Text = GeliyorBilgiler[12];
                    SatisFiyat1Box.Text = GeliyorBilgiler[13];
                    SatisKdvBox.Text = GeliyorBilgiler[14];
                    SatisFiyat2Box.Text = GeliyorBilgiler[15];
                    SatisKDVBox2.Text = GeliyorBilgiler[16];
                    IngilizceAdiBox.Text = GeliyorBilgiler[18];
                    comboAlisKdv1.Text = GeliyorBilgiler[19];
                    comboAlisKdv2.Text = GeliyorBilgiler[20];
                    comboSatisKdv1.Text = GeliyorBilgiler[21];
                    comboSatisKdv2.Text = GeliyorBilgiler[22];
                    Edit = true;
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void frmStokTanitimKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
    }
}

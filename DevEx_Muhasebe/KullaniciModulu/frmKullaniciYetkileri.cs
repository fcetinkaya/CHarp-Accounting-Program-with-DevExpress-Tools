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
using Gelisim_Muhasebe.KullaniciModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe.KullaniciModulu
{
    public partial class frmKullaniciYetkileri : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciYetkileri()
        {
            InitializeComponent();
        }
        cls_frmKullaniciYetkileri KY = new cls_frmKullaniciYetkileri();
        public string KullaniciID = "";
        private void btnKullaniciSec_Click(object sender, EventArgs e)
        {
            try
            {
                Temizle();
                frmKullaniciListesi KL = new frmKullaniciListesi();
                KL.ShowDialog();
                KullaniciID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KullaniciID))
                {
                    string[] GelDi = KY.Gel_KullaniciKarti_Bilgileri(KullaniciID);
                    KullaniciID = GelDi[0];
                    AdiBox.Text = GelDi[1];
                    SoyadiBox.Text = GelDi[2];
                    if (KY.KullaniciYetkisiVarmi(KullaniciID))
                    {
                        gridControl1.DataSource = KY.Kullanici_Yetkileri(KullaniciID);
                    }
                    else
                    {
                        gridControl1.DataSource = KY.Gel_TumYetkiler();
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        public void Kullanici_YetkileriKaydet(string _KulID)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string YetkiID_ = gridView1.GetRowCellValue(i, "YetkiID").ToString();
                bool Durum_ = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Izin"));
                KY.KullaniciIzinEkle(KullaniciID, YetkiID_, Durum_, frmAnamenu.KullaniciID);
            }
        }
        private void frmKullaniciYetkileri_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAnamenu.CorbaSecilenID))
            {
                try
                {
                    Temizle();
                    frmKullaniciListesi KL = new frmKullaniciListesi();
                    KL.ShowDialog();
                    KullaniciID = frmAnamenu.CorbaSecilenID;
                    if (!string.IsNullOrEmpty(KullaniciID))
                    {
                        string[] GelDi = KY.Gel_KullaniciKarti_Bilgileri(KullaniciID);
                        KullaniciID = GelDi[0];
                        AdiBox.Text = GelDi[1];
                        SoyadiBox.Text = GelDi[2];
                        if (KY.KullaniciYetkisiVarmi(KullaniciID))
                        {
                            gridControl1.DataSource = KY.Kullanici_Yetkileri(KullaniciID);
                        }
                        else
                        {
                            gridControl1.DataSource = KY.Gel_TumYetkiler();
                        }
                    }
                }
                catch (Exception ex)
                {
                    cls_MesajBox.HataMesaji(ex);
                }
            }
        }
        private void barKullaniciSecBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Temizle();
                frmKullaniciListesi KL = new frmKullaniciListesi();
                KL.ShowDialog();
                KullaniciID = frmAnamenu.CorbaSecilenID;
                if (!string.IsNullOrEmpty(KullaniciID))
                {
                    string[] GelDi = KY.Gel_KullaniciKarti_Bilgileri(KullaniciID);
                    KullaniciID = GelDi[0];
                    AdiBox.Text = GelDi[1];
                    SoyadiBox.Text = GelDi[2];
                    if (KY.KullaniciYetkisiVarmi(KullaniciID))
                    {
                        gridControl1.DataSource = KY.Kullanici_Yetkileri(KullaniciID);
                    }
                    else
                    {
                        gridControl1.DataSource = KY.Gel_TumYetkiler();
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void barKaydetBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    if (cls_MesajBox.Sor("Kaydetmek isteğinize emin misiniz ?"))
                    {
                        KY.IzinleriSil(KullaniciID);
                        Kullanici_YetkileriKaydet(KullaniciID);
                        cls_MesajBox.KayitMesaji("Kullanıcı yetkileri kayıt edilmiştir.");
                    }
                }
                else
                {
                    cls_MesajBox.UyariMesaji("Kullanıcı seçin ve yetkileri onaylayın.");
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void barKapatbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        public void Temizle()
        {
            KullaniciID = string.Empty;
            AdiBox.Text = string.Empty;
            SoyadiBox.Text = string.Empty;
            frmAnamenu.CorbaSecilenID = string.Empty;
            gridControl1.DataSource = null;
        }
        private void frmKullaniciYetkileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
        }
        public void TopluYetkilendirme_Ayalari(bool Durum)
        {
             for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(i, "Izin", Durum);
                }
            }
        private void barYetkileriVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
               TopluYetkilendirme_Ayalari(true);
            }
            else
            {
                cls_MesajBox.UyariMesaji("Kullanıcı seçin ve yetkileri onaylayın.");
            }
        }
        private void barYetkileriKaldir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                TopluYetkilendirme_Ayalari(false);
            }
            else
            {
                cls_MesajBox.UyariMesaji("Kullanıcı seçin ve yetkileri onaylayın.");
            }
        }
    }
}
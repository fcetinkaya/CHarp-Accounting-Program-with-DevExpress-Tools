using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Gelisim_Muhasebe._Class;
using Gelisim_Muhasebe.Tools;
using System.Drawing;

namespace Gelisim_Muhasebe.StokModulu
{
    public partial class frmStokKod3 : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKod3()
        {
            InitializeComponent();
        }
        cls_StokKod3 StokKod = new cls_StokKod3();
        public bool Edit = false;
        public int KullaniciID = 0;
        private void frmStokKod3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        public void GelBilgiler()
        {
            DataTable dt = StokKod.GelBilgiler();
            gridControl1.DataSource = dt;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmAnamenu.SecilenKodAdi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3").ToString();
            frmAnamenu.SecilenKodID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3ID").ToString();
            Close();
        }
        private void frmStokKod3_Load(object sender, EventArgs e)
        {
            GelBilgiler();
            KullaniciID = frmAnamenu.KullaniciID;
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Edit = false;
            Aciklamabox.Text = string.Empty;
            KodBox.Text = string.Empty;
        }
        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string SecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3ID").ToString();
                if (StokKod.StokKodGuncelleme(KodBox.Text, Aciklamabox.Text, KullaniciID, SecilenID))
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    Edit = false;
                    Aciklamabox.Text = string.Empty;
                    KodBox.Text = string.Empty;
                    GelBilgiler();
                }
            }
            else
            {
                if (StokKod.StokKodKayit(KodBox.Text, Aciklamabox.Text, KullaniciID))
                {
                    MessageBox.Show("Kayıt Eklendi");
                    Edit = false;
                    Aciklamabox.Text = string.Empty;
                    KodBox.Text = string.Empty;
                    GelBilgiler();
                }
            }
        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
            {
                Close();
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = true;
            Aciklamabox.Text = string.Empty;
            KodBox.Text = string.Empty;
            KodBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3").ToString();
            Aciklamabox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3Aciklama").ToString();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek İstediğinize Emin misiniz ?"))
                {
                    string SecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod3ID").ToString();
                    if (StokKod.StokKodKullanimdami(SecilenID) == true)
                    {
                        MessageBox.Show("Silmek istediğiniz kayıt kullanılıyor.", "Silinemez", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        if (StokKod.StokKodSil(SecilenID))
                        {
                            MessageBox.Show("Kayıt Silindi.");
                            Edit = false;
                            Aciklamabox.Text = string.Empty;
                            KodBox.Text = string.Empty;
                            GelBilgiler();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");
            }
        }
        private int curX;
        private int curY;
        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                curX = Cursor.Position.X;
                curY = Cursor.Position.Y;
                SagMenu.ShowPopup(new Point(curX, curY));
            }
        }

        private void frmStokKod3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Edit = false;
            Aciklamabox.Text = string.Empty;
            KodBox.Text = string.Empty;
        }
    }
}
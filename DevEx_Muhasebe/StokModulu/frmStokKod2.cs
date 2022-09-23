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
    public partial class frmStokKod2 : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKod2()
        {
            InitializeComponent();
        }
        public bool Edit = false;
        public int KullaniciID = 0;
        cls_StokKod2 StokKod = new cls_StokKod2();
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmAnamenu.SecilenKodAdi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2").ToString();
            frmAnamenu.SecilenKodID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2ID").ToString();
            this.Close();
        }
        private void frmStokKod2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (cls_MesajBox.Sor("Çıkmak istediğinize emin misiniz ?"))
                {
                    Close();
                }
            }
        }
        private void YeniBtn_Click(object sender, EventArgs e)
        {
            Edit = false;
            AciklamaBox.Text = string.Empty;
            KodBox.Text = string.Empty;
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string SecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2ID").ToString();
                if (StokKod.StokKodGuncelleme(KodBox.Text, AciklamaBox.Text, KullaniciID, SecilenID) == true)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    Edit = false;
                    AciklamaBox.Text = string.Empty;
                    KodBox.Text = string.Empty;
                    GelBilgiler();
                }
            }
            else
            {
                if (StokKod.StokKodKayit(KodBox.Text, AciklamaBox.Text, KullaniciID))
                {
                    MessageBox.Show("Kayıt Eklendi");
                    Edit = false;
                    AciklamaBox.Text = string.Empty;
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
        public void GelBilgiler()
        {
            DataTable dt = StokKod.GelBilgiler();
            gridControl1.DataSource = dt;
        }
        private void frmStokKod2_Load(object sender, EventArgs e)
        {
            GelBilgiler();
            KullaniciID = frmAnamenu.KullaniciID;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit = true;
            AciklamaBox.Text = string.Empty;
            KodBox.Text = string.Empty;
            KodBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2").ToString();
            AciklamaBox.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2Aciklama").ToString();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cls_MesajBox.Sor("Silmek İstediğinize Emin misiniz ?"))
                {
                    string SecilenID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Kod2ID").ToString();
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
                            AciklamaBox.Text = string.Empty;
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
        private void frmStokKod2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Edit = false;
            AciklamaBox.Text = string.Empty;
            KodBox.Text = string.Empty;
        }
    }
}
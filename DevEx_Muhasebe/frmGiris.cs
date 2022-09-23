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
using DevExpress.XtraLayout.Converter;
using Gelisim_Muhasebe.KullaniciModulu.Class;
using Gelisim_Muhasebe.Tools;

namespace Gelisim_Muhasebe
{
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void frmGiris_Load(object sender, EventArgs e)
        {
            if (Gelisim_Muhasebe.Properties.Settings.Default.Animsa)
            {
                KulAdiBox.Text = Gelisim_Muhasebe.Properties.Settings.Default.KullaniciAdi;
                Sifrebox.Text = Gelisim_Muhasebe.Properties.Settings.Default.Parola;
            }
        }
        private void frmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                GirisIslemleri();
            }
        }
        private void GirisBtn_Click(object sender, EventArgs e)
        {
            GirisIslemleri();
        }
        private void GirisIslemleri()
        {
            try
            {
                if (string.IsNullOrEmpty(KulAdiBox.Text) && string.IsNullOrEmpty(Sifrebox.Text))
                {
                    cls_MesajBox.UyariMesaji("Kullanıcı adı ve şifre yazınız.");
                    frmAnamenu.Giris = 2;
                }
                else
                {
                    string[] Geldi = cls_frmKullanici.Giris(KulAdiBox.Text, Sifrebox.Text);
                    if (!string.IsNullOrEmpty(Geldi[0]))
                    {
                        if (SifreCheck.Checked)
                        {
                            Properties.Settings.Default.Animsa = true;
                            Properties.Settings.Default.KullaniciAdi = KulAdiBox.Text;
                            Properties.Settings.Default.Parola = Sifrebox.Text;
                            Properties.Settings.Default.Save();
                        }
                        frmAnamenu.KullaniciID = Convert.ToInt32(Geldi[0]);
                        frmAnamenu.AdSoyad = Geldi[1].ToString();
                        frmAnamenu.Admin = Convert.ToBoolean(Geldi[2]);
                        frmAnamenu.Giris = 1;
                        Close();
                    }
                    else
                    {
                        cls_MesajBox.UyariMesaji("Kullanıcı adı yada şifre hatalı !!");
                        frmAnamenu.Giris = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                cls_MesajBox.HataMesaji(ex);
            }
        }
        private void ServerBtn_Click(object sender, EventArgs e)
        {
            frmAnamenu.Server = true;
            //frmServer S = new frmServer();
            //S.Show();
        }
    }
}
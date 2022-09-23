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
using Gelisim_Muhasebe.Tools;
using System.Data.SqlClient;

namespace Gelisim_Muhasebe
{
    public partial class frmServer : DevExpress.XtraEditors.XtraForm
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IpAdresTxt.Text))
                {
                    dxErrorProvider1.SetError(IpAdresTxt, "Boş Geçilmez.");
                }
                else
                {
                    if (string.IsNullOrEmpty(VeritabaniTxt.Text))
                    {
                        dxErrorProvider2.SetError(VeritabaniTxt, "Boş Geçilmez.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(KullaniciAdiTxt.Text))
                        {
                            dxErrorProvider3.SetError(KullaniciAdiTxt, "Boş Geçilmez.");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(SifreTxt.Text))
                            {
                                dxErrorProvider4.SetError(SifreTxt, "Boş Geçilmez.");
                            }
                            else
                            {
                                try
                                {
                                    Gelisim_Muhasebe.Properties.Settings.Default.ServerIPAdresi = IpAdresTxt.Text;
                                    Gelisim_Muhasebe.Properties.Settings.Default.Veritabani = VeritabaniTxt.Text;
                                    Gelisim_Muhasebe.Properties.Settings.Default.DBKullaniciAdi = KullaniciAdiTxt.Text;
                                    Gelisim_Muhasebe.Properties.Settings.Default.DBSifre = SifreTxt.Text;
                                    Gelisim_Muhasebe.Properties.Settings.Default.Save();
                                    SqlConnection con = new SqlConnection(Yol.ECon);
                                    if (con.State == ConnectionState.Closed)
                                    {
                                        cls_MesajBox.KayitMesaji("Bilgiler başarı ile güncellendi.");
                                        Close();
                                    }
                                }
                                catch (Exception)
                                {
                                    cls_MesajBox.UyariMesaji("Bağlantı kurulamadı. Bilgileri kontrol ediniz.");
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
        private void Kaptbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
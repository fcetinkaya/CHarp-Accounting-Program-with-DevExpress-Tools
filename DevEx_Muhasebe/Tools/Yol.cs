using System;

namespace Gelisim_Muhasebe.Tools
{
    internal class Yol : IDisposable
    {
        //Data Source=94.73.147.8;Initial Catalog=DB131229225710;User ID=USR131229225710;Password=PSS!I7A1F5%";
        public static string ECon = Yolcu();


        public static string Yolcu()
        {
            string YolPlus = "";
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ServerIPAdresi))
            {
                YolPlus = "Data Source=" + Gelisim_Muhasebe.Properties.Settings.Default.ServerIPAdresi +
                                     ";Initial Catalog=" + Gelisim_Muhasebe.Properties.Settings.Default.Veritabani +
                                     ";User ID=" + Gelisim_Muhasebe.Properties.Settings.Default.DBKullaniciAdi +
                                     ";Password=" + Gelisim_Muhasebe.Properties.Settings.Default.DBSifre + "";
            }
            else
            {
                YolPlus = "Data Source=.;Initial Catalog=Muhasebe_DB; Integrated Security=true;";
            }
            return YolPlus;}

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
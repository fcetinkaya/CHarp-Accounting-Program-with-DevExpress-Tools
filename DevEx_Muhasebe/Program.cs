using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gelisim_Muhasebe.Cariler;
using Gelisim_Muhasebe.FaturaModulu.SatisFaturalari;
using Gelisim_Muhasebe.StokModulu;
namespace Gelisim_Muhasebe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnamenu());}
    }
}

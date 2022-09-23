using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelisim_Muhasebe.Tools
{
    class cls_MesajBox : IDisposable
    {

        public static Boolean Sor(string Mesaj)
        {
            DialogResult Sor = new DialogResult();
            Sor = MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                // Kabul ederse 
                return true;
            }
            // Hiçbir işlem yapmazsa yada hayır seçerse
            return false;
        }
        public static void HataMesaji(Exception Ex)
        {
            MessageBox.Show(Ex.ToString(), "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UyariMesaji(string mesaJ)
        {
            MessageBox.Show(mesaJ, "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void KayitMesaji(string _Mesaj)
        {
            MessageBox.Show(_Mesaj, "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void GuncelleMesaji(string _Mesaj)
        {
            MessageBox.Show(_Mesaj, "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SilmeMesaji(string _Mesaj)
        {
            MessageBox.Show(_Mesaj, "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SilinemezMesaji(string _Mesaj, string _Baslik)
        {
            MessageBox.Show(_Mesaj, _Baslik, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

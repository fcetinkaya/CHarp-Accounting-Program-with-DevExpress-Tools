using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelisim_Muhasebe.KullaniciModulu.Class
{
    class cls_Yetkiler : IDisposable
    {









        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

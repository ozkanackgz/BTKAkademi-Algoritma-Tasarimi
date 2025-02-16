using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class Vars3
    {
        public static void AnaKod()
        {
            // static const beraber kullanılamaz!
            // static const int c = 23;  hata!

            // sabitler sabitlere katılabilir ;)
            // int sayi = 5;
            // const int c1 = 3 + sayi;  hata!

            // sabitlere olusturulduğu yerde değeri verilmelidir!
            // const int c1;  hata!
            // c1 = 3;   hata!
        }

        readonly int c1;
        public Vars3()
        {
            c1 = 1;
        }
    }
}

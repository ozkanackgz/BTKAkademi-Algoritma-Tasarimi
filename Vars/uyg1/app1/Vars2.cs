using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class Vars2
    {
        public static void AnaKod()
        {
            // kutulama - boxing
            int i = 23;
            // object o = i;
            object o = (object)i; // explicit boxing

            // kutudan cikarma - unboxing
            i *= 2; // i = i*2;
            // i = o; // hata!
            i = (int)o; // cast

            Console.WriteLine("Deger Turu : {0}", i);
            Console.WriteLine("Referans Turu : {0}", o);
        }
    }
}

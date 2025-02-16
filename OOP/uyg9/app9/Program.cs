using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi("Ahmet", 18);
            Console.WriteLine(k.Adi + " : " + k.Yas);

            Kisi k1 = new Kisi("Mehmet");
            Console.WriteLine(k1.Adi + " : " + k1.Yas);

            Kisi k2 = new Kisi();
            Console.WriteLine(k2.Adi + " : " + k2.Yas);
        }
    }
}

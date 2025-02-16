using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5
{
    internal class Str1
    {
        public static void uyg1(char c='*', int n = 5)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}", new string(c,i));
            }
        }

        public static void uyg2(char c='-', int n = 4)
        {
            for (int i = n; i >= 0; i--)
                Console.WriteLine("{0}", new string(c, i));
        }

        public static void uyg3(int baslangicIndisi = 128, int bitisIndisi = 255,
            int satirKarakterSayisi = 10)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            {
                Console.Write("{0,5}", (char)i);
                if (i % satirKarakterSayisi == 0)
                    Console.WriteLine();
            }
        }

        public static void uyg4()
        {
            string ifade = " Afacan ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a', 'e'));
        }
    }
}

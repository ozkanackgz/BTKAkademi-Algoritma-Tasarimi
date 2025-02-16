using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4
{
    internal class For
    {
        public static void uyg1()
        {
            // 1 den 100 e kadar olan sayıların karelerini hesaplama

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} -> {1}", i, i * i);
            }
        }

        public static void uyg2()
        {
            // 1 den 100 e kadar olan tek ve çift sayıları ekranda gösterme ve toplamlarını hesaplama

            int tekToplam = 0, ciftToplam = 0;

            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nTek sayilar");
            for (int i = 1; i < limit; i+=2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i; // tekToplam = tekToplam + i;
            }

            Console.WriteLine("\n\nÇift sayilar");
            for (int i = 2; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i; // ciftToplam = ciftToplam + i;
            }

            Console.WriteLine("\n\nTek toplam: {0,5} \n\nCift toplam: {1,5}", tekToplam, ciftToplam);
        }

        public static void uyg3()
        {
            // 1000 den 0 a kadar beş ve beşin katı olan sayıları ekrana yazdırma ve toplamda
            // kaç adet sayı olduğunu hesaplama

            int sayac = 0;
            for (int i = 1000; i >= 0; i-=5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }

            Console.WriteLine("\n\n Eleman sayisi : {0}", sayac);
        }

        public static void uyg4()
        {
            // CarpimTablosu

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5} \tx {1,5} = {2,5}", i, j, i*j);
                }

                Console.WriteLine("\n\n ----------------------- \n\n");
            }
        }

    }
}

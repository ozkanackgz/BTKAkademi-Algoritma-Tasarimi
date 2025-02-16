using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizideki En Büyük Ve En Küçük Sayı Algoritması

            Console.Write("Kaç elemanlı bir dizi oluşturmak istiyorsunuz? ");
            int boyut = int.Parse(Console.ReadLine());

            int[] dizi = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemanını girin: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            
            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];

            for (int i = 1; i < boyut; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }

                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }

            Console.WriteLine($"\nDizideki En Büyük Eleman: {enBuyuk}");
            Console.WriteLine($"Dizideki En Küçük Eleman: {enKucuk}");


        }
    }
}

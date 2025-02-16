using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4
{
    internal class Array
    {
        public static void uyg1()
        {
            // 1D array decleration
            int[] array = new int[5];

            // get lenght of the array
            int n = array.Length;

            // random number generator for the array
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write(array[i]);
            }
            Console.ReadLine();
        }

        public static void uyg2()
        {
            // decleration of the number array
            int[] number = new int[5];

            // decleration of the square array
            int[] square = new int[5];

            // get the lenght of the array
            int n = number.GetLength(0);

            // assigment of the random number
            // calculation of the square
            for (int i = 0; i < n; i++)
            {
                number[i] = new Random().Next(15, 30);
                square[i] = number[i] * number[i];
                Console.WriteLine("{0} karesi = {1} ", number[i], square[i]);
            }
            Console.ReadLine();
        }

        public static void uyg3()
        {
            // Dizi oluştur en büyük ve en küçük elemanları göster

            Console.Write("n değerini giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[limit];
            Random rnd = new Random();

            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }

            Console.WriteLine("\n Dizinin en büyük elemanı: {0}", EnBuyuk(sayilar));
            Console.WriteLine("\n Dizinin en küçük elemanı: {0}", EnKucuk(sayilar));
        }

        public int[] Olustur(int limit)
        {
            // Dizi oluştur

            int[] sayilar = new int[limit];
            Random rnd = new Random();

            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.Write("\n {0,5} \n", sayilar[i]);
            }
            return sayilar;
        }

        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
        }

        public static int EnKucuk (int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length ; i++)
            {
                if (dizi[i] < ek)
                    ek = dizi[i];
            }
            return ek;
        }

        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
                toplam += X[i];

            return toplam/X.Length;
        }

        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);
            }
            return Math.Sqrt(t / (X.Length - 1));
        }

        public int TekSayilarinSayisi(int[] X)
        {
            int tekSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    tekSayilarinSayisi++;
            }
            return tekSayilarinSayisi;
        }

        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                    ciftSayilarinSayisi++;
            }
            return ciftSayilarinSayisi;
        }

        public int[] TekDiziOlustur(int[] X)
        {
            int[] tekDizi = new int[TekSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i<X.Length; i++)
            {
                if(X[i] % 2 == 1)
                {
                    tekDizi[y] = X[i];
                    y++;
                }
            }
            return tekDizi;
        }

        public int[] CiftDiziOlustur(int[] X)
        {
            int[] ciftDizi = new int[CiftSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }
            }
            return ciftDizi;
        }

        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,3}", X[i]);
            Console.WriteLine("");
        }

        public int[] İfadeyiDiziyeCevir(string ifade)
        {
            string[] bolunmusIfade = ifade.Split(',');

            int n = bolunmusIfade.Length;

            // sayisal dizi
            int[] sayisalDizi = new int[n];

            // ayristirma
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, sayisalDizi[i]);
            }
            return sayisalDizi;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Sayi
    {
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }

        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        public static int MutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else
                return 0;
        }

        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayi 2'dir.");
                return false;
            }

            bool kontrol = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            return kontrol;
        }

        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }

        public static int NeKadarOlanSayilarınToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
                t += i;
            return t;
        }

        public static int NeKadarOlanSayilarinFormulleToplami(int n)
        {
            return n * (n + 1) / 2;
        }

        public static int NeKadarOlanTekSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    t += i;
            }
            return t;
        }

        public static int NeKadarOlanTekSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i +=2)
                t += i;
            return t;
        }

        public static int NeKadarOlanTekSayilarinFormulleToplami(int n)
        {
            n = n + 1;
            n = n / 2;
            return n * n;
        }

        public static int NeKadarOlanCiftSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i ++)
            {
                if (i % 2 == 0)
                    t += i;
            }
            return t;
        }

        public static int NeKadarOlanCiftSayilarinAlternatifToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i+=2)
            {
                t += i;
            }
            return t;
        }

        public static int NeKadarOlanCiftSayilarinFormulleToplami(int n)
        {
            n = n / 2;
            return n * (n + 1);
        }

    }
}

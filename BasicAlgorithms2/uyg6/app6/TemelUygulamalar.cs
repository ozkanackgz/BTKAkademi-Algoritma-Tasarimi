using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6
{
    internal class TemelUygulamalar
    {
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

        public static int[] AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;

            while (n>1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }

            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(',');

            string s = carpanlar [0];
            string y = s;

            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }

            carpanlar = y.Split(',');
            int[] asalcarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalcarpanlar.Length; i++)
                asalcarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            return asalcarpanlar;
        }

        public static int AsalCarpanlarinToplami(int n)
        {
            int[] asalCarpanlar = AsalCarpanlar(60);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
                t += asalCarpanlar[i];
            return t;
        }

        public static int AsalCarpanlarinCarpimi(int n)
        {
            int c = 1;
            int[] asalCarpanlar = AsalCarpanlar(n);
            for (int i = 0; i < asalCarpanlar.Length; i++)
                c *= asalCarpanlar[i];
            return c;
        }

        public static int OKEK(int s1, int s2)
        {
            int s = 1;
            while (s1!=1 && s2!=1)
            {
                int bol = 2;
                for (int i = 1; i <= (s1<s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }
            return s;
        }

        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;

            while (s1!=1 && s2!= 1)
            {
                for (int i = 2; i < (s1<s2 ? s1 : s2); i++)
                {
                    if (s1%bolen == 0 || s2%bolen == 0)
                    {
                        if ((s1 % bolen == 0 && s2 % bolen == 0))
                            s *= bolen;
                        if (s1 % bolen == 0)
                            s1 /= bolen;
                        if (s2 % bolen == 0)
                            s2 /= bolen;
                    }
                    else
                        bolen++;
                }
            }
            return s;
        }

        public static int Faktoriyel(int n)
        {
            if (n <= 1)
                return 1;
            int f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }

        public static void FaktoriyelToplami()
        {
            // 2 - 8
            int t = 0;
            for (int i = 2; i < 9; i++)
            {
                t += TemelUygulamalar.Faktoriyel(i);
                Console.WriteLine("{0}! = {1}",i,TemelUygulamalar.Faktoriyel(i));
            }

            Console.WriteLine("Ortalama = {0:F2}",(double)t/7);
        }

        public static int İkilikTabandanOnlukTabanaGec(string ikilikSayi)
        {
            // uzunlugu belirle
            int n = ikilikSayi.Length;

            // her bir basamagin dizide tutulmasi
            int[] basamaklar = new int[n];

            // onluk karsiligi
            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i] == '0' || ikilikSayi[i] == '1'))
                {
                    Console.WriteLine("\aHatali Giris!");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (ikilikSayi[i] - '0');
            }

            // 2'lik sistemden 10'luk sisteme giriş
            if(kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayi = {1}",ikilikSayi,sayi);
            }
            return sayi;
        }

        public static int SesliHarfSayi(string ifade)
        {
            // sesli harf
            int sesliHarf = 0;

            for (int i = 0; i < ifade.Length;i++)
            {
                // kontrol
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'u' || ifade[i] == 'Ü' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö')
                    sesliHarf++;
            }
            Console.WriteLine("{0} ifadesinde {1} sesli harf var.",
                ifade, sesliHarf);

            return sesliHarf;
        }
    }
}

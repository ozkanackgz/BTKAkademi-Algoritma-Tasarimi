using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace app7
{
    internal class Matris
    {
        public static int[,] Olustur(int satir = 3, int sütun = 3, int min = 1, int mak = 9)
        {
            int[,] X = new int[satir, sütun];
            Random random = new Random();

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sütun; j++)
                {
                    X[i, j] = random.Next(min, mak);
                }
            }

            return X;
        }

        public static void Yazdir (int[,] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                
                    Console.Write("{0,5}", X[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Yazdir(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,5}", X[i]);
            Console.WriteLine();
        }

        public static int[,] SifirMatrisiOlustur(int satir, int sütun)
        {
            return Olustur(satir, sütun, 0, 0);
        }

        public static int[,] BirlerMatrisiOlustur(int satir, int sütun)
        {
            return Olustur(satir, sütun, 1, 1);
        }

        public static int[,] KosegenMatrisOlustur(int boyut = 3, int min = 1, int mak = 9)
        {
            int[,] X = SifirMatrisiOlustur(boyut, boyut);
            Random random = new Random(); // Random nesnesini burada bir kez oluşturun
            for (int i = 0; i < boyut; i++)
                X[i, i] = random.Next(min, mak); // Aynı Random nesnesini kullanın
            return X;
        }
    
        public static int[,] SkalerMatrisOlustur(int boyut=3, int skaler=3)
        {
            return KosegenMatrisOlustur(boyut, skaler, skaler);
        }

        public static bool KareMatrisMi(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ? true : false;
        }

        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatrisOlustur(boyut, 1);
        }

        public static bool BirimMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; (i < X.GetLength(0) && s == true); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    // diyagonal elemanlar disindaki 0 mi?
                    if (X[i,j] != 0 && i != j)
                    {
                        s = false;
                        break;
                    }
                    // diyagonal elemanlar 1 mi?
                    else
                    {
                        if (X[i,i] !=1 && i==j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }

            return s;
        }

        public static int[] DiyagonalElemanlarinListesi(int[,] X)
        {
            if (KareMatrisMi(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                    D[i] = X[i, i];
                return D;
            }
            else
            {
                Console.WriteLine("Lütfen kare matris giriniz!");
                return new int[1];
            }
        }

        public static int Izi(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {
                int[] D = DiyagonalElemanlarinListesi(X);
                for (int i = 0; i < X.GetLength(0); i++)
                    t += X[i, i];
                return t;
            }
            else
                return t;
        }

        public static int[,] Transpoz(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
                for (int j = 0; j < T.GetLength(1); j++)
                    T[i,j] = X[j,i];
            return T;
        }

        public static int[,] YenidenSekillendir(int[,] X, int yeniSatir, int yeniSütun)
        {
            if(X.Length == yeniSatir * yeniSütun)
            {
                // X matrisini tek boyutlu diziye dönüştür
                int[] D = new int[X.Length];
                int sayac = 0;

                // X matrisini tek boyutlu diziye aktarma
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)  // Burada i yerine j olacak
                    {
                        D[sayac] = X[i, j];
                        sayac++;
                    }

                Yazdir(D);  // Bu kısım, D dizisini yazdırmak için kullanılıyor

                sayac = 0;
                // Yeni boyutlarda Y matrisini oluştur
                int[,] Y = new int[yeniSatir, yeniSütun];

                // D dizisindeki elemanları Y matrisine aktar
                for (int i = 0; i < Y.GetLength(0); i++)
                    for (int j = 0; j < Y.GetLength(1); j++)  // Burada j yerine i olmuş
                    {
                        Y[i, j] = D[sayac];
                        sayac++;
                    }

                return Y;  // Yeni matrisi döndür
            }
            else
            {
                Console.WriteLine("Bir hata olustu!");
                return new int[1,1];
            }
        }

        public static bool EsitliMi(int[,] X, int[,] Y)
        {
            bool s = true;

            // boyut kontrolü
            if (X.GetLength(0) == Y.GetLength(0) &&
                X.GetLength(1) == Y.GetLength(1))
            {
                // eleman kontrolü
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        if (X[i, j] != Y[i, j])
                    {
                        s = false;
                        break;
                    } 
            }
            else
            {
                s = false;
            }
            return s;
        }

        public static void YazdirHata(string mesaj)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Hata mesajını kırmızı yazdırmak için
            Console.WriteLine($"Hata: {mesaj}");
            Console.ResetColor(); // Renk ayarını sıfırlamak için
        }

        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                else if (X.Length == 9)
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                        X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) +
                        X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                else
                    YazdirHata("Tanimli bir boyut yok!");
                return d;
            }
            else
            {
                YazdirHata("Parametre kare matris olmali.");
                return d;
            }
        }

        public static int[,] SkalerCarpim(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    X[i, j] = c * X[i, j];
            return X;
        }

        public static int MatrisElemanlarininToplami(int[,] X)
        {
            int t = 0;
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    t += X[i, j];
            return t;
        }

        public static int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            Random random = new Random(); // Random nesnesi döngü dışında bir kere oluşturuluyor.

            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    int randomValue = random.Next(min, maks); // Aynı Random nesnesi kullanılarak rastgele sayı üretiliyor.
                    X[i, j] = randomValue;
                    X[j, i] = randomValue;
                }
            }
            return X;
        }

        public static bool SimetrikMi(int[,] X)
        {
            int[,] Y = Matris.Transpoz(X);
            return EsitliMi(X, Y);
        }

        public static bool KosegenMatrisMi(int[,] X)
        {
            bool s = true;
            if(Matris.KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        if (!(X[i, j] == 0))
                            if (i != j)
                            {
                                s = false;
                                break;
                            }
            }
            else
            {
                YazdirHata("Kare matris degildir!");
                s = false;
            }

            return s;
        }

        public static int[,] UstUcgenMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            Random rnd = new Random(); // Random nesnesini bir kez oluştur

            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i; j < X.GetLength(1); j++)
                {
                    X[i, j] = rnd.Next(min, maks); // Aynı Random nesnesini kullan
                }
            }

            return X;
        }

        public static int[,] AltUcgenMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            Random rnd = new Random();

            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j <= i; j++)
                    X[i, j] = rnd.Next(min, maks);
            return X;
        }

        public static bool UstUcgenMatrisMi(int[,] X)
        {
            bool s = true;

            for (int i = 1; i < X.GetLength(0); i++)
                for (int j = 0; j <= i - 1; j++)
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }

        /// <summary>
        /// Alt üçgen matris kontrolü yapar.
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        public static bool AltUcgenMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0)-1; i++)
                for (int j = i+1; j < X.GetLength(1); j++)
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }
    }
}

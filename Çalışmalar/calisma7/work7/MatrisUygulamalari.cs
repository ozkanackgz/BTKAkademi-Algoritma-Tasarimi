using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work7
{
    internal class MatrisUygulamalari
    {
        public static void İkiMatrisinCarpimi()
        {
            int[,] matris1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matris2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            int boyut = matris1.GetLength(0);
            int[,] sonuc = new int[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    sonuc[i, j] = 0;
                    for (int k = 0; k < boyut; k++)
                    {
                        sonuc[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            Console.WriteLine("Matris Çarpım Sonucu:");
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(sonuc[i, j] + " ");
                }
                Console.WriteLine();
            }
        }






        static int[][] yonler = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } }; // Yukarı, aşağı, sol, sağ
        static int[,] konum;

        static int EnUzunArtanYol(int[,] matris, int x, int y, int n)
        {
            if (konum[x, y] != 0) return konum[x, y];

            int maxUzunluk = 1;

            
            foreach (var yon in yonler)
            {
                int yeniX = x + yon[0];
                int yeniY = y + yon[1];

                if (yeniX >= 0 && yeniX < n && yeniY >= 0 && yeniY < n && matris[yeniX, yeniY] > matris[x, y])
                {
                    maxUzunluk = Math.Max(maxUzunluk, 1 + EnUzunArtanYol(matris, yeniX, yeniY, n));
                }
            }

            konum[x, y] = maxUzunluk;
            return maxUzunluk;
        }

        public static void MatristeEnUzunArtanYol()
        {
            int[,] matris = {
            { 1, 2, 3 },
            { 6, 5, 4 },
            { 7, 8, 9 }
        };

            int n = matris.GetLength(0);
            konum = new int[n, n];

            int maxYol = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maxYol = Math.Max(maxYol, EnUzunArtanYol(matris, i, j, n));
                }
            }

            Console.WriteLine($"Matris İçindeki En Uzun Artan Yol Uzunluğu: {maxYol}");
        }






        static int MaxHistogramAlani(int[] yukseklik)
        {
            int n = yukseklik.Length;
            int[] sol = new int[n];
            int[] sag = new int[n];

            
            for (int i = 0; i < sag.Length; i++)
            {
                sag[i] = n;
            }

            Stack<int> stack = new Stack<int>();

            
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && yukseklik[stack.Peek()] >= yukseklik[i])
                {
                    stack.Pop();
                }

                sol[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(i);
            }

            stack.Clear();

            
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && yukseklik[stack.Peek()] >= yukseklik[i])
                {
                    stack.Pop();
                }

                sag[i] = stack.Count == 0 ? n : stack.Peek();
                stack.Push(i);
            }

            
            int maxAlan = 0;
            for (int i = 0; i < n; i++)
            {
                int genislik = sag[i] - sol[i] - 1;
                maxAlan = Math.Max(maxAlan, genislik * yukseklik[i]);
            }

            return maxAlan;
        }
        static int MaxDikdortgen(int[,] matris)
        {
            int satir = matris.GetLength(0);
            int sutun = matris.GetLength(1);
            int[] yukseklik = new int[sutun];
            int maxAlan = 0;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    // Yükseklik güncelleniyor
                    if (matris[i, j] == 1)
                    {
                        yukseklik[j] += 1;
                    }
                    else
                    {
                        yukseklik[j] = 0;
                    }
                }

                // O anki satırın histogramından maksimum alan bulunuyor
                maxAlan = Math.Max(maxAlan, MaxHistogramAlani(yukseklik));
            }

            return maxAlan;
        }

        public static void MatristeEnbuyukDikdortgenAlani()
        {
            int[,] matris = {
            { 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 1, 0 }
        };

            int enBuyukAlan = MaxDikdortgen(matris);
            Console.WriteLine($"Matris İçindeki En Büyük Dikdörtgenin Alanı: {enBuyukAlan}");
        }
    }
}

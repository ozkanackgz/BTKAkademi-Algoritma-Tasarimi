using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MatrisYazdirma

            //int[,] X = Matris.Olustur(4, 6, 2, 20);
            //Matris.Yazdir(X);




            // SifirlarMatrisiYazdir

            //int[,] X = Matris.SifirMatrisiOlustur(3, 3);
            //Matris.Yazdir(X);




            // BirlerMatrisiYazdir

            //int[,] X = Matris.BirlerMatrisiOlustur(4, 4);
            //Matris.Yazdir(X);




            // KosegenMatrisYazdirma
            //int[,] X = Matris.KosegenMatrisOlustur();
            //Matris.Yazdir(X);




            // SkalerMatrisYazdirma
            //int[,] X = Matris.SkalerMatrisOlustur();
            //Matris.Yazdir(X);




            // KareMatrisMiYazdirma    

            //int[,] X = Matris.BirlerMatrisiOlustur(3, 3);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}", Matris.KareMatrisMi(X) ? "Kare matris" : "Kare matris degil!");




            // BirimMatrisYazdir

            //int[,] X = Matris.BirimMatrisOlustur(4);
            //Matris.Yazdir(X);




            // BirimMatrisMi

            //int[,] X = Matris.BirimMatrisOlustur(4);
            ////int[,] X = Matris.KosegenMatrisOlustur(4);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}",
            //    Matris.BirimMatrisMi(X) ? "Birim Matris" : "Birim Matris degil!");




            // DiyagonalElemanlarinListesi

            //int[,] X = Matris.KosegenMatrisOlustur(5);
            //Matris.Yazdir(X);
            //int[] D = Matris.DiyagonalElemanlarinListesi(X);
            //Matris.Yazdir(D);




            // Izi

            //int[,] X = Matris.KosegenMatrisOlustur(3);
            //Matris.Yazdir(X);
            //int[] D = Matris.DiyagonalElemanlarinListesi(X);
            //Matris.Yazdir(D);
            //Console.WriteLine("Matrisin izi: {0}", Matris.Izi(X));




            // Transpoz

            //int[,] X = Matris.Olustur(3,2);
            //Matris.Yazdir(X);
            //int[,] T = Matris.Transpoz(X);
            //Matris.Yazdir(T);




            // YenidenSekillendir

            //int[,] X = Matris.Olustur(4,3);
            //Matris.Yazdir(X);
            //int[,] Y = Matris.YenidenSekillendir(X, 6, 2);
            //Matris.Yazdir(Y);




            // EsitliMi

            //int[,] X = Matris.Olustur(3, 4);
            //int[,] Y = Matris.Olustur(5, 4);
            ////int[,] X = Matris.SifirMatrisiOlustur(3, 4);
            ////int[,] Y = Matris.SifirMatrisiOlustur(3, 4);

            //Matris.Yazdir(X);
            //Matris.Yazdir(Y);

            //Console.WriteLine("{0}", Matris.EsitliMi(X, Y) ? "Matrisler esit." :
            //    "Matrisler esit degil!");




            // Determinant

            //int[,] X = Matris.Olustur(3,3);
            //Matris.Yazdir(X);
            //Console.WriteLine("|X| = {0}", Matris.Determinant(X));

            ////int[,] X = Matris.Olustur(3, 4);
            ////Matris.Determinant(X);




            // SkalerCarpim

            //int[,] X = Matris.Olustur();
            //Matris.Yazdir(X);

            //X = Matris.SkalerCarpim(2, X);
            //Matris.Yazdir(X);




            // MatrisElemanlarininToplami

            ////int[,] X = Matris.BirlerMatrisiOlustur(2, 2);
            ////int[,] X = Matris.Olustur();
            //int[,] X = Matris.SifirMatrisiOlustur(2, 2);
            //Matris.Yazdir(X);

            //Console.WriteLine("{0}", Matris.MatrisElemanlarininToplami(X));




            // SimetrikMatrisOlustur

            ////int[,] X = Matris.SimetrikMatrisOlustur(3);
            //int[,] X = Matris.Olustur(3);
            //Matris.Yazdir(X);

            //Console.WriteLine("{0}", Matris.SimetrikMi(X) ? "Simetrik." : "Simetrik Değil!");




            // KosegenMatrisMi

            ////int[,] X = Matris.Olustur(5, 3, 1, 3);
            ////int[,] X = Matris.Olustur(5, 5, 1, 3);
            ////int[,] X = Matris.SimetrikMatrisOlustur(5);
            //int[,] X = Matris.KosegenMatrisOlustur(3, 1, 5);
            //Matris.Yazdir(X);

            //Console.WriteLine("{0}", Matris.KosegenMatrisMi(X) ? "Kosegen matrisdir" : "Kosegen matris degildir.");




            // UstUcgenMatrisOlustur

            //int[,] X = Matris.UstUcgenMatrisOlustur(3, -2, 3);
            //Matris.Yazdir(X);




            // AltUcgenMatrisOlustur

            //int[,] X = Matris.AltUcgenMatrisOlustur(3);
            //Matris.Yazdir(X);




            // UstUcgenMatrisMi

            //int[,] X = Matris.UstUcgenMatrisOlustur();
            //Matris.Yazdir(X);

            //Console.WriteLine("{0}", Matris.UstUcgenMatrisMi(X) ? "Ust ucgen matris." : "Ust ucgen matris degil!");




            // AltUcgenMatrisMi

            //int[,] X = Matris.AltUcgenMatrisOlustur();
            //Matris.Yazdir(X);

            //Console.WriteLine("{0}", Matris.AltUcgenMatrisMi(X) ? "Alt ucgen matris." : "Alt ucgen matris degil!");

        }
    }
}

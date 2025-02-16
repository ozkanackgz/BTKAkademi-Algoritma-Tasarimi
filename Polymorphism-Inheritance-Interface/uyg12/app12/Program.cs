using app12.Banka;
using app12.Cizim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app12
{
    internal class Program
    {
        // Polymorphism
        public static void SekilCiz(Sekil sekil)
            => sekil.Ciz();
        static void Main(string[] args)
        {
            ////var r = new Dikdortgen();
            //var r = new Sekil();
            //r.Pozisyon.X = 23;
            //r.Pozisyon.Y = 43;
            //r.Boyut.Genislik = 100;
            //r.Boyut.Genislik = 50;
            //r.Ciz();


            // Polymorphism
            //var r = new Dikdortgen();
            //r.Pozisyon.X = 55;
            //r.Pozisyon.Y = 25;
            //r.Boyut.Genislik = 200;
            //r.Boyut.Yukseklik = 100;
            //SekilCiz(r);


            // base.
            //var r = new Elips();
            //r.Pozisyon.X = 55;
            //r.Pozisyon.Y = 25;
            //r.Boyut.Genislik = 200;
            //r.Boyut.Yukseklik = 100;
            //SekilCiz(r);
            //r.Tasi(new Pozisyon { X = 20, Y = 30 });
            //SekilCiz(r);


            // Abstract
            ////Sekil s1 = new Sekil();  --  hata
            //Sekil s1 = new Dikdortgen();
            //s1.Pozisyon.X = 50;
            //s1.Pozisyon.Y = 50;
            //s1.Boyut.Genislik = 100;
            //s1.Boyut.Yukseklik = 50;
            //SekilCiz(s1);


            // hiyerarşiden dolayı yapıcı metodlar tetiklenir
            //Sekil s1 = new Dikdortgen();


            //Sekil s1 = new Dikdortgen(50,50,100,100);
            //SekilCiz(s1);



            // ------------------------------------------------ //

            // Interface örnek1
            //IBankaHesap mevduatHesabi = new MevduatHesabi();
            //mevduatHesabi.Yatir(100);
            //mevduatHesabi.Cek(500);
            //mevduatHesabi.Cek(50);
            //Console.WriteLine(mevduatHesabi.ToString());



            // Interface örnek2
            //IBankaHesap mevduatHesabi = new MevduatHesabi();
            //ITransfer aktifHesap = new AktifHesap();
            //mevduatHesabi.Yatir(500);
            //aktifHesap.TransferYap(mevduatHesabi, 200);


            // Çalışma Mekanizması ?
            // 1- TransferYap metodu, bir IBankaHesap parametresi bekler.
            // 2- MevduatHesabi, IBankaHesap arayüzünü implemente ettiği için bir MevduatHesabi nesnesi, IBankaHesap türüne atanabilir.
            // 3- Polimorfizm sayesinde, aktifHesap.TransferYap(mevduatHesabi, 200); çağrısı sırasında, MevduatHesabi türü kabul edilir ve bu metot sorunsuz çalışır.



            // Interface örnek3
            IBankaHesap mevduatHesabi = new MevduatHesabi();
            ITransfer aktifHesap = new AktifHesap();
            aktifHesap.Yatir(250);
            mevduatHesabi.Yatir(500);
            aktifHesap.TransferYap(mevduatHesabi, 200);

            Console.WriteLine(aktifHesap.ToString());
            Console.WriteLine(mevduatHesabi.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app12.Cizim
{
    internal class Elips : Sekil
    {
        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Elips ");
            base.Tasi(yeniPozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}

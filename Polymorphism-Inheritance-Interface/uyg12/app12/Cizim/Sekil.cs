using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app12.Cizim
{
    public sealed class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() =>
            $"X : {X}, Y: {Y}";
        
    }

    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public override string ToString() =>
            $"Genislik : {Genislik}, " +
                $"Yukseklik: {Yukseklik}";
        
    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base class - > constructor");
        }

        public Sekil(int genislik, int yukseklik, int x, int y)
        {
            Boyut = new Boyut
            {
                Genislik = genislik,
                Yukseklik = yukseklik,
            };

            Pozisyon = new Pozisyon
            {
                X = x,
                Y = y
            };
        }
        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get; } = new Boyut();

        public virtual void Ciz() => 
            Console.WriteLine($"Sekil {Pozisyon} - {Boyut}");

        public virtual void Tasi(Pozisyon yeniPozisyon)
        {
            Pozisyon.X = yeniPozisyon.X;
            Pozisyon.Y = yeniPozisyon.Y;
            Console.WriteLine($"Tasindi: {Pozisyon}");
        }

        public abstract void YenidenBoyutlandir(int genislik, int yukseklik);
    }
}

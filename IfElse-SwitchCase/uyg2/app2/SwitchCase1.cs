using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    internal class SwitchCase1
    {
        public enum Renkler { Kirmizi, Yesil, Mavi }
        public static void AnaKod()
        {
            Renkler r = (Renkler)(new Random()).Next(0,10); 

            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk kirmizidir.");
                    break;
                case Renkler.Yesil:
                    Console.WriteLine("Renk yesildir.");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk mavidir.");
                    break;
                default:
                    Console.WriteLine("Renk bilinmiyor.");
                    break;
            }
        }
    }
}

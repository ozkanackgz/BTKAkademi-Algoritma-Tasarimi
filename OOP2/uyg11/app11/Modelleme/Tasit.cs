using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app11.Modelleme
{
    internal class Tasit
    {
        public string Motor { get; set; }
        public double Hacim { get; set; }

        public void Temizle() =>
            Console.WriteLine("Tasit temizlendi");
    }

    public enum Motor
    {
        Dizel,
        Benzin,
        LPG,
        Elektrik,
        Jet,
    }

    public enum Renk
    {
        Beyaz,
        Siyah,
        Gri,
        Kirmizi,
        Yesil,
        Mavi,
    }
}


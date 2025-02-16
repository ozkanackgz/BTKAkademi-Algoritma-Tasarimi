using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Daire
    {
        public const double pi = 3.14;

        public static double AlaniHesapla(double r)
        {
            return pi * r * r;
        }

        public static double CeyrekAlaniHesapla(double r, double aci)
        {
            return pi * r * r * aci / 360;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    internal class IfElse3
    {
        public static void AnaKod()
        {
            int m = 9;
            int n = 7;
            int p = 5;


            if (m >= n && m >= p)
            {
                Console.WriteLine("En büyük harf m");
            }

            if (m > n && !(p > m))
            {
                Console.WriteLine("En büyük harf m");
            }

            if (m > n || m > p)
            {
                Console.WriteLine("m en küçük harf değil!");
            }

            m = 4;
            if (!(m >= n || m >= p))
            {
                Console.WriteLine("m artık en küçük harf!");
            }
        }
    }
}

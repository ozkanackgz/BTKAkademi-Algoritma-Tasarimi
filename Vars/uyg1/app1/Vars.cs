using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class Vars
    {
        public static void AnaKod()
        {
            int maks, mins;
            maks = System.Int16.MaxValue;
            mins = System.Int16.MinValue;

            int maks32 = System.Int32.MaxValue;
            int mins32 = System.Int32.MinValue;

            byte minByte = System.Byte.MinValue;
            byte maxByte = System.Byte.MaxValue;

            int sayi = 23;
            sayi = sayi * 2;
            // Console.WriteLine(sayi);

            Console.WriteLine("Byte -> Min : {0} \t \t Maks : {1}",
                minByte, maxByte);

            Console.WriteLine("Int16 -> Min : {0} \t \t Maks : {1}",
                mins, maks);

            Console.WriteLine("Int32 -> Min : {0} \t \t Maks : {1}",
                mins32, maks32);
        }
    }
}

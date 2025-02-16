using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app10
{
    public static class StringExtension
    {
        public static int KelimeSayisi(this string s) =>
            s.Split().Length;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Merhaba YBS";
            Console.WriteLine($"{s.KelimeSayisi()}");
        }
    }
}

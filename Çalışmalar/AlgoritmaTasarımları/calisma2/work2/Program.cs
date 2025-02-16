using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Faktöriyel Hesaplama Algoritması

            Console.Write("Lütfen bir pozitif tam sayı girin: ");
            int number = int.Parse(Console.ReadLine());


            if (number < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanmaz!");
            }
            else
            {
                int factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"{number}! = {factorial}");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    internal class IfElse1
    {
        public static void AnaKod()
        {
            Console.WriteLine("Bir karakter giriniz : ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter büyük bir karakterdir.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter küçük bir karakterdir.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter bir rakamdır.");
            }
            else
            {
                Console.WriteLine("Karakter alfanumerik bir ifade değildir.");
            }
        }
    }
}

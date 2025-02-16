using app11.Modelleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arac benimAracim = new Arac("Skoda", "SuperB", "Gri", 2020);
            Arac benimAracim = new Arac();

            benimAracim.Marka = "Skoda";
            benimAracim.Model = "Superb";
            benimAracim.Renk = Renk.Gri.ToString();
            benimAracim.Yil = 2020;
            benimAracim.Motor = Motor.Dizel.ToString();
            benimAracim.Hacim = 1.6;

            Arac seninAracin = new Arac {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2019,
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.5
            };

            #region Çıktı
            //Console.WriteLine($"{benimAracim.Marka}");
            //Console.WriteLine($"{benimAracim.Model}");
            //Console.WriteLine($"{benimAracim.Renk}");
            //Console.WriteLine($"{benimAracim.Yil}");
            //Console.WriteLine($"{benimAracim.Motor}");
            //Console.WriteLine($"{benimAracim.Hacim}");
            #endregion

            //benimAracim.ToString();
            //seninAracin.ToString();

            //benimAracim.Temizle();


            List<Arac> filo = new List<Arac>();

            filo.Add(new Arac {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2018,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            });

            filo.Add(new Arac
            {
                Marka = "Opel",
                Model = "Corsa",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2014,
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.4
            });

            filo.Add(new Arac
            {
                Marka = "Renault",
                Model = "Fluence",
                Renk = Renk.Siyah.ToString(),
                Yil = 2017,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            });

            foreach (Arac item in filo)
                item.ToString();
        }
    }
}

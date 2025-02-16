using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app11.Modelleme
{
    internal class Arac : Tasit
    {
        #region Fields değişkenleri
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region Constructors

        public Arac()
        {

        }

        public Arac(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }

        #endregion

        #region Methods

        public void Calistir() =>
            Console.WriteLine("Arac Calisti!");

        public void Durdur() =>
            Console.WriteLine("Arac durduruldu.");

        #endregion

        public override string ToString()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{this.Marka}");
            Console.WriteLine($"{this.Model}");
            Console.WriteLine($"{this.Renk}");
            Console.WriteLine($"{this.Yil}");
            Console.WriteLine($"{this.Motor}");
            Console.WriteLine($"{this.Hacim}");
            Console.WriteLine("");
            return "";
        }
    }
}

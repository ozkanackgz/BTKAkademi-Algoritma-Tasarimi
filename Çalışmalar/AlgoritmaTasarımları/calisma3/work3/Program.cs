using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Hafta Sonu Planı Algoritması

            List<string> weatherConditions = new List<string> { "Yağmurlu", "Karlı", "Güneşli" };
            List<string> activities = new List<string> { "Sinema", "Evde Sıcak Çikolata", "Halısaha", "Gezmek" };
            List<int> activityPrices = new List<int> { 200, 0, 50, 0};

            Console.WriteLine("Lütfen hava durumunu seçiniz: ");
            Console.WriteLine("a) Yağmurlu");
            Console.WriteLine("b) Karlı");
            Console.WriteLine("c) Güneşli");

            string weather = Console.ReadLine();

            if (weather == "a")
            {
                weather = weatherConditions[0];
            }
            else if (weather == "b")
            {
                weather = weatherConditions[1];
            }
            else if (weather == "c")
            {
                weather = weatherConditions[2];
            }
            else
            {
                Console.WriteLine("Geçersiz karakter girdiniz!");
            }

            Console.Write("Lütfen bütçenizi girin: ");
            int budget = int.Parse(Console.ReadLine());

            List<string> selectedweather = new List<string>();
            int remainningBudget = budget;

            if (weather == weatherConditions[0])
            {
                if (budget >= 200)
                {
                    selectedweather.Add(activities[0]);
                    selectedweather.Add(activities[1]);
                    remainningBudget -= activityPrices[0];
                    remainningBudget -= activityPrices[1];
                }
                else
                {
                    selectedweather.Add(activities[1]);
                }
            }
            else if (weather == weatherConditions[1])
            {
                if (budget >= 200)
                {
                    selectedweather.Add(activities[0]);
                    selectedweather.Add(activities[1]);
                    remainningBudget -= activityPrices[0];
                    remainningBudget -= activityPrices[1];
                }
                else
                {
                    selectedweather.Add(activities[1]);
                }
            }
            else if (weather == weatherConditions[2])
            {
                if (budget >= 50)
                {
                    selectedweather.Add(activities[2]);
                    selectedweather.Add(activities[3]);
                    remainningBudget -= activityPrices[2];
                    remainningBudget -= activityPrices[3];
                }
                else
                {
                    selectedweather.Add(activities[3]);
                    remainningBudget -= activityPrices[3];
                }
            }

            Console.WriteLine("En Uygun Planlar:");
            foreach (string plan in selectedweather)
            {
                Console.WriteLine(" " + plan );
            }

            Console.WriteLine("Kalan Bütçe: " + remainningBudget + " TL");
        }
    }
}

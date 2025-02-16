using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Alışveriş Listesi Optimazyonu Algoritması

            List<string> productNames = new List<string> { "Ekmek", "Süt", "Peynir", "Çikolata" };
            List<int> productPrices = new List<int> { 5, 10, 15, 7 };

            Console.Write("Lütfen bütçenizi girin: ");
            int budget = int.Parse(Console.ReadLine());

            List<string> selectedProducts = new List<string>();
            int remainningBudget = budget;

            for (int i = 0; i < productPrices.Count; i++)
            {
                for (int j = i + 1; j < productPrices.Count; j++)
                {
                    if (productPrices[i] > productPrices[j])
                    {
                        int tempPrice = productPrices[i];
                        productPrices[i] = productPrices[j];
                        productPrices[j] = tempPrice;

                        string tempName = productNames[i];
                        productNames[i] = productNames[j];
                        productNames[j] = tempName;
                    }
                }
            }

            for (int i = 0; i < productNames.Count; i++)
            {
                if (productPrices[i] <= remainningBudget)
                {
                    selectedProducts.Add(productNames[i]);
                    remainningBudget -= productPrices[i];
                }
            }

            Console.WriteLine("\nSeçilen Ürünler:");
            foreach (string product in selectedProducts)
            {
                Console.WriteLine("- " + product);  
            }

            Console.WriteLine("Kalan Bütçe: " + remainningBudget + " TL");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work6
{
    internal class Program
    {
        // Bakkal Stok Ve Satış Yönetim Sistemi


        
        const decimal KDV = 0.18m;

        
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            // Ürünleri Ekle
            products.Add(new Product("Süt", 10m, 50));
            products.Add(new Product("Ekmek", 2.5m, 100));
            products.Add(new Product("Peynir", 20m, 30));
            products.Add(new Product("Yumurta", 5m, 200));
            products.Add(new Product("Çikolata", 15m, 40));

            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("Bakkal Stok Ve Satış Yönetim Sistemi");
                Console.WriteLine("1. Ürün Ekle");
                Console.WriteLine("2. Ürün Listele");
                Console.WriteLine("3. Ürün Satışı Yap");
                Console.WriteLine("4. Çıkış");
                Console.Write("Bir İşlem Seçin: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        ListProducts();
                        break;
                    case 3:
                        MakeSale();
                        break;
                    case 4:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem.");
                        break;
                }

            } while (choice != 4);
        }

        
        static void AddProduct()
        {
            Console.Write("Ürün Adı: ");
            string name = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Ürün Stoğu: ");
            int stock = int.Parse(Console.ReadLine());

            Product newProduct = new Product(name, price, stock);
            products.Add(newProduct);
            Console.WriteLine("Ürün Eklendi.");
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
        }

        
        static void ListProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Stokta Ürün Bulunmamaktadır.");
            }
            else
            {
                foreach (Product product in products)
                {
                    product.DisplayProductInfo();
                }
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        
        static void MakeSale()
        {
            Console.Write("Satılacak Ürün Adı: ");
            string name = Console.ReadLine();
            Console.Write("Satılacak Miktar: ");
            int quantity = int.Parse(Console.ReadLine()); ;

            bool productFound = false;
            foreach (Product product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    productFound = true;
                    if (product.Stock >= quantity)
                    {
                        decimal total = product.Price * quantity;
                        total += total * KDV;
                        product.Stock -= quantity;
                        Console.WriteLine($"Satış Yapıldı! Toplam Tutar: {total} TL (KDV Dahil).");
                    }
                    else
                    {
                        Console.WriteLine("Yeterli Stok Bulunmuyor.");
                    }
                    break;
                }
            }

            if (!productFound)
            {
                Console.WriteLine("Ürün Bulunamadı.");
            }

            Console.WriteLine("\nDevam etmek için bi tuşa basın...");
            Console.ReadKey();
        }
    }
}

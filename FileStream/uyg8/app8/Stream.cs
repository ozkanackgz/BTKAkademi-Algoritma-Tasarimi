using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app8
{
    internal class Stream
    {
        public static void S1()
        {
            try
            {
                // dinamik konum
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 2; i++)
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Rakamlar.txt";

                // dosya okuma ve yazma
                using (StreamReader sr = new StreamReader(dosyaYol)) { 
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void S2()
        {
            try
            {
                // dinamik yol tanımı
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 2; i++)
                    dosyaYol += yol[i] + "\\";
                dosyaYol += "Adlar.txt";

                string[] adlar = new string[] { "Zara", "Ayca", "Mehmet", "Selim", "Kaan" };
                using (StreamWriter sw = new StreamWriter(dosyaYol))
                {
                    foreach (string s in adlar)
                        sw.WriteLine(s);
                    Console.WriteLine("\n Adlar.txt dosyasi basarili bir sekilde olusturuldu");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static string FizikselYol(string dosyaAdi)
        {
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < yol.Length - 2; i++)
                dosyaYol += yol[i] + '\\';
            dosyaYol += dosyaAdi;
            return dosyaYol;
        }

        public static void FY()
        {
            string ad = "";
            string dosyaYolu = Stream.FizikselYol("Adlar.txt");
            try
            {
                FileStream fs = new FileStream(dosyaYolu,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None);
                while (ad != "cikis")
                {
                    Console.WriteLine("\n Dosyaya kaydetmek üzere bir isim giriniz: ");
                    ad = Console.ReadLine();
                    if(ad != "cikis")
                    {
                        if(fs.CanWrite)
                        {
                            byte[] yaz = Encoding.UTF8.GetBytes(ad);
                            fs.Write(yaz, 0, yaz.Length);
                            fs.WriteByte(13);
                        }
                        else
                        {
                            Console.WriteLine("Yazma yetkisi yok!");
                        }
                    }
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FK2()
        {
            string dosyaYolu = Stream.FizikselYol("Adlar.txt");
            var fi = new FileInfo(dosyaYolu);

            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Name);
        }

        public static void DosyaKopyalama(string kaynak, string hedef)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.CopyTo(hedef);
                Console.WriteLine("{0} kaynakli dosya {1} kopyalandi.", kaynak, hedef);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DosyaSilme(string kaynak)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}

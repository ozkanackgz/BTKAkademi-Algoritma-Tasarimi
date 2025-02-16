using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "Merhaba";
            //IEnumerator rator = s.GetEnumerator();
            //while (rator.MoveNext())
            //{
            //    char c = (char)rator.Current;
            //    Console.Write(c + ".");
            //}
            //// M.e.r.h.a.b.a.
            //Console.WriteLine();
            //foreach (char c in s)
            //{
            //    Console.Write(c +".");
            //}

            // ----------------------------------- //

            //Array dizi = Array.CreateInstance(typeof(Int32), 3);
            //dizi.SetValue(23, 0);
            //dizi.SetValue(44, 1);
            //dizi.SetValue(55, 2);

            //for (int i = 0; i < dizi.Length; i++)
            //    Console.WriteLine(dizi.GetValue(i));

            // ----------------------------------- //

            int[] arr = { 0, 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            string[] names = { "Ali", "Merve", "Sefa" };

            for (int x = 5; x < 10; x++)
            {
                list.Add(x);
            }

            ProcessItems<int>(arr);
            ProcessItems<int>(list);
            ProcessItems<string>(names);
        }

        private static void ProcessItems<T>(IList coll)
        {
            Console.WriteLine(
                "Is readonly returns {0} for this collection.",
                coll.IsReadOnly);

            foreach (T item in coll)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
        internal class MyCollection : IEnumerable
        {
            int[] data = { 1, 2, 3 };
            public IEnumerator GetEnumerator()
            {
                foreach (int i in data)
                    yield return i;
            }
        }

        internal class MyGenCollection : IEnumerable<int>
        {
            int[] data = { 1, 2, 3 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (int i in data)
                    yield return i;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}

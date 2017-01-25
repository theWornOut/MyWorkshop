using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>(5);
            d.Add("Fizik", 100);
            d.Add("Matematik", 75);
            d.Add("Turkce", 80);

            Console.WriteLine(d["Matematik"]);

            Dictionary<int, string> musteriler = new Dictionary<int, string>(10)
            {
                {10,"Ekrem" },
                {11,"Ahmet" },
                {12,"Hakan" }
            };

            Console.WriteLine(musteriler[10]);
            musteriler.Add(13, "Feyyaz");
            musteriler[11] = "Serkan";

            foreach (KeyValuePair<int, string> musteri in musteriler)
            {
                Console.WriteLine("Musteri No: " + musteri.Key + " Adi: " + musteri.Value);
            }

            bool a = musteriler.Contains(new KeyValuePair<int, string>(10, "Ekrem"));
            bool b = musteriler.ContainsKey(10);
            bool c = musteriler.ContainsValue("Ekrem");
            string musteriAdi = musteriler[5];
            string value;
            bool result = musteriler.TryGetValue(5, out value);

            Console.Read();
        }
    }
}

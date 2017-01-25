using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string menu in Menu())
            {
                Console.WriteLine(menu);
            }
            Console.ReadLine();
        }

        public static IEnumerable<string> Menu()
        {
            yield return "Topla";
            yield return "Cikar";
            yield return "Carpma";
            yield return "Bolme";
        }
    }
}

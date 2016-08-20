using System;

namespace ParamsExp
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsClass pC = new ParamsClass();
            Console.WriteLine("1*2*3*4={0}", pC.Carpim(1, 2, 3, 4));
            Console.WriteLine("8*5={0}", pC.Carpim(8, 5));

            pC.Goster(1, "Ahmet", 12.3F, 0.007D, true, 599696969, "C");

            Console.ReadLine();
        }
    }
}

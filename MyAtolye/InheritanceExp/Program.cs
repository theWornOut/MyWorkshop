using System;

namespace InheritanceExp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            Console.WriteLine(baseClass.SekilTipiYaz());
            BaseClass baseClass2 = new BaseClass("ucgen");
            Console.WriteLine(baseClass2.SekilTipiYaz());

            DeviredClass deviredClass = new DeviredClass();
            Console.WriteLine(deviredClass.SekilTipi);
            DeviredClass deviredClass2 = new DeviredClass("MyFigure", true, true, 5, 4, 0);
            Console.WriteLine(deviredClass2.SekilTipi);
            deviredClass2.Ucgen = true;
            Console.WriteLine(deviredClass2.SekilTipiYaz());
            Console.WriteLine(deviredClass2.AlanBul());
        }
    }
}

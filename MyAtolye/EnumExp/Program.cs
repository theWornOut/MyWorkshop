using System;
using static EnumExp.MyEnums;

namespace EnumExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pazartesi gününün değeri = {0}", (int)Gunler.Pazartesi);
            Console.WriteLine("Cuma gününün değeri = {0}", (int)Gunler.Cuma);

            Console.WriteLine("Mühendisin değeri = {0}", (int)Meslekler.Muhendis);
            Console.WriteLine("Doktorun değeri = {0}", (int)Meslekler.Doktor);

            Console.WriteLine("Max değeri = {0}", (long)MinMax.Max);
            Console.WriteLine("Min değeri = {0}", (long)MinMax.Min);

            Console.Read();
        }
    }
}

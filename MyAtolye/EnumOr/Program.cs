using System;

namespace EnumOr
{
    class Program
    {
        [Flags]
        enum Security
        {
            none = 0, read = 1, write = 2
        }

        static void Main(string[] args)
        {
            Security s = Security.read | Security.write;
            Console.WriteLine(s);
            Console.WriteLine((int)s);

            Console.ReadKey();
        }
    }
}

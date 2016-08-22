using System;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double db = 509809232323;
            object obj;
            obj = db;
            Console.WriteLine(db.ToString());
            Console.WriteLine(obj.ToString());
            db += 1;
            Console.WriteLine(db.ToString());
            Console.WriteLine(obj.ToString());
            /*int intDb;
            intDb=(int)obj;
            Console.WriteLine(intDb.ToString());*/
            double dobDb;
            dobDb = (double)obj;
            Console.WriteLine(dobDb.ToString());
        }
    }
}

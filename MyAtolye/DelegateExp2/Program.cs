using System;

namespace ActionFuncPredicateDelegates
{
    class Program
    {
        public delegate void NormalDelege(long sayi);
        public static void KaresiniAl(long deger)
        {
            Console.WriteLine(Math.Pow(deger, 2).ToString());
        }
        public static string KaresiniAlString(long deger)
        {
            return Math.Pow(deger, 2).ToString();
        }
        public static bool KaresiniAlBool(long deger)
        {
            return Math.Pow(deger, 2) > 25;
        }
        public static string OutParameter()
        {
            return "Hello World !";
        }
        static void Main(string[] args)
        {
            //Delegate
            Console.WriteLine("Delegate kullanımı");
            NormalDelege delegateKareAl = new NormalDelege(KaresiniAl);
            delegateKareAl(5);

            //Lambda ForEach() kullanımında action delegate'i mevcut
            //Actionda sadece giriş parametresi mevcuttur
            Console.WriteLine("Action kullanımı");
            Action<long> actionKareAl = new Action<long>(KaresiniAl);
            actionKareAl(5);

            //Func listelerde işlem yaparken linq sorgularında select ve where gibi yerlerde kullanılır
            //Func actiondan farklı giriş ve çıkış parametrelerini olması
            //Func delegate'ine verilen method giriş/giriş-çıkış parametreleri olacak şekilde ayarlanmalıdır
            Console.WriteLine("Func kullanımı");
            Func<long, string> funcLongString = new Func<long, string>(KaresiniAlString);
            Console.WriteLine(funcLongString(5));

            //Predicate delegate herhangi bir tipteki değişkeni alıp, bool tipinde değer döndürür
            Console.WriteLine("Predicate kullanımı");
            Predicate<long> predicateBool = new Predicate<long>(KaresiniAlBool);
            Console.WriteLine(predicateBool(5));
            Console.Read();
        }
    }
}

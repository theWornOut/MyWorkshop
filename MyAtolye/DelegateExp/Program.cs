using System;
using static DelegateExp.MyDelegates;

namespace DelegateExp
{
    class Program
    {
        public static void CiftKat(int sayi)
        {
            sayi = sayi * 2;
            Console.WriteLine($"CiftKat isimli methodun temsilcisi tarafından cagrildi. {sayi.ToString()}");
        }

        public static void UcKat(int sayi)
        {
            sayi = sayi * 3;
            Console.WriteLine($"UcKat isimli methodun temsilcisi tarafından cagrildi. {sayi.ToString()}");
        }

        static void Main(string[] args)
        {
            temsilci t1 = new temsilci(CiftKat);
            temsilci t2 = new temsilci(UcKat);

            Random rnd = new Random();
            myDelegateInt = rnd.Next(0, 100);

            MyDelegates myDelegates = new MyDelegates();
            if (myDelegateInt > 50)
            {
                myDelegates.myDelegateMethod(t1);
            }
            else
            {
                myDelegates.myDelegateMethod(t2);
            }
        }
    }
}

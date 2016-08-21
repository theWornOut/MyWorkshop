using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(4);
            stack.Push("Ekrem");
            stack.Push("Alpay");
            stack.Push("24");
            stack.Push("77");
            stack.Push(true);

            Console.WriteLine($"Çıkan eleman {stack.Pop().ToString()}");
            Console.WriteLine($"Çıkan eleman {stack.Pop().ToString()}");
            Console.WriteLine($"Çıkan eleman {stack.Pop().ToString()}");
            Console.WriteLine("-------------");

            IEnumerator dizi = stack.GetEnumerator();
            while (dizi.MoveNext())
            {
                Console.WriteLine($"Guncel eleman {dizi.Current.ToString()}");
            }
            Console.WriteLine("-------------");
            Console.WriteLine($"En uzun eleman {stack.Peek()}");
            dizi = stack.GetEnumerator();
            while (dizi.MoveNext())
            {
                Console.WriteLine($"Guncel eleman {dizi.Current.ToString()}");
            }
        }
    }
}

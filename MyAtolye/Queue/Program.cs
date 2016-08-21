using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ekrem");
            queue.Enqueue("Alpay");
            queue.Enqueue("24");
            queue.Enqueue("77");

            Console.WriteLine("Çıkan eleman {0}", queue.Dequeue().ToString());
            Console.WriteLine("Çıkan eleman {0}", queue.Dequeue().ToString());
            Console.WriteLine("Çıkan eleman {0}", queue.Dequeue().ToString());
            Console.WriteLine("------------------");

            IEnumerator dizi = queue.GetEnumerator();
            while (dizi.MoveNext())
            {
                Console.WriteLine("Güncel eleman {0}", dizi.Current.ToString());
            }
            Console.WriteLine("------------------");
            Console.WriteLine("En altta kalan eleman {0}", queue.Peek());
            dizi = queue.GetEnumerator();
            while (dizi.MoveNext())
            {
                Console.WriteLine("Güncel eleman {0}", dizi.Current.ToString());
            }
            Console.Read();
        }
    }
}

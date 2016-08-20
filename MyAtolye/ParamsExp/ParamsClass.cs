using System;

namespace ParamsExp
{
    public class ParamsClass
    {
        public int Carpim(params int[] deger)
        {
            int sonuc = 1;
            for (int i = 0; i < deger.Length; i++)
            {
                sonuc *= deger[i];
            }
            return sonuc;
        }


        public void Goster(params object[] deger)
        {
            for (int i = 0; i < deger.Length; ++i)
            {
                Console.WriteLine("{0}. değerimiz={1}", i, deger[i].ToString());
            }
            Console.ReadLine();
        }
    }
}

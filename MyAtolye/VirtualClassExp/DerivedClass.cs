using System;

namespace VirtualClassExp
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {

        }

        public override void Yazdir()
        {
            Console.WriteLine("I'm a derived class");
        }
    }
}

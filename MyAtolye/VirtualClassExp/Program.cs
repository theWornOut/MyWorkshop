namespace VirtualClassExp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass;
            DerivedClass derivedClass = new DerivedClass();
            baseClass = derivedClass;
            baseClass.Yazdir();
        }
    }
}

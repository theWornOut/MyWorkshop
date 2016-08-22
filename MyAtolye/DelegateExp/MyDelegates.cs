namespace DelegateExp
{
    public class MyDelegates
    {
        public static int myDelegateInt;
        public delegate void temsilci(int deger);

        public void myDelegateMethod(temsilci deger)
        {
            deger(myDelegateInt);
        }
    }
}

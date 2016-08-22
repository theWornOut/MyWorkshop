using System;

namespace ActivatorDynamicInstance
{
    class Program
    {
        private static string instanceSpec = "System.EventArgs;System.Random;System.Exception;System.Object;System.Version";
        static void Main(string[] args)
        {
            string[] instances = instanceSpec.Split(';');
            Array insList = Array.CreateInstance(typeof(object), instances.Length);
            object item;
            for (int i = 0; i < instances.Length; i++)
            {
                Console.WriteLine($"Creating instance of: {instances[i]}");
                item = Activator.CreateInstance(Type.GetType(instances[i]));
                insList.SetValue(item, i);
            }
            Console.WriteLine($"\nObjects and their default values:\n");
            foreach (object o in insList)
            {
                Console.WriteLine($"Type: {o.GetType().FullName}\nValue: {o.ToString()}\nHashCode: {o.GetHashCode()}");
            }
        }
    }
}

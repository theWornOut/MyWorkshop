﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("System.String");
            MemberInfo[] myTypeMembers = myType.GetMembers();
            Console.WriteLine($"Sınıftaki uye sayilari => {myType.Name.Length.ToString()}");
            for (int i = 0; i < myTypeMembers.Length; i++)
            {
                Console.WriteLine($"Uye Adi => { myTypeMembers[i].Name.ToString() } - Uye Tipi => {myTypeMembers[i].MemberType.ToString()} ");
            }
        }
    }
}

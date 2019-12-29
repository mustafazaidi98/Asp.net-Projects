using System;
using System.Reflection;

namespace Q3
{
     class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\\Users\\k1639\\Downloads\\EntityFramework.dll");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                MemberInfo[] methods = type.GetMethods();

                foreach (MemberInfo method in methods)

                {
                    Console.WriteLine(method.Name.ToString());
                }
            }

            Console.ReadKey();
        
        }
    }
}


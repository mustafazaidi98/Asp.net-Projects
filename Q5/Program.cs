using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompareObjects("HELLO", "hallo").ToString());
        }
        public static bool CompareObjects(object name, object name2)
        {
            string s1 = name.ToString();
            string s2 = name2.ToString();

            if (s1.Equals(s2))
                return true;

            return false;
        }
    }
}

using System;

namespace Ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The word");
            string input = Console.ReadLine();
            string alter = input.Substring(0, 4).ToLower() + input.Substring(4).ToUpper();
            Console.WriteLine("The altered string is-> {0}",alter);
        }
    }
}

using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5;
            calculator c = new calculator();
            // call functions here
        }
    }
    public class calculator
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Subtract(int a, int b)
        {
            return (a - b);
        }

        public int Multiply(int a, int b)
        {
            return (a * b);
        }

        public int Divide(int a, int b)
        {
            return (a / b);
        }

        public int Add(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum = sum + array[i];
            return sum;
        }

    }
}

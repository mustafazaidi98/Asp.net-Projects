using System;

namespace Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("write required size of matrix");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];
            Random r = new Random();
            Console.WriteLine("Randomized matrix:" );
            for (int i = 0; i < size;i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = r.Next(100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + matrix[i ,i];
            }
            Console.WriteLine("The sum of diagonals is " + sum);
        }
    }
}

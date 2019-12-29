using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace Q1
{
    class Program
    {

        public static void Thread_search(int[] array, int element, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {

                if (array[i] == element)
                {
                    Console.WriteLine("Element Found At: " + i);
                    break;
                }
            }
        }
        public class parameterobj
        {
            int[] array = new int[200000];

            int element, start, end;
            public parameterobj(int[] array, int element, int start, int end)
            {
                this.array = array;
                this.element = element;
                this.start = start;
                this.end = end;

            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[1000000];
            Random r = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                array[i] = r.Next(0, 10000);
            }
            Console.WriteLine("Write an integer to be searched (0,10000)");
            int element = Console.Read();
            Stopwatch ST = new Stopwatch();
            ST.Start();
            Thread_search(array, element, 0, 1000000);
            ST.Stop();
            Console.WriteLine("Time taken for searching in single threaded function: " + ST.Elapsed + " milliseconds");
            ST.Reset();
            ST.Start();

                Thread th = new Thread(() => Thread_search(array, element, 0, 250000));
                th.Start();
                Thread th1 = new Thread(() => Thread_search(array, element, 250000, 500000));
                th1.Start(); 
                Thread th2 = new Thread(() => Thread_search(array, element, 500000, 750000));
                th2.Start();
                Thread th3 =new Thread(() => Thread_search(array, element, 750000, 1000000));
                th3.Start();
            th1.Join();
            th.Join();
            th2.Join();
            th3.Join();
                ST.Stop();
            Console.WriteLine("Time taken for searching by multithreading function: " + ST.Elapsed + " milliseconds");
        }

    }
}

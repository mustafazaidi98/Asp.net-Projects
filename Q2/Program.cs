using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace Q2
{

    class Program
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
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
            // ParameterizedThreadStart par = new ParameterizedThreadStart(Thread_search
           
            ST.Start();
            /*try
            {*/
            Thread th = new Thread(() => Thread_search(array, element, 0, 250000));
            // Monitor.Enter(array);
            th.Start();
            th.Join();
            /*}
            finally
            {
                Monitor.Exit(array);
            }
            try
            {*/
            Thread th1 = new Thread(() => Thread_search(array, element, 250000, 500000));

            // Monitor.Enter(array);
            th1.Start();
            th1.Join();
            /*}
            finally
            {
                Monitor.Exit(array);
            }
            try
            {*/
            Thread th2 = new Thread(() => Thread_search(array, element, 500000, 750000));

            //              Monitor.Enter(array);
            th2.Start();
            th2.Join();
            /*}
            finally
            {
                Monitor.Exit(array);
            }
            try
            {
*/
            Thread th3 = new Thread(() => Thread_search(array, element, 750000, 1000000));

            //Monitor.Enter(array);
            th3.Start();
            th3.Join();
            /*}
            finally
            {
                Monitor.Exit(array);
            }
*/
            ST.Stop();
            Console.WriteLine("Time taken for searching by threadsafe function: " + ST.Elapsed + " milliseconds");
        }
    }
}

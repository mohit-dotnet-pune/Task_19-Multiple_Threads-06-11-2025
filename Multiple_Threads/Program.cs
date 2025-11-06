using System;
using System.Threading;

namespace MultiThreadDemo
{
    class Program
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[Thread 1] Number: {i}");
                Thread.Sleep(500);
            }
        }

        static void PrintAlphabets()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"[Thread 2] Alphabet: {c}");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            // Create thread objects
            Thread t1 = new Thread(PrintNumbers);
            Thread t2 = new Thread(PrintAlphabets);

            // Start threads
            t1.Start();
            t2.Start();

            // Wait for both threads to complete before ending main thread
            t1.Join();
            t2.Join();

            Console.WriteLine("Main Thread Completed");
        }
    }
}

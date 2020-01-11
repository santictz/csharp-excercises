using System;
using System.Threading;

namespace CSharpExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine($"The interval duration was {stopwatch.GetInterval()}");
                Console.ReadLine();
            }

        }
    }
}

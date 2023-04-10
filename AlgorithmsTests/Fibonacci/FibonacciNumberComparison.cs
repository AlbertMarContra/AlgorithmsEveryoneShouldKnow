using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Fibonacci
{
    public class FibonacciNumberComparison
    {
        public  static void Play()
        {

            // Read Position
            var selectedPoss = -1;
            do
            {
                Console.WriteLine("Select Fibonacci serie position");
                try
                {
                    selectedPoss = Int32.Parse(Console.ReadLine());
                }
                catch (Exception) { }
            } while (selectedPoss < 0);

            // Start measuring
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine($" \n Recursive: Fibonacci number at {selectedPoss} is {FibonacciNumberRecursive.GetFibonacciNumber(selectedPoss)}  | Time ms: {watch.ElapsedTicks} \n");
            watch.Restart();
            Console.WriteLine($" \n Iterative Fn1: Fibonacci number at {selectedPoss} is {FibonacciNumberIterative.GetFibonacciNumberFn1(selectedPoss)}  | Time ms: {watch.ElapsedTicks} \n");
            watch.Restart();
            Console.WriteLine($" \n Iterative Fn2: Fibonacci number at {selectedPoss} is {FibonacciNumberIterative.GetFibonacciNumberFn2(selectedPoss)}  | Time ms: {watch.ElapsedTicks} \n");
            watch.Stop();

            Play();

        }
    }
}

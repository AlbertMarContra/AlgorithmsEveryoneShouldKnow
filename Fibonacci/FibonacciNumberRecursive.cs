using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Fibonacci
{
    public class FibonacciNumberRecursive
    {

        public static void Play()
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

            // Print serie
            Console.WriteLine($" \n Fibonacci number at {selectedPoss} is {GetFibonacciNumber(selectedPoss)} \n");

            Play();

        }

        public static int GetFibonacciNumber(int position)
        {
            if (position < 2)
                return position;
            else
                return GetFibonacciNumber(position - 1) + GetFibonacciNumber(position - 2);
        }


    }
}

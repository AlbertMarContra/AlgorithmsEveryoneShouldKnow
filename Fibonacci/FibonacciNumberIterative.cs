using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Fibonacci
{
    public class FibonacciNumberIterative
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
            Console.WriteLine($" \n Fn1: Fibonacci number at {selectedPoss} is {GetFibonacciNumberFn1(selectedPoss)} \n");
            Console.WriteLine($" Fn2: Fibonacci number at {selectedPoss} is {GetFibonacciNumberFn2(selectedPoss)} \n");

            Play();

        }

        public static int GetFibonacciNumberFn1(int position)
        {

            if (position < 2)
                return position;

            int currentNumber = 0;

            var prevprevNumber = 0;
            var prevNumber = 1;

            for (int i = 0; i < position ; i++)
            {
                currentNumber = prevNumber + prevprevNumber;

                prevprevNumber = prevNumber;
                prevNumber = currentNumber;
            }

            return prevprevNumber;
        }

        public static int GetFibonacciNumberFn2(int position)
        {

            if (position < 2)
                return position;

            var prevNumber = 0;
            int currentNumber = 1;

            for (int i = 0; i < position; i++)
            {
                var currentBack = currentNumber;
                currentNumber = currentNumber + prevNumber;

                prevNumber = currentBack;
            }

            return prevNumber;
        }


    }
}

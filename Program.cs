using System;
using Algorithms.Fibonacci;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectedPoss = -1;


            // Menu
            Console.WriteLine("Select algorithm, write the number \n");
            Console.WriteLine("1 - Minimax Tic Tac Toe");
            Console.WriteLine("2 - Fibonacci number Recursive");
            Console.WriteLine("3 - Fibonacci number Iterative");
            Console.WriteLine("4 - Fibonacci number Recurvive vs Iterative");
            // ... Add here more algorithms and add the case for them
            // ...
            Console.WriteLine("\n");


            // Read Number
            try
            {
                selectedPoss = Int32.Parse(Console.ReadLine());
            }
            catch (Exception) { }
            

            // Select algorithm
            switch (selectedPoss)
            {
                case 1:
                    Console.Clear();
                    Minimax.Tictactoe.Game.Play();
                    break;
                case 2:
                    Console.Clear();
                    FibonacciNumberRecursive.Play();
                    break;
                case 3:
                    Console.Clear();
                    FibonacciNumberIterative.Play();
                    break;
                case 4:
                    Console.Clear();
                    FibonacciNumberComparison.Play();
                    break;
                // ... Add here more algorithms and in the menu
                // ...
                default:
                    Console.WriteLine("Sorry, that algorithm doesnt exist");
                    break;
            }
            
        }
    }
}

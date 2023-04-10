using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tools
{
    public class Print
    {

        public static void PrintArray<T1>(T1[] elements)
        {
            foreach (var e in elements)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\n");
        }
        public static void PrintArray<T1>(T1[] elements, string header)
        {
            Console.WriteLine(header);
            PrintArray(elements);
        }

    }
}

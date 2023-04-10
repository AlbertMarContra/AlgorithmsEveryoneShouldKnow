using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Algorithms
{
    [TestClass]
    public class Test_TimeComplexity
    {


        [TestMethod]
        [DataRow(200, 800)]
        public void NA_A1_TimeComplexityTest_NA(int repeats, int length)
        {
            // Prepare
            // ...

            // Execute
            // ...
            long ticks = 0;

            // Bubble Sort
            ticks = SortIntegers(repeats, length, Algorithms.Sorting.BubbleSort.Sort);
            System.Console.WriteLine($"Bubble Sort: {ticks}");

            // Bubble Optimized
            ticks = SortIntegers(repeats, length, Algorithms.Sorting.BubbleSort.SortOptimized);
            System.Console.WriteLine($"Bubble Sort Optimized: {ticks}");

            // Bubble Recursive
            ticks = SortIntegers(repeats, length, Algorithms.Sorting.BubbleSort.SortRecursive);
            System.Console.WriteLine($"Bubble Sort Recursive: {ticks}");

            // Insertion Sort
            ticks = SortIntegers(repeats, length, Algorithms.Sorting.InsertionSort.Sort);
            System.Console.WriteLine($"Insertion Sort: {ticks}");


            // Linq Sort
            ticks = SortIntegersWithLinq(repeats, length);
            System.Console.WriteLine($"Insertion Sort: {ticks}");



            // Assert
            // ...


        }




        public long SortIntegers(int repeats, int length, System.Func<int[], System.Func<int, int, bool>, int[]> sort)
        {

            long aTime = 0;
            var rndGen = new System.Random();
            var watch = new System.Diagnostics.Stopwatch();

            for (int i = 0; i < repeats; i++)
            {

                // Create and fill the array with random numbers
                int[] elements = new int[length];
                for (int j = 0; j < elements.Length; j++)
                {
                    elements[j] = rndGen.Next(-1000, 1000);
                }

                watch.Start();
                sort(elements, (e1, e2) => e1 > e2);
                aTime += watch.ElapsedTicks;
                watch.Reset();

            }

            return aTime / repeats;

        }

        public long SortIntegersWithLinq(int repeats, int length)
        {

            long aTime = 0;
            var rndGen = new System.Random();
            var watch = new System.Diagnostics.Stopwatch();

            for (int i = 0; i < repeats; i++)
            {

                // Create and fill the array with random numbers
                int[] elements = new int[length];
                for (int j = 0; j < elements.Length; j++)
                {
                    elements[j] = rndGen.Next(-1000, 1000);
                }

                watch.Start();
                var ord = System.Linq.Enumerable.OrderBy(elements, e => e);
                elements = System.Linq.Enumerable.ToArray(ord);
                aTime += watch.ElapsedTicks;
                watch.Reset();

            }

            return aTime / repeats;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BubbleSort
    {

        public static T1[] Sort<T1>(T1[] elements, Func<T1,T1,bool> compare)
        {

            for(int i = 0; i < (elements.Length - 1); i++)
            {
                for (int j = 0; j < (elements.Length - 1); j++)
                {
                    if (compare(elements[j], elements[j + 1]))
                    {
                        var e1Back = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = e1Back;
                    }
                }
            }

            return elements;
        }


        public static T1[] SortOptimized<T1>(T1[] elements, Func<T1, T1, bool> compare)
        {

            for (int i = 0; i < (elements.Length - 1); i++)
            {
                var swampped = false;
                for (int j = 0; j < (elements.Length - 1); j++)
                {
                    if (compare(elements[j], elements[j + 1]))
                    {
                        var e1Back = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = e1Back;
                        swampped = true;
                    }
                }

                // If no elements swamped , the array is ordered, so exit
                if (!swampped) break;
            }

            return elements;
        }


        public static T1[] SortRecursive<T1>(T1[] elements, Func<T1, T1, bool> compare)
        {
            // Sort
            var swampped = false;
            for (int j = 0; j < (elements.Length - 1); j++)
            {
                if (compare(elements[j], elements[j + 1]))
                {
                    var e1Back = elements[j];
                    elements[j] = elements[j + 1];
                    elements[j + 1] = e1Back;
                    swampped = true;
                }
            }

            // If no elements swamped , the array is ordered
            if (!swampped) return elements;
            else  return SortRecursive(elements, compare);

        }

    }
}

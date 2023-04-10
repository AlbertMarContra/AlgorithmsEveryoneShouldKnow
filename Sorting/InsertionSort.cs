using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        public static T1[] Sort<T1>(T1[] elements, Func<T1, T1, bool> compare)
        {

            for (int i = 0; i < (elements.Length - 1); i++)
            {
                var j = i + 1;
                while (j > 0 && compare(elements[j-1], elements[j]))
                {
                    var e2Back = elements[j];
                    elements[j] = elements[j - 1];
                    elements[j - 1] = e2Back;
                    j--;
                }
            }

            return elements;
        }
    }
}

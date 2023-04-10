using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Arrays
{
    public class SearchPairOfNumbers
    {

        public static int[] TwoSumForeward(int[] nums, int target)
        {
            var r = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    if (((nums[i] + nums[j]) == target) && (i != j))
                    {
                        r[0] = i;
                        r[1] = j;

                        return r;
                    }
                }
            }

            return r;
        }

        public static int[] TwoSumForewardBackward(int[] nums, int target)
        {
            var r = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = (nums.Length - 1); j > i; j--)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        r[0] = i;
                        r[1] = j;

                        return r;
                    }
                }
            }

            return r;
        }

        public static int[] TwoSumOrderedForewardBackward(int[] nums, int target)
        {
            
            // Order the array in ascending order
            var numsAlt = nums.Select((n, i) => new { index = i, value = n}).OrderBy(e => e.value).ToArray();

            // Define two pointers , at begining and at the end
            var f = 0;
            var g = nums.Length - 1;

            // Iterate while the sum is diferent from target
            while ((numsAlt[f].value + numsAlt[g].value) != target)
            {
                if ((numsAlt[f].value + numsAlt[g].value) > target)
                    g--;
                else
                    f++;
            }

            return new int[] { numsAlt[f].index, numsAlt[g].index};
        }

        
    }
}

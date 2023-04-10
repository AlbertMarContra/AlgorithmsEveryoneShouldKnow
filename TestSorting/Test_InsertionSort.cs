using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Algorithms
{
    [TestClass]
    public class Test_InsertionSort
    {
        // InsertionSort

        [TestMethod]
        [DataRow(new int[] { 2, 7, 1, 3, 0, 6 }, new int[] { 0, 1, 2, 3, 6, 7 })]
        [DataRow(new int[] { 12, 7, 1, 3, 3, -1 }, new int[] { -1, 1, 3, 3, 7, 12 })]
        [DataRow(new int[] { 2, 1, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 2, 2, 2, 3, 0, 6 }, new int[] { 0, 2, 2, 2, 3, 6 })]
        [DataRow(new int[] { 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2 })]
        public void InsertionSort_A1_SortOrderedForAnyArray_WillSortTheElements(int[] elements, int[] sorted)
        {


            var ordered = Algorithms.Sorting.InsertionSort.Sort(elements, (e1, e2) => e1 > e2);

            // Assertions

            // elements must be sorted
            for (int i = 0; i < elements.Length; i++)
            {
                Assert.AreEqual(sorted[i], elements[i]);
            }

            // The returned array must be the same as the array passed
            Assert.IsTrue(object.ReferenceEquals(elements, ordered));

        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 1, 3, 0, 6 }, new int[] { 7, 6, 3, 2, 1, 0 })]
        [DataRow(new int[] { 12, 7, 1, 3, 3, -1 }, new int[] { 12, 7, 3, 3, 1, -1 })]
        [DataRow(new int[] { 2, 1, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        [DataRow(new int[] { 2, 2, 2, 3, 0, 6 }, new int[] { 6, 3, 2, 2, 2, 0 })]
        [DataRow(new int[] { 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2 })]
        public void InsertionSort_A2_SortOrderedForAnyArray_WillSortTheElements(int[] elements, int[] sorted)
        {


            var ordered = Algorithms.Sorting.InsertionSort.Sort(elements, (e1, e2) => e1 < e2);

            // Assertions

            // elements must be sorted
            for (int i = 0; i < elements.Length; i++)
            {
                Assert.AreEqual(sorted[i], elements[i]);
            }

            // The returned array must be the same as the array passed
            Assert.IsTrue(object.ReferenceEquals(elements, ordered));

        }

        [TestMethod]
        [DataRow(new int[] { })]
        public void InsertionSort_E1_IfEmptyArrayPassed_WillReturnTheSameArray(int[] elements)
        {

            var ordered = Algorithms.Sorting.InsertionSort.Sort(elements, (e1, e2) => e1 > e2);

            // Assertions

            Assert.IsTrue(ordered.Length == 0);
            Assert.IsTrue(object.ReferenceEquals(elements, ordered));
        }

        [TestMethod]
        [DataRow(null)]
        public void InsertionSort_E2_ForANullArray_WillThrowException(int[] elements)
        {

            // Assertions

            Assert.ThrowsException<System.NullReferenceException>(() => Algorithms.Sorting.InsertionSort.Sort(elements, (e1, e2) => e1 > e2));
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Algorithms
{
    [TestClass]
    public class TestSearchPairOfNumbers
    {
        [TestMethod]
        [DataRow(new int[] { 3, 2, 3, 5 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumForeward_t01_AnArrayIsPassed_ReturnTwoSumIndexes(int[] input, int target, int[] output)
        {

            var actual = Algorithms.Arrays.SearchPairOfNumbers.TwoSumForeward(input, target);

            Assert.AreEqual(output[0], actual[0]);
            Assert.AreEqual(output[1], actual[1]);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 2, 3, 5 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumForewardBackward_t01_AnArrayIsPassed_ReturnTwoSumIndexes(int[] input, int target, int[] output)
        {

            var actual = Algorithms.Arrays.SearchPairOfNumbers.TwoSumForewardBackward(input, target);

            Assert.AreEqual(output[0], actual[0]);
            Assert.AreEqual(output[1], actual[1]);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 2, 3, 5 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumOrderedForewardBackward_t01_AnArrayIsPassed_ReturnTwoSumIndexes(int[] input, int target, int[] output)
        {

            var actual = Algorithms.Arrays.SearchPairOfNumbers.TwoSumOrderedForewardBackward(input, target);

            Assert.AreEqual(output[0], actual[0]);
            Assert.AreEqual(output[1], actual[1]);
        }

    }
}

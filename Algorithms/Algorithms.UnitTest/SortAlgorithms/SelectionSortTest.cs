using Algorithms.SortAlgorithms;
using Algorithms.SortAlgorithms.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.UnitTest.SortAlgorithms
{
    /// <summary>
    /// BubbleSortWithFlagTest 的摘要描述
    /// </summary>
    [TestClass]
    public class SelectionSortTest
    {
        public ISortAlgorithms GetSystemUnderTest()
        {
            return new SelectionSort();
        }

        [TestMethod]
        public void TestSelectionSort_Case1()
        {
            //arrange 
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            int[] testCase = { 6, 2, 3, 4, 1, 5 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(ref testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestSelectionSort_Case2()
        {
            //arrange 
            int[] expected = { 0, 1, 3, 6, 10, 100 };
            int[] testCase = { 100, 3, 1, 6, 0, 10 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(ref testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestSelectionSort_Case3()
        {
            //arrange 
            int[] expected = { -3, -1, 0, 10, 20, 30, 100 };
            int[] testCase = { 100, 0, 10, -1, 20, 30, -3 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(ref testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestSelectionSort_Case4()
        {
            //arrange 
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] testCase = { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(ref testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }
    }
}

using Algorithms.SortAlgorithms;
using Algorithms.SortAlgorithms.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.UnitTest.SortAlgorithms
{
    /// <summary>
    /// BubbleSortWithFlagTest 的摘要描述
    /// </summary>
    [TestClass]
    public class MergeSortTest
    {
        public ISortAlgorithms GetSystemUnderTest()
        {
            return new MergeSort();
        }

        [TestMethod]
        public void TestMergeSort_PositiveInteger_Sorted_Case1()
        {
            //arrange 
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            int[] testCase = { 6, 2, 5, 4, 1, 3 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_PositiveInteger_Sorted_Case2()
        {
            //arrange 
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            int[] testCase = { 6, 2, 3, 4, 1, 5 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_PositiveInteger_Sorted_Case3()
        {
            //arrange 
            int[] expected = { 1, 2 };
            int[] testCase = { 2, 1 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_PositiveInteger_Sorted_Case4()
        {
            //arrange 
            int[] expected = { 1, 2, 3 };
            int[] testCase = { 2, 3, 1 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_PositiveInteger_Sorted2()
        {
            //arrange 
            int[] expected = { 0, 1, 3, 6, 10, 100 };
            int[] testCase = { 100, 3, 1, 6, 0, 10 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_Integer_Sorted()
        {
            //arrange 
            int[] expected = { -3, -1, 0, 10, 20, 30, 100 };
            int[] testCase = { 100, 0, 10, -1, 20, 30, -3 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_PositiveIntegerMoreElement_Sorted()
        {
            //arrange 
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] testCase = { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_LowerCaseString_Sorted()
        {
            //arrange 
            string[] expected = { "a", "b", "c", "d", "e", "f" };
            string[] testCase = { "c", "f", "a", "d", "b", "e" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_UpperCaseString_Sorted()
        {
            //arrange 
            string[] expected = { "A", "B", "C", "D", "E", "F" };
            string[] testCase = { "C", "F", "A", "D", "B", "E" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_HybridCaseString_Sorted()
        {
            //arrange 
            string[] expected = { "A", "B", "C", "d", "e", "f" };
            string[] testCase = { "C", "f", "A", "d", "B", "e" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_HybridCaseString_Sorted2()
        {
            //arrange 
            string[] expected = { "a", "b", "c", "D", "E", "f" };
            string[] testCase = { "c", "f", "a", "D", "b", "E" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }
        [TestMethod]
        public void TestMergeSort_HybridCaseString_Sorted3()
        {
            //arrange 
            string[] expected = { "a", "A", "b", "B", "c", "C" };
            string[] testCase = { "c", "B", "A", "C", "b", "a" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }

        [TestMethod]
        public void TestMergeSort_HybridCaseStringOnlyA_Sorted()
        {
            //arrange 
            string[] expected = { "a", "a", "a", "A", "A", "A" };
            string[] testCase = { "a", "a", "A", "a", "A", "A" };
            var sut = GetSystemUnderTest();
            //act
            sut.Sort(testCase);
            //assert
            CollectionAssert.AreEqual(expected, testCase);
        }
    }
}

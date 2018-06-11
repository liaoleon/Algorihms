using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.SortAlgorithms.Interface;
using Algorithms.SortAlgorithms;

namespace Algorithms.UnitTest.SortAlgorithms
{
    /// <summary>
    /// BubbleSortWithFlagTest 的摘要描述
    /// </summary>
    [TestClass]
    public class BubbleSortWithFlagTest
    {
        public ISortAlgorithms<int[]> GetSystemUnderTest()
        {
            return new BubbleSortWithFlag();
        }

        [TestMethod]
        public void TestBubbleSortWithFlag_Case1()
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
        public void TestBubbleSortWithFlag_Case2()
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
        public void TestBubbleSortWithFlag_Case3()
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
    }
}

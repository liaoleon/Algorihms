using System;
using BMICalculation.Factory;
using BMICalculation.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMICalculation.UnitTest
{
    [TestClass]
    public class ManBMITest
    {
        public BMIBase GetSystemUnderTest()
        {
            return new ManBMI();
        }

        [TestMethod]
        public void ManBMI_Height180cm_Weight50kg_should過瘦()
        {
            //arrange 
            string expected = Message.Skinny;
            float height = 1.80f;
            int weight = 60;
            var sut = GetSystemUnderTest();
            //act
            int bmi = sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
            //Assert.AreEqual(19, bmi);
        }

        [TestMethod]
        public void ManBMI_Height180cm_Weight75kg_should正常()
        {
            //arrange 
            string expected = Message.Normal;
            float height = 1.80f;
            int weight = 75;
            var sut = GetSystemUnderTest();
            //act
            sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ManBMI_Height180cm_Weight100kg_should過胖()
        {
            //arrange 
            string expected = Message.Fat;
            float height = 1.80f;
            int weight = 100;
            var sut = GetSystemUnderTest();
            //act
            sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}

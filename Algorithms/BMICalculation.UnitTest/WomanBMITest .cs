using System;
using BMICalculation.Factory;
using BMICalculation.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMICalculation.UnitTest
{
    [TestClass]
    public class WomanBMITest
    {
        public BMIBase GetSystemUnderTest()
        {
            return new WomanBMI();
        }

        [TestMethod]
        public void ManBMI_Height156cm_Weight40kg_should過瘦()
        {
            //arrange 
            string expected = Message.Skinny;
            float height = 1.56f;
            int weight = 40;
            var sut = GetSystemUnderTest();
            //act
            sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ManBMI_Height160cm_Weight50kg_should正常()
        {
            //arrange 
            string expected = Message.Normal;
            float height = 1.60f;
            int weight = 50;
            var sut = GetSystemUnderTest();
            //act
            int bmi = sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ManBMI_Height162cm_Weight60kg_should過胖()
        {
            //arrange 
            string expected = Message.Fat;
            float height = 1.62f;
            int weight = 60;
            var sut = GetSystemUnderTest();
            //act
            sut.BMICal(height, weight);
            string result = sut.GetMessage();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}

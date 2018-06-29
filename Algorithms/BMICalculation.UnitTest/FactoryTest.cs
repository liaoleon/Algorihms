using System;
using BMICalculation.Factory;
using BMICalculation.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMICalculation.UnitTest
{
    [TestClass]
    public class FactoryTest
    {
        public BMIFactory GetSystemUnderTest()
        {
            return new BMIFactory();
        }
        [TestMethod]
        public void FactoryTest_Man_ShouldGetManBMI()
        {
            //arrange
            var expected = typeof(ManBMI);
            var factory = new BMIFactory();
            //act
            var actual = factory.GetBMIEntity(Sex.Man).GetType();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FactoryTest_Man_ShouldGetWomanBMI()
        {
            //arrange
            var expected = typeof(WomanBMI);
            var factory = new BMIFactory();
            //act
            var actual = factory.GetBMIEntity(Sex.Woman).GetType();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

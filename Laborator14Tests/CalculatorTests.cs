using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laborator14;
using System;
using System.Collections.Generic;
using System.Text;
using static Laborator14.IParalipiped;
using Moq;

namespace Laborator14.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void VolumTest()
        {
            //Arrange

            Calculator calculator = new Calculator();
             
            int expectedResult = 6;

            //Act

            var mock = new Mock<IParalipiped>();
            mock.Setup(paralipiped => paralipiped.X).Returns(1);
            mock.Setup(paralipiped => paralipiped.Y).Returns(2);
            mock.Setup(paralipiped => paralipiped.Z).Returns(3);

            IParalipiped mockobj = mock.Object;

            var actualResult = calculator.Volum(mock.Object);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
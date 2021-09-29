using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void PriceTest_Is410()
        {
            //Arrange
            OresundCar car = new OresundCar();

            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(410, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest_IsOresundCar()
        {
            //Arrange
            OresundCar car = new OresundCar();

            //Act
            string actualValue = car.VehicleType();

            //Assert
            Assert.AreEqual("Oresund car", actualValue);
        }
    }
}
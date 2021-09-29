using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest_Is240()
        {
            //Arrange
            Car car = new Car();
            
            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(240, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest_IsCar()
        {
            //Arrange
            Car car = new Car();

            //Act
            string actualValue = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", actualValue);
        }
    }
}
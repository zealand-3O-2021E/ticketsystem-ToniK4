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
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "A license plate longer than 7 characters was inappropriately allowed.")]
        public void Licenseplate_ThrowsArgument_IfLongerThan7()
        {
            //Arrange
            Car car = new Car();

            //Act

            car.Licenseplate = "1fdfsfdsf333";

            //Assert

        }

        [TestMethod()]
        public void Licenseplate_Set()
        {
            //Arrange
            Car car = new Car();

            //Act

            car.Licenseplate = "gfd6";

            //Assert

        }
    }
}
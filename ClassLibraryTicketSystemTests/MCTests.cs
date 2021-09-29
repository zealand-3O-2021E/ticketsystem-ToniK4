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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest_Is125()
        {
            //Arrange
            MC MC = new MC();

            //Act
            double actualValue = MC.Price();

            //Assert
            Assert.AreEqual(125, actualValue);
        }
        [TestMethod()]
        public void PriceTest_WithDiscountIs118_75()
        {
            //Arrange
            MC MC = new MC() { Brobizz = true };

            //Act
            double actualValue = MC.Price();

            //Assert
            Assert.AreEqual(118.75, actualValue, 0.1);
        }

        [TestMethod()]
        public void VehicleTypeTest_IsMC()
        {
            //Arrange
            MC MC = new MC();

            //Act
            string actualValue = MC.VehicleType();

            //Assert
            Assert.AreEqual("MC", actualValue);
        }
    }
}
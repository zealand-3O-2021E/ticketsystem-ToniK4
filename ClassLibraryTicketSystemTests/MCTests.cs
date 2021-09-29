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
        public void VehicleTest_IsMC()
        {
            //Arrange
            MC MC = new MC();

            //Act
            string actualValue = MC.Vehicle();

            //Assert
            Assert.AreEqual("MC", actualValue);
        }
    }
}
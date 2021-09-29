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
    public class OresundMCTests
    {
        [TestMethod()]
        public void PriceTest_Is410()
        {
            //Arrange
            OresundMC MC = new OresundMC();

            //Act
            double actualValue = MC.Price();

            //Assert
            Assert.AreEqual(210, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest_IsOresundMC()
        {
            //Arrange
            OresundMC MC = new OresundMC();

            //Act
            string actualValue = MC.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", actualValue);
        }
    }
}
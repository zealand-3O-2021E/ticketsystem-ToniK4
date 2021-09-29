using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreCarTests
    {
        [TestMethod()]
        public void PriceTest_WithDiscountsIs182_4()
        {
            //Arrange
            StoreCar car = new StoreCar() { Brobizz = true, Date = new DateTime(2021, 10, 02) };

            //Act
            double actualValue = car.Price();

            //Assert
            Assert.AreEqual(182.4, actualValue, 0.1);
        }
    }
}
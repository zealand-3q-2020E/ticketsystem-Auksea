using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriceCar()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = false;

            var Car = new Car(licenseplate, date, brobizz, false);
            double result = Car.Price();

            Assert.AreEqual(240, result); 

        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = false;

            var Car = new Car(licenseplate, date, brobizz, false);
            string result = Car.VehicleType();

            Assert.AreEqual("Car", result);
        }

        [TestMethod]
        public void MCPriceTest()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = false;
            bool weekenddiscount = false;

            var MC = new MC(licenseplate, date, brobizz, weekenddiscount);
            double result = MC.Price();

            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void MCVehicleType()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = false;
            bool weekenddiscount = false;

            var MC = new MC(licenseplate, date, brobizz, false);
            string result = MC.VehicleType();

            Assert.AreEqual("MC", result);
        }
        [TestMethod]
        public void LicensePlateException()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = false;


            try
            {
                //Vehicle.LicensePlateLength();
                var Vehicle = new Vehicle(licenseplate, date, brobizz, false);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }

        }
       [TestMethod]
       public void BrobizzDiscountCar()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = true;
            bool weekenddiscount = false;

            var Car = new Car(licenseplate, date, brobizz, weekenddiscount);
            double result = Car.Price();

            Assert.AreEqual(228, result);
        }
        [TestMethod]
        public void BrobizzDiscountMC()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = true;
            bool weekenddiscount = false;

            var MC = new MC(licenseplate, date, brobizz, false);
            double result = MC.Price();

            Assert.AreEqual(118.5, result);
        }
        [TestMethod]
        public void WeekendDiscountTest()
        {
            string licenseplate = "1234576";
            DateTime date = new DateTime(2019, 12, 09);
            bool brobizz = true;
            bool weekenddiscount = true;

            var Car = new Car(licenseplate, date, brobizz, weekenddiscount);
            double result = Car.Price();

            Assert.AreEqual(192, result);

        }
    }
}

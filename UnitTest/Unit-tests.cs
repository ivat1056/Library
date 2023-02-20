using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //1
        public void CheckingForARegularExpression1()
        {
            string vin = "YS3AL76L1R7002116";
            bool Checkin = VIN_LIB.CheckVIN(vin);
            Assert.AreNotEqual(Checkin, true);
        }
       

        [TestMethod] //2
        public void CheckingForAnEmptyValue()
        {
            string vin = "JH4KA4540LC016127";
            Assert.IsNotNull(vin);
        }


        [TestMethod] //3
        public void CheckingForAnEmptyValue2()
        {
            string vin = null;
            Assert.IsNull(vin);
        }
    }
}

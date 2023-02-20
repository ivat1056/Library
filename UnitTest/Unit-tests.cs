using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //1
        public void CheckingForARegularExpression1() // простой
        {
            string vin = "YS3AL76L1R7002116";
            bool Checkin = VIN_LIB.CheckVIN(vin);
            Assert.AreNotEqual(Checkin, true);
        }

        [TestMethod] //2
        public void CheckingForARegularExpression2() // простой
        {
            string vin = "11A5513P123137478";
            bool Checkin = VIN_LIB.CheckVIN(vin);
            Assert.IsFalse(Checkin);
        }
        [TestMethod] //3
        public void CheckingForAnEmptyValue() // сложные
        {
            string vin = "JH4KA4540LC016127";
            Assert.IsNotNull(vin);
        }


        [TestMethod] //4
        public void CheckingForAnEmptyValue2() // сложные
        {
            string vin = null;
            Assert.IsNull(vin);
        }
        [TestMethod] //5
        public void CheckingType() // сложный 
        {
            string vin = "2FMDA5146TBC22506";
            bool Checkin = VIN_LIB.CheckVIN(vin);
            Assert.IsInstanceOfType(Checkin, typeof(bool));
        }
        [TestMethod] //6
        
    }
}

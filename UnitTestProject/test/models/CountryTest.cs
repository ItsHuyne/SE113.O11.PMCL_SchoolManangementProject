using Đồ_án.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.models
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void CountryTest_ctor()
        {
            var country = new Country()
            {
                CountryName = "Test",
            };

            Assert.IsNotNull(country);
            Assert.AreEqual("Test", country.CountryName);
        }
    }
}

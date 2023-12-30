using Đồ_án.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.models
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void AddressTest_ctor()
        {
            var address = new Address()
            {
                NameAddress = "123",
                List = new System.Collections.Generic.List<Address>() { }
            };

            Assert.IsNotNull(address);
            Assert.AreEqual("123", address.NameAddress);
            Assert.IsNotNull(address.List);
        }
    }
}

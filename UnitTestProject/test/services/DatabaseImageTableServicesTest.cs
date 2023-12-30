using Đồ_án.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.services
{
    [TestClass]
    public class DatabaseImageTableServicesTest
    {
        [TestMethod]
        public void DatabaseImageTableServicesTest_ctor()
        {
            var databaseImageTableServices = new DatabaseImageTableServices();
            Assert.IsNotNull(databaseImageTableServices);
        }
    }
}

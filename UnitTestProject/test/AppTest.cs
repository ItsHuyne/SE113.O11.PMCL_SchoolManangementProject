using Đồ_án;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void AppTest_ctor()
        {
            var app = new App();
            Assert.IsNotNull(app);
        }
    }
}

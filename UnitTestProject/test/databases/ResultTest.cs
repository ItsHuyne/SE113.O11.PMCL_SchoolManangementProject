using Đồ_án.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.databases
{
    [TestClass]
    public class ResultTest
    {
        [TestMethod]
        public void ResultTest_ctor()
        {
            var result = new Result()
            {
                IdStudent = "",
                CK=1,
                Class = new Class() { },
                DiemTB = 1,
                GK = 1,
                IdClass = "1",
                QT = 1,
                TH = 1,
                User = new User() { }
            };

            Assert.IsNotNull(result);
        }
    }
}

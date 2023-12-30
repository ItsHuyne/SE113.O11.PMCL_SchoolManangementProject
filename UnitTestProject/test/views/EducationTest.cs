using Đồ_án.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.views
{
    [TestClass]
    public class EducationTest : GlobalSetup
    {
        [TestMethod]
        public void EducationTest_ctor()
        {
            var education = new Education();
            Assert.IsNotNull(education);
        }
    }
}

using Đồ_án.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.components.educationTest
{
    [TestClass]
    public class ResultTest : GlobalSetup
    {
        [TestMethod]
        public void result_Render()
        {
            var resultRender = new Result();
            Assert.IsNotNull(resultRender);
        }
    }
}

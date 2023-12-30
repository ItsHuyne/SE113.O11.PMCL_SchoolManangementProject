using Đồ_án.Components;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.components.educationTest
{
    [TestClass]
    public class InfomationTest : GlobalSetup
    {
        [TestMethod]
        public void information_Render()
        {
            var informationRender = new Information();
            Assert.IsNotNull(informationRender);
        }
    }
}

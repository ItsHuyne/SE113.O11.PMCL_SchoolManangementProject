using Đồ_án.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.components
{
    [TestClass]
    public class BindablePasswordBoxTest
    {
        [TestMethod]
        public void BindablePasswordBoxTest_ctor()
        {
            var bindablePasswordBox = new BindablePasswordBox();
            bindablePasswordBox.Password = "12313";
            bindablePasswordBox.TextPasswordBox = "12313";

            Assert.AreEqual("12313", bindablePasswordBox.Password);
            Assert.AreEqual("12313", bindablePasswordBox.TextPasswordBox);
        }
    }
}

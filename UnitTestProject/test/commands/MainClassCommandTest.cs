using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class MainClassCommandTest
    {
        [TestMethod]
        public void MainClassCommandTest_ctor()
        {
            var mainClassViewModel = new MainClassViewModel();
            var mainClassCommand = new MainClassCommand(mainClassViewModel);
            Assert.IsNotNull(mainClassCommand);
        }
    }
}

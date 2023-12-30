using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class ExitCommandTest
    {
        [TestMethod]
        public void ExitCommand_ctor()
        {
            var exitViewModel = new ExitViewModel();
            var exitCommand = new ExitCommand(exitViewModel);
            Assert.IsNotNull(exitCommand);
        }
    }
}

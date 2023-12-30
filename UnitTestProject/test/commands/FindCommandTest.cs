using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class FindCommandTest
    {
        [TestMethod]
        public void FindCommandTest_ctor()
        {
            var findViewModel = new FindViewModel();
            var findCommand = new FindCommand(findViewModel);
            Assert.IsNotNull(findCommand);
        }
    }
}

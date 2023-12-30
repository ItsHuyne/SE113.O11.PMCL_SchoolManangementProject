using Đồ_án.Command;
using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class ConfirmInformationCommandTest
    {
        [TestMethod]
        public void confirmInformationCommand_ctor()
        {
            var confirmInformationViewModel = new ConfirmInformationViewModel();
            var confirmInformationCommand = new ConfirmInformationCommand(confirmInformationViewModel);
            Assert.IsNotNull(confirmInformationCommand);
        }
    }
}

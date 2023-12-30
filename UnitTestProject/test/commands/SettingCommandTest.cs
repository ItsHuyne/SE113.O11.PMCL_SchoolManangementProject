using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class SettingCommandTest
    {
        [TestMethod]
        public void SettingCommandTest_ctor()
        {
            var settingViewModel = new SettingViewModel();
            var settingCommand = new SettingCommand(settingViewModel);
            Assert.IsNotNull(settingCommand);
        }
    }
}

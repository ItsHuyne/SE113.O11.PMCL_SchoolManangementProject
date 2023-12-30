using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class ProfileCommandTest
    {
        [TestMethod]
        public void ProfileCommandTest_ctor()
        {
            var profileViewModel = new ProfileViewModel();
            var profileCommand = new ProfileCommand(profileViewModel);
            Assert.IsNotNull(profileCommand);
        }
    }
}

using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels
{
    [TestClass]
    public class ExitViewModelTest : GlobalSetup
    {
        [TestMethod]
        public void ExitViewModelTest_ctor()
        {
            var exitViewModel = new ExitViewModel();
            Assert.IsNotNull(exitViewModel);

            exitViewModel.OnExcute();
        }
    }
}

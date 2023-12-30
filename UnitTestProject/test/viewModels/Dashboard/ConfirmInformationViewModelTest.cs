using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard
{
    [TestClass]
    public class ConfirmInformationViewModelTest
    {
        [TestMethod]
        public void ConfirmInformationViewModelTest_ctor()
        {
            var confirmInformationViewModel = new ConfirmInformationViewModel();
            Assert.IsNotNull(confirmInformationViewModel);
            Assert.IsNotNull(confirmInformationViewModel.ConfirmInformationCommand);

            confirmInformationViewModel.Student = new Đồ_án.Database.User();
            Assert.IsNotNull(confirmInformationViewModel.Student);

        }
    }
}

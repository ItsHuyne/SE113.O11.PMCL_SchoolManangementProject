using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels
{
    [TestClass]
    public class EditInformationViewModelTest
    {
        [TestMethod]
        public void EditInformationViewModelTest_ctor()
        {
            var EditInformationViewModel = new EditInformationViewModel();
            Assert.IsFalse(EditInformationViewModel.IsOpened);
            EditInformationViewModel.OnExcute();

            Assert.IsNotNull(EditInformationViewModel.EditInformation);
            EditInformationViewModel.IsOpened = true;
            EditInformationViewModel.OnExcute();
        }
    }
}

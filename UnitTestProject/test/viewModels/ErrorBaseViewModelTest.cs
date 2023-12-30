using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace UnitTestProject.test.viewModels
{
    [TestClass]
    public class ErrorBaseViewModelTest
    {
        [TestMethod]
        public void ErrorBaseViewModelTest_ctor()
        {
            var errorBaseViewModelTest = new ErrorBaseViewModel();
            Assert.AreEqual(errorBaseViewModelTest.HasErrors,false);

            errorBaseViewModelTest.AddError("1");
            errorBaseViewModelTest.AddError("2");
            Assert.AreEqual(errorBaseViewModelTest.HasErrors, true);

            errorBaseViewModelTest.GetErrors("2");
            errorBaseViewModelTest.ClearErrors("2");

            errorBaseViewModelTest.ClearAllErrors();
        }
    }
}

using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard
{
    [TestClass]
    public class FindViewModelTest
    {
        [TestMethod]
        public void FindViewModelTest_ctor()
        {
            var FindViewModelTest = new FindViewModel();
            Assert.IsNotNull(FindViewModelTest);
            Assert.IsNotNull(FindViewModelTest.FindCommand);
            FindViewModelTest.FindID = "123";
            Assert.IsNotNull(FindViewModelTest.FindID);

            FindViewModelTest.ListProfileStudent = new System.Collections.Generic.List<Đồ_án.Model.ProfileStudent>() {  };
            Assert.IsNotNull(FindViewModelTest.ListProfileStudent);
            FindViewModelTest.OnExcute();
        }
    }
}

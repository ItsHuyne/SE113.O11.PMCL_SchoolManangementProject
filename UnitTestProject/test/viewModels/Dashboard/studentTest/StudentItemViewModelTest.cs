using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.studentTest
{
    [TestClass]
    public class StudentItemViewModelTest
    {
        [TestMethod]
        public void StudentItemViewModelTest_successful()
        {
            var studentItemViewModel = new StudentItemViewModel("123", "456", "789");

            Assert.AreEqual("123", studentItemViewModel.ClassName);
            Assert.AreEqual("456", studentItemViewModel.IdClass);
            Assert.AreEqual("789", studentItemViewModel.LopTRG);
        }
    }
}

using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.studentTest
{
    [TestClass]
    public class MainStudentViewModelTest
    {
        [TestMethod]
        public void MainStudentViewModelTest_successful()
        {
            var mainStudentViewModel = new MainStudentViewModel();

            Assert.IsNotNull(mainStudentViewModel);
        }
    }
}

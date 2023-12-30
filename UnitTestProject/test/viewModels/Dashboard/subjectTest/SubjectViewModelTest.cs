using Đồ_án.ViewModel.DashBroad.Subject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.subjectTest
{
    [TestClass]
    public class SubjectViewModelTest
    {
        [TestMethod]
        public void SubjectViewModelTest_successful()
        {
            var subjectViewModel = new SubjectViewModel();

            subjectViewModel.NewSubject = new Đồ_án.Database.Subject() { };
            subjectViewModel.UpdateSubject = new Đồ_án.Database.Subject() { };
            subjectViewModel.Filter = "123";

            Assert.IsNotNull(subjectViewModel.NewSubject);
            Assert.IsNotNull(subjectViewModel.UpdateSubject);
            Assert.IsNotNull(subjectViewModel.Filter);
            Assert.IsNotNull(subjectViewModel.SubjectFiltering);
        }
    }
}

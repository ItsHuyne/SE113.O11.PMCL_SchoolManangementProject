using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.educationTest
{
    [TestClass]
    public class EducationViewModelTest
    {
        [TestMethod]
        public void EducationViewModelTest_succesful()
        {
            var educationViewModel = new EducationViewModel();
            Assert.IsNotNull(educationViewModel);

            educationViewModel.Education = null;
            Assert.IsNull(educationViewModel.Education);
        }
    }
}

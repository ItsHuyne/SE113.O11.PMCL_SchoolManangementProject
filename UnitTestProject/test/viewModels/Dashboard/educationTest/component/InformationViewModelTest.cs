using Đồ_án.ViewModel;
using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.educationTest.component
{
    [TestClass]
    public class InformationViewModelTest
    {
        [TestMethod]
        public void InformationViewModelTest_successful()
        {
            LoginServices.CurrentUser = new Đồ_án.Database.User()
            {
                UserRole = new Đồ_án.Database.UserRole()
                {
                    Role = "student",
                },
                DetailUser = new Đồ_án.Database.DetailUser()
                {
                    Gender = false
                }
            };
            var informationViewModel = new InformationViewModel();

            Assert.IsNotNull(informationViewModel.Gender);
            LoginServices.CurrentUser.DetailUser.Gender = null;
            Assert.AreEqual("null", informationViewModel.Gender);
            LoginServices.CurrentUser.DetailUser.Gender = true;
            Assert.AreEqual("Male", informationViewModel.Gender);
        }
    }
}

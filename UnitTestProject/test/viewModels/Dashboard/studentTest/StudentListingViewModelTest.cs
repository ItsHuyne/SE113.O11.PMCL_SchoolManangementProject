using Đồ_án.ViewModel.DashBroad;
using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject.test.viewModels.Dashboard.studentTest
{
    [TestClass]
    public class StudentListingViewModelTest
    {
        [TestMethod]
        public void StudentListingViewModelTest_successful()
        {
            LoginServices.CurrentUser = new Đồ_án.Database.User()
            {
                IdUser = "admin",
                UserRole = new Đồ_án.Database.UserRole()
                {
                    Role = "student",
                },
                DetailUser = new Đồ_án.Database.DetailUser()
                {
                    Gender = false
                }
            };
            var studentListingViewModel = new StudentListingViewModel();

            studentListingViewModel.ListRegisterClasses = new ObservableCollection<Đồ_án.Database.Class>() { };
            studentListingViewModel.Filter = "123";
            studentListingViewModel.IdSubject = "123";

            Assert.IsNotNull(studentListingViewModel.ListRegisterClasses);
            Assert.IsNotNull(studentListingViewModel.Filter);
            Assert.IsNotNull(studentListingViewModel.Class);
            Assert.IsNotNull(studentListingViewModel.IdSubject);


        }
    }
}

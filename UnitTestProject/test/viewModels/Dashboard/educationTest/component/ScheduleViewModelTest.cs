using Đồ_án.ViewModel.DashBroad.Education.Components;
using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject.test.viewModels.Dashboard.educationTest.component
{
    [TestClass]
    public class ScheduleViewModelTest
    {
        [TestMethod]
        public void ScheduleViewModelTest_successful()
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
            var scheduleViewModel = new ScheduleViewModel();

            scheduleViewModel.ListNotifycations = new ObservableCollection<Đồ_án.Database.Notifycation>() { };
            scheduleViewModel.OpenNotifycation = new Đồ_án.Database.Notifycation() { };

            Assert.IsNotNull(scheduleViewModel.ListNotifycations);
            Assert.IsNotNull(scheduleViewModel.OpenNotifycation);
        }
    }
}

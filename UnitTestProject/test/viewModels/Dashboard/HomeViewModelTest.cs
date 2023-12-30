using Đồ_án.View;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard
{
    [TestClass]
    public class HomeViewModelTest : GlobalSetup
    {
        [TestMethod]
        public void HomeViewModelTest_ctor()
        {
            var HomeViewModelTest = new HomeViewModel();
            Assert.IsNotNull(HomeViewModelTest);

            Assert.IsNotNull(HomeViewModelTest.HomeFrame);
            Assert.IsNotNull(HomeViewModelTest.InsertNewNotifycation);
            Assert.IsNotNull(HomeViewModelTest.InsertNewRegisterNotifycation);
            Assert.IsNotNull(HomeViewModelTest.AddNotifycation);
            Assert.IsNotNull(HomeViewModelTest.DeleteCommand);
            Assert.IsNotNull(HomeViewModelTest.UpdateInformation);
            Assert.IsNotNull(HomeViewModelTest.Update);
            Assert.IsNotNull(HomeViewModelTest.DeleteAll);
            Assert.IsNotNull(HomeViewModelTest.ListNotifycation);

            HomeViewModelTest.SelectedDate = DateTime.Now;
            Assert.IsNotNull(HomeViewModelTest.SelectedDate);

            HomeViewModelTest.UpdateNotifycation = new Đồ_án.Database.Notifycation();
            Assert.IsNotNull(HomeViewModelTest.UpdateNotifycation);

            HomeViewModelTest.NewNotifycation = new Đồ_án.Database.Notifycation();
            Assert.IsNotNull(HomeViewModelTest.NewNotifycation);

            Assert.AreEqual("ABC", HomeViewModelTest.SelectedType);
            HomeViewModelTest.SelectedType = "123";
            Assert.AreEqual("123", HomeViewModelTest.SelectedType);
        }
    }
}

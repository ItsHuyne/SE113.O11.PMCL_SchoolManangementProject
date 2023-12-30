using Đồ_án.ViewModel;
using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.classTest
{
    [TestClass]
    public class ClassListingViewModelTest
    {
        [TestMethod]
        public void ClassListingViewModelTest_ctor()
        {
            var store = new ClassDataStore()
            {
                SelectedStudent = new Đồ_án.Database.User()
                {
                    CCCD = "456"
                },
            };
            var classListing = new ClassListingViewModel(store);
            classListing.IdStudent = "1952111";
            classListing.SelectedStudent = new Đồ_án.Database.User()
            {
                CCCD = "456"
            };

            Assert.IsNull(classListing.MainClass);
            Assert.IsNotNull(classListing.List);
            Assert.IsNotNull(classListing.Student);
            Assert.IsNotNull(classListing.DetailStudent);
            Assert.IsNotNull(classListing.IdStudent);

            classListing.DeleteCommand.Execute(new {});
            classListing.DeleteCommand.Execute(new {});

        }
    }
}

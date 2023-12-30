using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.classTest
{
    [TestClass]
    public class ClassDetailViewModelTest
    {
        [TestMethod]
        public void ClassDetailViewModelTest_ctor()
        {
            var store = new ClassDataStore()
            {
                SelectedStudent = new Đồ_án.Database.User()
                {
                    CCCD = "456"
                },
            };
            var classDetail = new ClassDetailViewModel(store);

            classDetail.SelectedDetailStudent = new Đồ_án.Database.User() { CCCD = "123" };
            Assert.AreEqual("123", classDetail.SelectedDetailStudent.CCCD);

            classDetail.UpdatePassWord = "1231";
            Assert.AreEqual("1231", classDetail.UpdatePassWord);

            //classDetail.Update(new { });
        }
    }
}

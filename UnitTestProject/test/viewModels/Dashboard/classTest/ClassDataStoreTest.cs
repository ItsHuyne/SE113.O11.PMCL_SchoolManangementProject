using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard.classTest
{
    [TestClass]
    public class ClassDataStoreTest
    {
        [TestMethod]
        public void ClassDataStoreTest_ctor()
        {
            var store = new ClassDataStore
            {
                SelectedStudent = new Đồ_án.Database.User()
            };
            Assert.IsNotNull(store.SelectedStudent);
        }
    }
}

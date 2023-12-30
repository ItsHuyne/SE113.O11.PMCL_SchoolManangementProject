using Đồ_án.ViewModel.DashBroad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject.test.viewModels.Dashboard.studentTest
{
    [TestClass]
    public class StudentDataStoreTest
    {
        [TestMethod]
        public void StudentDataStoreTest_successful()
        {
            var studentDataStore = new StudentDataStore();

            studentDataStore.CList = new ObservableCollection<Đồ_án.Database.Class>() { };
            studentDataStore.SelectedClass = new Đồ_án.Database.Class() { };

            Assert.IsNotNull(studentDataStore.SelectedClass);
            Assert.IsNotNull(studentDataStore.CList);
        }
    }
}

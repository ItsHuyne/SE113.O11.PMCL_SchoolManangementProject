using Đồ_án.ViewModel.DashBroad.Teacher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject.test.viewModels.Dashboard.teacherTest
{
    [TestClass]
    public class TeacherViewModelTest
    {
        [TestMethod]
        public void TeacherViewModelTest_successful()
        {
            var teacherViewModel = new TeacherViewModel();

            teacherViewModel.Index = true;
            teacherViewModel.ListTeacher = new ObservableCollection<Đồ_án.Database.User>() { };
            teacherViewModel.IdTeacher = "admin";
            teacherViewModel.UpdateTeacher = new Đồ_án.Database.User() { };
            teacherViewModel.Filter = "";
            teacherViewModel.Filter = "123";

            Assert.IsNotNull(teacherViewModel.Index);
            Assert.IsNotNull(teacherViewModel.NewDetailTeacher);
            Assert.IsNotNull(teacherViewModel.IdTeacher);
            Assert.IsNotNull(teacherViewModel.UpdateTeacher);
            Assert.IsNotNull(teacherViewModel.UpdatePassWord);
            Assert.IsNotNull(teacherViewModel.Filter);
        }
    }
}

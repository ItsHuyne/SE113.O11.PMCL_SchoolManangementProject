using Đồ_án.ViewModel;
using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using static Đồ_án.ViewModel.ResultViewModel;

namespace UnitTestProject.test.viewModels.Dashboard.educationTest.component
{
    [TestClass]
    public class ResultViewModelTest
    {
        private ResultViewModel resultViewModel;

        public ResultViewModelTest()
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
            resultViewModel = new ResultViewModel();
        }

        [TestMethod]
        public void ResultViewModelTest_ctor_successful()
        {
            resultViewModel.IsChecked = true;
            resultViewModel.SelectedUser = "1231";
            Assert.IsTrue(resultViewModel.IsChecked);

            LoginServices.CurrentUser.UserRole.Role = "ADMIN";
            resultViewModel = new ResultViewModel();
        }

        [TestMethod]
        public void ResultViewModelTest_TeacherResultDisplays()
        {
            resultViewModel.TeacherResultDisplays = new ObservableCollection<TeacherResultDisplay>()
            {
                new TeacherResultDisplay()
                {
                    List = new List<TeacherLopDisplay> {
                        new TeacherLopDisplay()
                        {
                            List = new List<TeacherResultProperties>()
                            {
                                new TeacherResultProperties()
                                {
                                    CK = 1.23,
                                    GK = 7,
                                    HoTen = "1231",
                                    MaSV = "1212",
                                    QT = 2,
                                    TB = 3,
                                    TH = 3
                                }
                            },
                            MaLop = "",
                            HeSo = "",
                            TB_Lop = 3.34
                        }
                    },
                    HK_Year = ""
                }
            };
            Assert.IsNotNull(resultViewModel.TeacherResultDisplays);

        }

        [TestMethod]
        public void ResultViewModelTest_StudentResultDisplay()
        {
            resultViewModel.StudentResultDisplays = new ObservableCollection<StudentResultDisplay>() {
                new StudentResultDisplay()
                {
                    List = new List<StudentResultProperties> {
                        new StudentResultProperties()
                        {
                            CK = "",
                            MaMH = "",
                            MaLop = "",
                            TC = 1,
                            QT = "",
                            GK = "",
                            TH = "",
                            TB = 1
                        }
                    },
                    HK_Year = "",
                    TB_HK = 1.25d,
                }
            };

            Assert.IsNotNull(resultViewModel.StudentResultDisplays);
        }
    }
}

using Đồ_án.ViewModel;
using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard
{
    [TestClass]
    public class ProfileViewModelTest : GlobalSetup
    {
        [TestMethod]
        public void ProfileViewModelTest_ctor()
        {
            LoginServices.CurrentUser = new Đồ_án.Database.User()
            {
                UserRole = new Đồ_án.Database.UserRole()
                {
                    Role = "student",
                }
            };
            var profileViewModel = new ProfileViewModel();
            Assert.IsNotNull(profileViewModel);

            Assert.IsNotNull(profileViewModel.ProfileCommand);
            Assert.IsNotNull(profileViewModel.FindCommand);
            Assert.IsNotNull(profileViewModel.IsExpanded);
            profileViewModel.Student = null;
            Assert.IsTrue(profileViewModel.IsExpanded);

            profileViewModel.Father = new Đồ_án.Database.Relative();
            profileViewModel.Mother = new Đồ_án.Database.Relative();
            profileViewModel.Gender = "male";

            Assert.IsNotNull(profileViewModel.Father);
            Assert.IsNotNull(profileViewModel.Mother);
            Assert.IsNotNull(profileViewModel.Gender);

            profileViewModel.FindID = "admin";
            Assert.IsNotNull(profileViewModel.FindID);
            //profileViewModel.OnExcute();


        }
    }
}

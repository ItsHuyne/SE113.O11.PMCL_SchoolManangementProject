using Đồ_án.ViewModel.Login.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace UnitTestProject.test.services
{
    [TestClass]
    public class UserServicesTest
    {
        [TestMethod]
        public async Task UserServicesTest_ctor()
        {
            var userServices = new UserServices();

            Assert.IsNotNull(userServices.GetUserInfo());
            await userServices.GetRoleById("admin");
            Assert.IsNotNull(userServices.GetUserByGmail("demostudent@demostudent.demostudent"));
            await userServices.GetFatherbyId("admin");
            await userServices.GetMotherbyId("admin");
            await userServices.GetFather(new Đồ_án.Database.User() { CCCD = "demostudentCCCD" });
            await userServices.GetMother(new Đồ_án.Database.User() { CCCD = "demostudentCCCD" });
            userServices.IsUsedEmail("demostudent@demostudent.demostudent");
        }
    }
}

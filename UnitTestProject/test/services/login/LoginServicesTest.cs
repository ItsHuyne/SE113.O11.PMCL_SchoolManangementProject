using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.services.login
{
    [TestClass]
    public class LoginServicesTest
    {
        [TestMethod]
        public void LoginServicesTest_ctor()
        {
            var loginService = new LoginServices();
            Assert.IsNotNull(loginService);

            loginService.Login("admin");
            loginService.IsUserAuthentic("admin", "admin");
            loginService.InitRememberedAccount();
            loginService.IsIdUserIdentical("admin");
            LoginServices.Encrypt("admin");
        }
    }
}

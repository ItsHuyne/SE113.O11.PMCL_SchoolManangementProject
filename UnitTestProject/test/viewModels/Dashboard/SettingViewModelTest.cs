using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.viewModels.Dashboard
{
    [TestClass]
    public class SettingViewModelTest
    {
        [TestMethod]
        public void SettingViewModelTest_ctor()
        {
            var settingViewModelTest = new SettingViewModel();
            Assert.IsNotNull(settingViewModelTest);

            settingViewModelTest.PassWord = "123141";
            Assert.IsNotNull(settingViewModelTest.PassWord);
            settingViewModelTest.PassWord = "";


            settingViewModelTest.NewPassWord = "1231411231";
            settingViewModelTest.ConfirmNewPassword = "";
            settingViewModelTest.ConfirmNewPassword = "123141123";
            settingViewModelTest.ConfirmNewPassword = "1231411231";

            Assert.IsNotNull(settingViewModelTest.NewPassWord);
            Assert.IsNotNull(settingViewModelTest.ConfirmNewPassword);
            settingViewModelTest.NewPassWord = "";

            Assert.IsTrue(settingViewModelTest.HasErrors);
            settingViewModelTest.GetErrors(nameof(settingViewModelTest.ConfirmNewPassword));

        }
    }
}

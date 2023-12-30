using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Windows;

namespace UnitTestProject.test.viewModels.Login
{
    [TestClass]
    public class InverseVisibilityConverterTest
    {
        [TestMethod]
        public void InverseVisibilityConverterTest_successful()
        {
            var inverseVisibilityConverter = new InverseVisibilityConverter();

            inverseVisibilityConverter.Convert(Visibility.Visible, null, new { }, new CultureInfo("en") { });
            inverseVisibilityConverter.Convert(Visibility.Hidden, null, new { }, new CultureInfo("en") { });
            Assert.ThrowsException<NotImplementedException>(() => inverseVisibilityConverter.ConvertBack(new { }, null, new { }, new CultureInfo("en") { }));
        }
    }
}

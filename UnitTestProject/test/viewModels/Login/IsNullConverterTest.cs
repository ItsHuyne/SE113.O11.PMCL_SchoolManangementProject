using Đồ_án.ViewModel.Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace UnitTestProject.test.viewModels.Login
{
    [TestClass]
    public class IsNullConverterTest
    {
        [TestMethod]
        public void IsNullConverterTest_successful()
        {
            IServiceProvider serviceProvider = null;
            var isNullConverter = new IsNullConverter();

            isNullConverter.Convert(new { }, null, new { }, new CultureInfo("en") { });
            isNullConverter.ProvideValue(serviceProvider);
            Assert.ThrowsException<InvalidOperationException>(() => isNullConverter.ConvertBack(new { }, null, new { }, new CultureInfo("en") { }));
        }
    }
}

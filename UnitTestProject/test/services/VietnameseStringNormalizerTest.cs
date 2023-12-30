using Đồ_án.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.services
{
    [TestClass]
    public class VietnameseStringNormalizerTest
    {
        [TestMethod]
        public void VietnameseStringNormalizerTest_ctor()
        {
            var vietnameseStringNormalizer = new VietnameseStringNormalizer();
            Assert.IsNotNull(vietnameseStringNormalizer);

            vietnameseStringNormalizer.Normalize();
            Assert.IsNotNull(VietnameseStringNormalizer.Instance);
        }
    }
}

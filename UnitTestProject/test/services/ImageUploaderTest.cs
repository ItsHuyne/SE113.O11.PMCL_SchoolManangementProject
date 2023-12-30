using Đồ_án.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.services
{
    [TestClass]
    public class ImageUploaderTest
    {
        [TestMethod]
        public void ImageUploaderTest_ctor()
        {
            var imageUploader = new ImageUploader();
            Assert.IsNotNull(imageUploader);
        }
    }
}

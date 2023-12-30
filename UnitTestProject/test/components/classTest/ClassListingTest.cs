using Đồ_án.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.components.classTest
{
    [TestClass]
    public class ClassListingTest
    {
        [TestMethod]
        public void classListing_Render()
        {
            var classListingRender = new ClassListing();
            Assert.IsNotNull(classListingRender);
        }
    }
}

using Đồ_án.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.test.components.classTest
{
    [TestClass]
    public class ClassDetailTest
    {
        [TestMethod]
        public void render_ClassDetail()
        {
            var renderClassDetail = new ClassDetail();
            Assert.IsNotNull(renderClassDetail);
        }
    }
}

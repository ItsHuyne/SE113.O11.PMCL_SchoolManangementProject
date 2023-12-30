using Đồ_án;
using Đồ_án.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.test.views
{
    [TestClass]
    public class EducationViewTest : GlobalSetup
    {
        [TestMethod]
        public void EducationViewTest_ctor()
        {
            var EducationViewTest = new Education();
            Assert.IsNotNull(EducationViewTest);
        }
    }
}

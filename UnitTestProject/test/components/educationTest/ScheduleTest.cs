using Đồ_án.Components.Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.components.educationTest
{
    [TestClass]
    public class ScheduleTest : GlobalSetup
    {
        [TestMethod]
        public void schedule_Render()
        {
            var scheduleRender = new Schedule();
            Assert.IsNotNull(scheduleRender);
        }
    }
}

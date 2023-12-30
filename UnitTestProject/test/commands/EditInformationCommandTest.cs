using Đồ_án.Command;
using Đồ_án.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.test.commands
{
    [TestClass]
    public class EditInformationCommandTest
    {
        [TestMethod]
        public void editInformationCommand_ctor()
        {
            var editInformationViewModel = new EditInformationViewModel();
            var editInformationCommand = new EditInformationCommand(editInformationViewModel);
            Assert.IsNotNull(editInformationCommand);
        }
    }
}

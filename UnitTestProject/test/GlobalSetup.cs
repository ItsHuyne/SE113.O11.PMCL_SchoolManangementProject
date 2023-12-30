using System.Reflection;
using System;
using Đồ_án.ViewModel;
using Đồ_án;
using System.Windows;
using Đồ_án.ViewModel.DashBroad.Education.Components;
using Đồ_án.ViewModel.Login;

namespace UnitTestProject.test
{
    public class GlobalSetup
    {
        protected LoginViewModel LoginViewModelMock;
        protected ExitViewModel ExitViewModelMock;
        protected ProfileViewModel ProfileViewModelMock;
        protected ScheduleViewModel ScheduleViewModelMock;
        
        protected App application;
        protected Assembly assembly = Assembly.GetCallingAssembly();
        AppDomainManager manager = new AppDomainManager();
        AppDomain domain = AppDomain.CurrentDomain;
        public GlobalSetup()
        {
            FieldInfo entryAssemblyfield = manager.GetType().GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic);
            entryAssemblyfield.SetValue(manager, assembly);

            FieldInfo domainManagerField = domain.GetType().GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic);
            domainManagerField.SetValue(domain, manager);

            /* Preparing test end */
            LoginServices.CurrentUser = new Đồ_án.Database.User()
            {
                UserRole = new Đồ_án.Database.UserRole()
                {
                    Role = "student",
                },
                DetailUser = new Đồ_án.Database.DetailUser()
                {
                    Gender = false
                }
            };

            LoginViewModelMock = new LoginViewModel();
            ExitViewModelMock = new ExitViewModel();
            ProfileViewModelMock = new ProfileViewModel();
            ScheduleViewModelMock = new ScheduleViewModel();

            if (Application.Current == null)
            {
                application = new App();
                application.Resources.Add("LoginViewModel", LoginViewModelMock);
                application.Resources.Add("ExitViewModel", ExitViewModelMock);
                application.Resources.Add("ProfileViewModel", ProfileViewModelMock);
                application.Resources.Add("ScheduleViewModel", ScheduleViewModelMock);
            }
        }
    }
}

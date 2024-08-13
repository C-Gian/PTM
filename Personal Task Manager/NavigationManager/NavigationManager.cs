using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using Personal_Task_Manager.Models;
using Personal_Task_Manager.Presenters.LoginPresenter;
using Personal_Task_Manager.Presenters.SignupPresenter;
using Personal_Task_Manager.Presenters.TasksPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = Personal_Task_Manager.Models.User;

namespace Personal_Task_Manager.NavigationManager
{
    public class NavigationManager : INavigationManager
    {
        private readonly IServiceProvider _serviceProvider;
        public Form _currentForm {  get; set; }

        public NavigationManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShowLoginView()
        {
            _currentForm?.Hide();
            var loginPresenter = _serviceProvider.GetRequiredService<ILoginPresenter>();
            _currentForm = (Form)loginPresenter._loginView;
            _currentForm.Show();
        }

        public void ShowSignupView()
        {
            _currentForm?.Hide();
            var signupPresenter = _serviceProvider.GetRequiredService<ISignupPresenter>();
            _currentForm = (Form)signupPresenter._signupView;
            _currentForm.Show();
        }

        public void ShowTasksView(User user)
        {
            _currentForm?.Hide();
            var tasksPresenter = _serviceProvider.GetRequiredService<ITasksPresenter>();
            _currentForm = (Form)tasksPresenter._tasksView;
            tasksPresenter.SetUser(user);
            _currentForm.Show();
        }
    }

}

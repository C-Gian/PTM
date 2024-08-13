using Personal_Task_Manager.NavigationManager;
using Personal_Task_Manager.Presenters.TasksPresenter;
using Personal_Task_Manager.Repositories.UserRepository;
using Personal_Task_Manager.Views.LoginForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personal_Task_Manager.Views.LoginForm.LoginView;

namespace Personal_Task_Manager.Presenters.LoginPresenter
{
    public class LoginPresenter : ILoginPresenter
    {
        #region Field & Properties

        public ILoginView _loginView { get; set; }
        private readonly IUserRepository _loginRepository;
        private readonly INavigationManager _navigationManager;

        #endregion



        #region Constructor

        public LoginPresenter(ILoginView loginView, IUserRepository loginRepository, INavigationManager navigationManager)
        {
            _loginView = loginView;
            _loginRepository = loginRepository;
            _navigationManager = navigationManager;
            _loginView._loginEvent += OnLogin;
            _loginView._signupClickEvent += OnSignupClick;

        }

        #endregion



        #region Methods

        private void OnSignupClick(object? sender, EventArgs e)
        {
            _navigationManager.ShowSignupView();
        }

        private void OnLogin(object? sender, LoginEventClickArgs e)
        {
            var user = _loginRepository.Authenticate(_loginView.Email, _loginView.Password);
            if (user != null)
            {
                _navigationManager.ShowTasksView(user);
            }
            else
            {
                _loginView.ShowError();
            }
        }


        #endregion
    }
}

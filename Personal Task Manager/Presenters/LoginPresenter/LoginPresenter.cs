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
        private readonly ILoginRepository _userRepository;
        private readonly ITasksPresenter _tasksPresenter;

        #endregion



        #region Constructor

        public LoginPresenter(ILoginView loginView, ILoginRepository userRepository, ITasksPresenter tasksPresenter)
        {
            _loginView = loginView;
            _userRepository = userRepository;
            _tasksPresenter = tasksPresenter;

            _loginView._login += OnLoginRequested;
        }

        

        #endregion



        #region Methods

        private void OnLoginRequested(object? sender, LoginEventClickArgs e)
        {
            var user = _userRepository.Authenticate(e.Email, e.Password);
            if (user != null)
            {
                _loginView.Hide();
                _tasksPresenter.Show(); 
            } else
            {
                _loginView.ShowError();
            }
        }

        public void Hide()
        {
            _loginView?.Hide();
        }

        public void Show()
        {
            _loginView?.Show();
        }


        #endregion
    }
}

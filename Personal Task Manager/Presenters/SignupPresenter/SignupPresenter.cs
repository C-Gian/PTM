using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Personal_Task_Manager.Models;
using Personal_Task_Manager.NavigationManager;
using Personal_Task_Manager.Repositories.UserRepository;
using Personal_Task_Manager.Views.LoginForm;
using Personal_Task_Manager.Views.SignupForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Personal_Task_Manager.Views.LoginForm.LoginView;
using static Personal_Task_Manager.Views.SignupForm.SignupView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Personal_Task_Manager.Presenters.SignupPresenter
{
    public class SignupPresenter : ISignupPresenter
    {
        #region Field & Properties

        public ISignupView _signupView { get; set; }
        private readonly IUserRepository _userRepository;
        private readonly INavigationManager _navigationManager;

        #endregion



        #region Constructor

        public SignupPresenter(ISignupView signupView, IUserRepository userRepository, INavigationManager navigationManager)
        {
            _signupView = signupView;
            _userRepository = userRepository;
            _navigationManager = navigationManager;
            _signupView._signupEvent += OnSignup;

        }

        #endregion



        #region Methods

        private void OnSignup(object? sender, SignupEventClickArgs e)
        {
            if (Regex.IsMatch(e.User.Email, @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$"))
            {
                var emailTaken = _userRepository.CheckEmail(e.User.Email);
                if (emailTaken)
                {
                    _signupView.ShowError("email already taken!");
                } else
                {
                    var signed = _userRepository.Signup(e.User);
                    if (signed)
                    {
                        _navigationManager.ShowTasksView(e.User);
                    }
                    else
                    {
                        _signupView.ShowError("signup problems");
                    }
                }
                
            } else
            {
                _signupView.ShowError("insert a valid email!");
            }
        }


        #endregion
    }
}

using Personal_Task_Manager.Views.LoginForm;
using Personal_Task_Manager.Views.SignupForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Presenters.SignupPresenter
{
    public interface ISignupPresenter
    {
        public ISignupView _signupView { get; set; }
    }
}

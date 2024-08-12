using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal_Task_Manager.Views.LoginForm.LoginView;
using static Personal_Task_Manager.Views.SignupForm.SignupView;

namespace Personal_Task_Manager.Views.SignupForm
{
    public interface ISignupView
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ShowError(string error);

        public event EventHandler<SignupEventClickArgs> _signupEvent;
    }
}

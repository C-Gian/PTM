using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal_Task_Manager.Views.LoginForm.LoginView;

namespace Personal_Task_Manager.Views.LoginForm
{
    public interface ILoginView
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void Show();
        public void Hide();
        public void ShowError();

        public event EventHandler<LoginEventClickArgs> _loginEvent;
    }
}

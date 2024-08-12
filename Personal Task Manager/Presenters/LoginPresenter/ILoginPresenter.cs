using Personal_Task_Manager.Views.LoginForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Presenters.LoginPresenter
{
    public interface ILoginPresenter
    {
        public ILoginView _loginView {  get; set; }
        public void Show();
        public void Hide();
    }
}

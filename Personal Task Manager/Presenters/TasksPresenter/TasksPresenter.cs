using Personal_Task_Manager.Repositories.UserRepository;
using Personal_Task_Manager.Views.TasksForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Presenters.TasksPresenter
{
    public class TasksPresenter : ITasksPresenter
    {
        private readonly ITasksView _tasksview;
        private readonly ILoginRepository _loginRepository;

        public TasksPresenter(ITasksView tasksview, ILoginRepository loginRepository)
        {
            _tasksview = tasksview;
            _loginRepository = loginRepository;

            //_tasksview.Load += OnViewLoaded;
        }

        #region Methods

        public void Hide()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            _tasksview.Show();
        }

        #endregion
    }
}

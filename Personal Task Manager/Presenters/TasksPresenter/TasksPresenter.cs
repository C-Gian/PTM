using Personal_Task_Manager.Models;
using Personal_Task_Manager.Repositories.TasksRepository;
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
        public ITasksView _tasksView { get; set; }

        private readonly ITasksRepository _tasksRepository;

        public TasksPresenter(ITasksView tasksView, ITasksRepository tasksRepository)
        {
            _tasksView = tasksView;
            _tasksRepository = tasksRepository;
        }



        #region Methods

        public void LoadTasks(User user)
        {
            _tasksRepository.GetUserTasks(user);
        }

        #endregion
    }
}

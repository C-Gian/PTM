using Personal_Task_Manager.Models;
using Personal_Task_Manager.Views.TasksForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Presenters.TasksPresenter
{
    public interface ITasksPresenter
    {
        public ITasksView _tasksView { get; set; }

        public void LoadTasks(User user);
    }
}

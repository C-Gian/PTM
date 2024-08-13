using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static Personal_Task_Manager.Views.SignupForm.SignupView;
using static Personal_Task_Manager.Views.TasksForm.TasksView;
using Task = Personal_Task_Manager.Models.Task;

namespace Personal_Task_Manager.Views.TasksForm
{
    public interface ITasksView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }

        public void SetTasks(List<Task> tasks);
        public void SetContextData(User user);

        public event EventHandler<AddTaskEventClickArgs> _addTask;
        public event EventHandler<UpdateTaskEventClickArgs> _updateTask;
        public event EventHandler<DeleteTaskEventClickArgs> _deleteTask;
        public event EventHandler _logoutClick;
    }
}

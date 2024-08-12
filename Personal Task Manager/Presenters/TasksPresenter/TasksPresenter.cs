using Microsoft.VisualBasic.ApplicationServices;
using Personal_Task_Manager.Models;
using Personal_Task_Manager.Repositories.TasksRepository;
using Personal_Task_Manager.Repositories.UserRepository;
using Personal_Task_Manager.Views.TasksForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal_Task_Manager.Views.TasksForm.TasksView;
using User = Personal_Task_Manager.Models.User;

namespace Personal_Task_Manager.Presenters.TasksPresenter
{
    public class TasksPresenter : ITasksPresenter
    {
        public ITasksView _tasksView { get; set; }
        public User User { get; set; }

        private readonly ITasksRepository _tasksRepository;

        public TasksPresenter(ITasksView tasksView, ITasksRepository tasksRepository)
        {
            _tasksView = tasksView;
            _tasksRepository = tasksRepository;

            RefreshData();

            _tasksView._addTask += OnAddTask_Event;
            _tasksView._updateTask += OnUpdateTask_Event;
            _tasksView._deleteTask += OnDeleteTask_Event;
        }



        #region Methods

        private void OnDeleteTask_Event(object? sender, DeleteTaskEventClickArgs e)
        {
            _tasksRepository.DeleteTask(e.TaskID);
            RefreshData();
        }

        private void OnUpdateTask_Event(object? sender, UpdateTaskEventClickArgs e)
        {
            var task = e.Task;
            task.UserID = User.UserID;

            _tasksRepository.UpdateTask(task);
            RefreshData();
        }

        private void OnAddTask_Event(object? sender, AddTaskEventClickArgs e)
        {
            var task = e.Task;
            task.UserID = User.UserID;

            _tasksRepository.AddTask(task);
            RefreshData();
        }

        public void SetUser(User user)
        {
            User = user;
            _tasksView.SetContextData(user);
            RefreshData();
        }

        public void RefreshData()
        {
            if (User != null)
            {
                _tasksView.SetTasks(_tasksRepository.GetUserTasks(User));
            }
        }

        #endregion
    }
}

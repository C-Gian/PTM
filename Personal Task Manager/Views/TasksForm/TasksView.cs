using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Task = Personal_Task_Manager.Models.Task;

namespace Personal_Task_Manager.Views.TasksForm
{
    public partial class TasksView : Form, ITasksView
    {

        #region Properties

        public string Name { get => txt_tasks_name_input.Text; set => txt_tasks_name_input.Text = value; }
        public string Description { get => txt_tasks_desc_input.Text; set => txt_tasks_desc_input.Text = value; }
        public int Priority { get => (int)combo_tasks_priority_input.SelectedValue; set => combo_tasks_priority_input.SelectedValue = value; }
        public bool IsCompleted { get => check_tasks_compl_input.Checked; set => check_tasks_compl_input.Checked = value; }

        public event EventHandler<AddTaskEventClickArgs> _addTask;
        public event EventHandler<UpdateTaskEventClickArgs> _updateTask;
        public event EventHandler<DeleteTaskEventClickArgs> _deleteTask;

        #endregion



        #region Constructor

        public TasksView()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        private void btn_tasks_reset_Click(object sender, EventArgs e)
        {
            txt_tasks_name_input.Text = "";
            txt_tasks_desc_input.Text = "";
            combo_tasks_priority_input.SelectedValue = 0;
            check_tasks_compl_input.Checked = false;
        }

        private void btn_tasks_addupdate_Click(object sender, EventArgs e)
        {
            var task = new Task
            {
                Name = txt_tasks_name_input.Text,
                Description = txt_tasks_desc_input.Text,
                IsCompleted = check_tasks_compl_input.Checked,
                Priority = (int)combo_tasks_priority_input.SelectedValue,
            }; 
            if (btn_tasks_addupdate.Text == "Add")
            {
                _addTask?.Invoke(this, new AddTaskEventClickArgs(task));
            } else
            {
                var selectedTask = tasks_list.SelectedItem as Task;
                task.TaskID = selectedTask.TaskID;
                _updateTask?.Invoke(this, new UpdateTaskEventClickArgs(selectedTask));
            }
        }

        private void btn_tasks_delete_Click(object sender, EventArgs e)
        {
            var selectedTask = tasks_list.SelectedItem as Task;
            _deleteTask?.Invoke(this, new DeleteTaskEventClickArgs(selectedTask.TaskID));
        }

        public void SetTasks(List<Task> tasks)
        {
            tasks_list.DataSource = tasks;
        }

        public void SetComboPriority()
        {
            //var priorities = new List<string>() { "Low", "Medium", "High", "Max" };
            //var sv = (int)combo_tasks_priority_input.SelectedValue;
        }

        public void SetContextData(User user)
        {
            tasks_fname_label.Text = user.FirstName;
            tasks_lname_label.Text = user.LastName;
            tasks_email_label.Text = user.Email;
        }

        #endregion



        #region Events

        public class AddTaskEventClickArgs : EventArgs
        {
            public Task Task { get; set; }
            public AddTaskEventClickArgs(Task task)
            {
                Task = task;
            }
        }

        public class UpdateTaskEventClickArgs : EventArgs
        {
            public Task Task { get; set; }
            public UpdateTaskEventClickArgs(Task task)
            {
                Task = task;
            }
        }

        public class DeleteTaskEventClickArgs : EventArgs
        {
            public int TaskID { get; set; }
            public DeleteTaskEventClickArgs(int id)
            {
                TaskID = id;
            }
        }

        #endregion
    }
}

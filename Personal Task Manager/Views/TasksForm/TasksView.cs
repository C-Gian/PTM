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
        public int Priority { get => (int)combo_tasks_priority_input.SelectedIndex; set => combo_tasks_priority_input.SelectedIndex = value; }
        public bool IsCompleted { get => check_tasks_compl_input.Checked; set => check_tasks_compl_input.Checked = value; }

        public event EventHandler<AddTaskEventClickArgs> _addTask;
        public event EventHandler<UpdateTaskEventClickArgs> _updateTask;
        public event EventHandler<DeleteTaskEventClickArgs> _deleteTask;
        public event EventHandler _logoutClick;

        #endregion



        #region Constructor

        public TasksView()
        {
            InitializeComponent();
            combo_tasks_priority_input.DataSource = new List<string>() { "Low", "Medium", "High", "Max" };
            tasks_list.DrawItem += new DrawItemEventHandler(tasks_list_DrawItem);
            tasks_list.MouseDown += tasks_list_MouseDown;
        }

        #endregion



        #region Methods

        private void tasks_list_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;
            int index = lb.IndexFromPoint(e.Location);

            if (index == -1)
            {
                if (btn_tasks_addupdate.Text != "Add")
                {
                    btn_tasks_addupdate.Text = "Add";
                    ResetForm();
                }
                lb.ClearSelected();
            }
        }

        private void tasks_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ListBox listBox = sender as ListBox;

            Color backgroundColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = SystemColors.Highlight;
            }
            else
            {
                backgroundColor = (e.Index % 2 == 0) ? Color.LightGray : Color.White;
            }

            using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }
            using (SolidBrush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
            }

            e.DrawFocusRectangle();
        }

        private void tasks_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tasks_list.SelectedItem != null)
                {
                    Populateform((Task)tasks_list.SelectedItem);
                    btn_tasks_addupdate.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Populateform(Task task)
        {
            txt_tasks_name_input.Text = task.Name;
            txt_tasks_desc_input.Text = task.Description;
            combo_tasks_priority_input.SelectedIndex = task.Priority;
            check_tasks_compl_input.Checked = task.IsCompleted;
        }

        public void ResetForm()
        {
            txt_tasks_name_input.Text = "";
            txt_tasks_desc_input.Text = "";
            combo_tasks_priority_input.SelectedItem = null;
            check_tasks_compl_input.Checked = false;
            btn_tasks_addupdate.Text = "Add";
        }

        private void btn_tasks_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btn_tasks_addupdate_Click(object sender, EventArgs e)
        {
            var task = new Task
            {
                Name = txt_tasks_name_input.Text,
                Description = txt_tasks_desc_input.Text,
                IsCompleted = check_tasks_compl_input.Checked,
                Priority = combo_tasks_priority_input.SelectedIndex,
            };
            if (btn_tasks_addupdate.Text == "Add")
            {
                _addTask?.Invoke(this, new AddTaskEventClickArgs(task));
            }
            else
            {
                var selectedTask = tasks_list.SelectedItem as Task;
                task.TaskID = selectedTask.TaskID;
                _updateTask?.Invoke(this, new UpdateTaskEventClickArgs(task));
            }
        }

        private void btn_tasks_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var selectedTask = tasks_list.SelectedItem as Task;
                _deleteTask?.Invoke(this, new DeleteTaskEventClickArgs(selectedTask.TaskID));
                ResetForm();
                MessageBox.Show("Record deleted successfully.");
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }
        }

        public void SetTasks(List<Task> tasks)
        {
            tasks_list.DataSource = tasks;
            tasks_list.SelectedItem = null;
            ResetForm();
        }

        public void SetContextData(User user)
        {
            tasks_fname_label.Text = user.FirstName;
            tasks_lname_label.Text = user.LastName;
            tasks_email_label.Text = user.Email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _logoutClick?.Invoke(this, EventArgs.Empty);
            }
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

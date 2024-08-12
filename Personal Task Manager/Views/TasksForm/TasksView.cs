using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Task_Manager.Views.TasksForm
{
    public partial class TasksView : Form, ITasksView
    {

        #region Constructor

        public TasksView()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        public void Show()
        {
            this.Show();
        }

        public void Hide()
        {
            this.Hide();
        }

        #endregion
    }
}

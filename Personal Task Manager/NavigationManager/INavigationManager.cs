using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.NavigationManager
{
    public interface INavigationManager
    {
        public Form _currentForm { get; set; }
        void ShowTasksView(User user);
        void ShowLoginView();
    }

}

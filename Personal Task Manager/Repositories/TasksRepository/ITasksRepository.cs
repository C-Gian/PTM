using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Personal_Task_Manager.Models.Task;

namespace Personal_Task_Manager.Repositories.TasksRepository
{
    public interface ITasksRepository
    {
        public List<Task> GetUserTasks(User user);
    }
}

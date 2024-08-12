using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Task = Personal_Task_Manager.Models.Task;
using Personal_Task_Manager.Configuration;

namespace Personal_Task_Manager.Repositories.TasksRepository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly MySettings _settings;

        public TasksRepository(MySettings settings)
        {
            _settings = settings;
        }

        public List<Task> GetUserTasks(User user)
        {
            var tasks = new List<Task>();
            using (var connection = new SqlConnection(_settings.Connection))
            {
                var command = new SqlCommand("GetUserTasks", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@UserID", user.UserID));

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tasks.Add(new Task
                        {
                            TaskID = (int)reader["TaskID"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                            Priority = (string)reader["Priority"],
                            IsCompleted = (bool)reader["IsCompleted"],
                            UserID = (int)reader["UserID"],
                        });
                    }
                }
            }

            return tasks;
        }
    }
}

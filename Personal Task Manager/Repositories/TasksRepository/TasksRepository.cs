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

        public void AddTask(Task task)
        {
            using (SqlConnection conn = new SqlConnection(_settings.Connection))
            {
                using (SqlCommand cmd = new SqlCommand("AddTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", task.Name);
                    cmd.Parameters.AddWithValue("@Description", task.Description);
                    cmd.Parameters.AddWithValue("@Priority", task.Priority);
                    cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                    cmd.Parameters.AddWithValue("@UserID", task.UserID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void UpdateTask(Task task)
        {
            using (SqlConnection conn = new SqlConnection(_settings.Connection))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                    cmd.Parameters.AddWithValue("@Name", task.Name);
                    cmd.Parameters.AddWithValue("@Description", task.Description);
                    cmd.Parameters.AddWithValue("@Priority", task.Priority);
                    cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                    cmd.Parameters.AddWithValue("@UserID", task.UserID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void DeleteTask(int TaskID)
        {
            using (SqlConnection conn = new SqlConnection(_settings.Connection))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TaskID", TaskID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

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
                    while (reader.Read())
                    {
                        tasks.Add(new Task
                        {
                            TaskID = (int)reader["TaskID"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                            Priority = (int)reader["Priority"],
                            IsCompleted = (bool)reader["IsCompleted"],
                        });
                    }
                }
            }

            return tasks;
        }

        
    }
}

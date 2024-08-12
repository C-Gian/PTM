using Personal_Task_Manager.Configuration;
using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Repositories.UserRepository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MySettings _settings;

        public LoginRepository(MySettings settings)
        {
            _settings = settings;
        }

        public User Authenticate(string email, string password)
        {
            User user = null;

            using (var connection = new SqlConnection(_settings.Connection))
            {
                var command = new SqlCommand("Authenticate", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@Email", email));
                command.Parameters.Add(new SqlParameter("@Password", password));

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["UserID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Email = (string)reader["Email"],
                            Password = (string)reader["Password"],
                        };
                    }
                }
            }

            return user;
        }
    }
}

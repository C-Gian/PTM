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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Personal_Task_Manager.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySettings _settings;

        public UserRepository(MySettings settings)
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

        public bool CheckEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(_settings.Connection))
            {
                using (SqlCommand cmd = new SqlCommand("CheckEmailExists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email);

                    SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(existsParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return (bool)existsParam.Value;
                }
            }
        }

        public bool Signup(User user)
        {

            using (var connection = new SqlConnection(_settings.Connection))
            {
                var command = new SqlCommand("AddUser", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@FirstName", user.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", user.LastName));
                command.Parameters.Add(new SqlParameter("@Email", user.Email));
                command.Parameters.Add(new SqlParameter("@Password", user.Password));

                SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                int newUserId = (int)outputIdParam.Value;
                return newUserId > 0;
            }
            
        }
    }
}

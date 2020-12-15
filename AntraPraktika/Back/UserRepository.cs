using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AntraPraktika.Back
{
    class UserRepository
    {
        private SqlConnection conn;

        public UserRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        }

        public User Login(string username, string password)
        {
            string sql = "select Id, Name, Surname, Birthdate, Username, Password, UserType from Users " +
                "where Username=@username and Password=@password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string surname = reader["Surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["BirthDate"].ToString());
                    string _username = reader["Username"].ToString();
                    string _password = reader["Password"].ToString();
                    int typeId = (int)reader["UserType"];
                    int user_Id = int.Parse(reader["Id"].ToString());
                    User user = new User(name, surname, birthdate, _username, _password);
                    user.UserType = EnumConverter.getUserType(typeId);
                    user.id = user_Id;
                    conn.Close();
                    return user;
                }
            }
            


            throw new Exception("Bad username/password!");
        }

    }
}

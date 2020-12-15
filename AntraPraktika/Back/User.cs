using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPraktika.Back
{
    public class User: Person
    {
        private int Id;
        private string Username;
        private string Password;
        private UserType userType { get; set; }
        public User(string name, string surname, DateTime birthDate, string username, string password) : base(name, surname, birthDate)
        {
            if (username == "")
                throw new Exception("Username is empty!");
            if (password == "")
                throw new Exception("Password is empty!");

            Username = username;
            Password = password;
        }
        internal UserType UserType
        {
            get => userType; set => userType = value;
        }
        internal int id
        {
            get => Id; set => Id = value;
        }
    }
}

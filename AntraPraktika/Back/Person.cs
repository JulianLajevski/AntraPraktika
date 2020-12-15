using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPraktika
{
    public abstract class Person
    {
        private string Name;
        private string Surname;
        private DateTime birthDate;

        public Person(string name, string surname, DateTime birthdate)
        {
            if (name == "")
                throw new Exception("Name is empty!");
            if (surname == "")
                throw new Exception("Surname is empty!");
            if(birthDate >= DateTime.Today)
                throw new Exception("Birthday bigger than today date!");
            Name = name;
            Surname = surname;
            birthDate = birthdate;
        }

        internal string name
        {
            get => Name; set => Name = value;
        }
    }
}

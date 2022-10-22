using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours6.Exo
{
    internal class Person
    {
        public Person(string name, string lastName, DateTime birthDate)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string Name
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public DateTime BirthDate
        {
            get; set;
        }

    }

}

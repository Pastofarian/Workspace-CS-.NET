using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_exercice
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
    }
}

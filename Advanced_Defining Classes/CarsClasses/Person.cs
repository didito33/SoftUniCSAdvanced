using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsClasses
{
    class Person
    {
        private string firstName;
        private string lastName;
        public string FirstName 
        { 
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FullName { get { return $"{firstName} {lastName}"; } }
    }
}

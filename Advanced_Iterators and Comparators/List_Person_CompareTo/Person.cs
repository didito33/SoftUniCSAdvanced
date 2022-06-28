using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    class Person : IComparable<Person>
    {
        public Person(string name, string town, int age)
        {
            Name = name;
            Town = town;
            Age = age;
        }

        public string Name { get; set; }
        public string Town { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0) result = Age.CompareTo(other.Age);
            if (result == 0) result = Town.CompareTo(other.Town);
            return result;
        }
    }
}

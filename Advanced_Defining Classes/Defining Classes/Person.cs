using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this()//този ctor наследява горния като му приема Name
        {
            Age = age;
        }
        public Person(string name, int age) : this(age)//този ctor наследява горния като му приема Age
        {
            Name = name;

        }
        public string Name
        {
            get { return name; }
            set 
            { 
                //if(value.Length >3)
                name = value; 
            }
        }
        public int Age
        {
            get 
            {
                return age;
            }
            set
            {
                age = value;
            }
        } 
        public static void Print(int n)
        {
            List<Person> personList = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                if(person.age > 30)
                personList.Add(person);
            }
            personList = personList.OrderBy(x => x.Name).ToList();
            foreach (Person personaj in personList)
            {
                Console.WriteLine($"{personaj.Name} - {personaj.Age}");
            }
        }
    }
}

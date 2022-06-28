using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "pesho";//vlizame v setter-a zashtoto setva value
            var name = person.Name;//vliza v getter-a, zashtoto ne setvame value
            Console.WriteLine(person.Name);//getter
            Console.WriteLine(person.Name);//getter
        }
    }
    class Person
    {
        private string name;
        public string Name 
        {
            get
            {
                Console.WriteLine("In getter");
                return this.name;
            }
            set
            {
                Console.WriteLine("in setter");
                this.name = value;
            }
        }
    }
}

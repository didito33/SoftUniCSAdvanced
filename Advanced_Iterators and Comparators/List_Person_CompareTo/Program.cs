using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        //        {Peter 22 Varna
        //George 22 Varna
        //George 22 Varna
        //END
        //2
        { 
            List<Person> people = new List<Person>();
            string information = Console.ReadLine();
            while (information != "END")

            {
                string[] personInfo = information.Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, town, age);
                people.Add(person);
                information = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine());
            Person personToCompare = people[n - 1];
            int equals = 0;
            int diff = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equals++;
                }
                else
                    diff++;
            }
            if (equals == 1)//човека е matchnal само себе си
            {
                Console.WriteLine("No matches");
            }
            else
                Console.WriteLine($"{equals} {diff} {people.Count}");
        }
    }
}

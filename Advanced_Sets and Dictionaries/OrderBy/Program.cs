using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBy
{
    class Student
    {
        public string  Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>() { 17, 15, 38, 42, 48, 23, 26 };
            //s linq trqbva da prezapisvame kolekciqta
            ages = ages.OrderBy(x => x).ToList();//po elementite

           // Console.WriteLine(string.Join(",", ages));


            List<Student> students = new List<Student>()
            {
                new Student(){Age = 15, Name = "Mobi"},
                new Student(){Age = 47, Name = "Gogi"},
                new Student(){Age = 23, Name = "Dimitrichko"},
                new Student(){Age = 15, Name = "Bobi"},
                new Student(){Age = 15, Name = "Angel"},
            };
            
            students = students.OrderByDescending(x => x.Age).ThenBy(x=>x.Name).ToList();
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} -> {item.Age}");
            }
        }
    }
}

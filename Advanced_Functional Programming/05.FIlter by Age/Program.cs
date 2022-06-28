using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FIlter_by_Age
{
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Program
    {
        /*5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
older
20
name age*/
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                students.Add(new Student(input[0], int.Parse(input[1])));

            }
            string filterInput = Console.ReadLine();//older
            int ageFilter = int.Parse(Console.ReadLine());//20
            string formatInput = Console.ReadLine();//name age      (moje da e samo age ili samo name)

            Func<Student,int, bool> filter = GetFilter(filterInput);
            students = students.Where(x=>filter(x,ageFilter)).ToList();
            

            Action<Student> printer = GetPrinter(formatInput);
            students.ForEach(printer);
            
        }

        private static Action<Student> GetPrinter(string formatInput)
        {
            switch (formatInput)
            {
                case "name":
                    return s => Console.WriteLine(s.Name);
                case "age":
                    return s => Console.WriteLine(s.Age);
                case "name age":
                    return s => Console.WriteLine($"{s.Name} - {s.Age}");
                default:
                    return null;
            }
        }

        private static Func<Student,int, bool> GetFilter(string filterInput)
        {
            switch (filterInput)
            {
                case "older"://Func<Student,int - parametrite
                    return (s, age) => s.Age >= age;
                case "younger":
                    return (s, age) => s.Age < age;
                default:
                    return null;
            }
        }
    }
}

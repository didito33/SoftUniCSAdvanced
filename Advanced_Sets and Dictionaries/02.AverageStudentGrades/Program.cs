using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (!students.ContainsKey(input[0]))
                {
                    students[input[0]] = new List<decimal>();
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
                else
                    students[input[0]].Add(decimal.Parse(input[1]));
            }
            foreach (var student in students)
            {

                //Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {student.Value.Average():f2})");
                Console.Write($"{student.Key} -> ");
                foreach (double grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {student.Value.Average():f2})\n");
            }
        }
    }
}

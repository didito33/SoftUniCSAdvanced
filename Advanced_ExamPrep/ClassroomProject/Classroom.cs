﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students = new List<Student>();
        }
        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public int Count => Students.Count;
        public string RegisterStudent(Student student)
        {
            if(Students.Count != Capacity)
            {
                //no seats
                return "No seats in the classroom";
            }
            
            Students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName ==lastName);
            
            if(student == null)
            {
                return "Student not found";
            }

            Students.Remove(student);
            return $"Dismissed student {student.FirstName} {student.LastName}";
        }
        public string GetSubjectInfo(string subject)
        {
            List<Student> students = Students.Where(x => x.Subject == subject).ToList();
            if(students.Count == 0)
            {
                return "No students enrolled for the subject";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            foreach (var student in students)
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }
            return sb.ToString().TrimEnd();
        }
        public int GetStudentCount()
        {
            return Students.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName); ;
        }
    }
}

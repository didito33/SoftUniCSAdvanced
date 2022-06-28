using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            /*Person person = new Person("Viktor",24);//Debug tuk za da vidim " :this " - F11

            Family family = new Family();
            family.AddMemeber(person);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);    
            ------1va i 2ra do tuk*/

            /* Input -> 3   -> Deivid 20 -> Ivan 30 -> Georgi 5
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMemeber(person);
            }
            Person oldest = family.GetOldestMethod();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
            ---3ta do tuk*/                                             // MNOGO QKA

            // Input -> 3 -> Deivid 20 -> Ivan 35 -> Petkan 45
            /*Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMemeber(person);
            }
            family.PrintAboveThirties();*/ 
            //--------------4ta do tuk 

            int n = int.Parse(Console.ReadLine());
            Person.Print(n);// 4ta SUS STATIC method v Person
        }
    }
}

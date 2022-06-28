using System;
using System.Collections;
using System.Collections.Generic;

namespace Advanced_Iterators_and_Comparators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Child child = new Child();
            Person person = new Person();
            
            person.FirstName = "Filip";
            person.LastName = "Ivanov";
            
            //---------------------------------------- Tova e sushtoto kato Foreach-a
            /*IEnumerator enumerator = person.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item);
            }*/ //------------------------- - Tova e sushtoto kato foreach-a

            foreach (var item in person)//veche mojem da foreachvame Person 
            {
                Console.WriteLine(item);
            }
           
        }
    }
    //                          //искаме във foreach-a да въртим по 'int'
    public class Person : IEnumerable<int>//това казва, че може да бъде обхождано
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Grades { get; set; } = new List<int> { 4, 5, 6 };

        public IEnumerator<int> GetEnumerator() // а това как ще бъде обхождано - АЛГОРИТЪМ
        {
            //return Grades.GetEnumerator(); 
            if (Grades.Count < 5)
                return new ReversePersonGradesEnumerator(Grades);// - Създаваме наш итератор
            else
                return Grades.GetEnumerator();//ако имаме повече от 5 оценки ги връщаме по нормален начин
        }
        

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
            
            //return GetEnumerator();
    }

    public class ReversePersonGradesEnumerator : IEnumerator<int>
    {
        private int index;
        private List<int> items;
        public int Current => items[index];
        public ReversePersonGradesEnumerator(List<int> items)
        {
            this.items = items;
            index = items.Count;//индекса започва от COUNT-a защото първо влизаме в MoveNext()
        }
        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            index--;
            if (index < 0)
            {
                return false;
            }

            else
            {
                
                return true;
            }
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    /*public class Child :Person//child nasledqva person    {
    {
        public void MakeSound()
        {

        }
    }*/
    public class Car
    {
        public List<int> Mileage { get; set; }
    }

}

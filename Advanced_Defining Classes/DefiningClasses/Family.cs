using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();//pravim si lista purvo ot Ctor-a, защото първо влизаме в ctor-a
        }
        public List<Person> People { get; set; }
        public void AddMemeber(Person person)
        {
            People.Add(person);//addvame go v lista
        }
        public Person GetOldestMethod()
        {
            Person oldestPerson = People.OrderByDescending(x=>x.Age).FirstOrDefault();
            /*int oldestMember = 0;
            Person oldestPerson = null;
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Age > oldestMember) 
                {
                    oldestPerson = People[i];
                    oldestMember = oldestPerson.Age;
                 }
            }*/
            return oldestPerson;
        }
        
    }
}

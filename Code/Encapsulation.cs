using System;
using BasicOOConcepts.Model.Encapsulation;

namespace BasicOOConcepts.Code
{
    public static class Encapsulation
    {
        public static void GetPersonAgeExample()
        {
            Person person1 = new Person("Andy", new DateTime(2001, 2, 15));
            Person person2 = new Person("Jessica", new DateTime(2005, 4, 16));

            PrintPerson(person1);
            PrintPerson(person2);
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("{0} is {1} years old.", person.GetName, person.GetAge);
            Console.WriteLine("{0} ID = {1}", person.GetName, person.GetID);
            Console.WriteLine();
        }
    }
    
}
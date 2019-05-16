using System;
using BasicOOConcepts.Model.Inheritance;

namespace BasicOOConcepts.Code
{
    public static class Inheritance
    {
        public static void GetPersonAgeAndSalaryExample()
        {
            Manager manager1 = new Manager("Wendy", new DateTime(1988, 2, 15), 5500);
            Manager manager2 = new Manager("Thomas", new DateTime(1985, 4, 16), 6000);

            PrintPerson(manager1);
            PrintManager(manager2);
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("{0} is {1} years old.", person.GetName, person.GetAge);
            Console.WriteLine("{0} ID = {1}", person.GetName, person._ID);
            Console.WriteLine();
        }

        private static void PrintManager(Manager manager)
        {
            Console.WriteLine("{0} is {1} years old.", manager.GetName, manager.GetAge);
            Console.WriteLine("{0} ID = {1}", manager.GetName, manager.GetID);
            Console.WriteLine("{0} salary is {1}", manager.GetName, manager.GetSalary());
            Console.WriteLine();
        }
    }
}
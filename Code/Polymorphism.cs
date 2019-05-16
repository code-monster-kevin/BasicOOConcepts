using System;
using System.Collections.Generic;
using BasicOOConcepts.Model.Inheritance;

namespace BasicOOConcepts.Code
{
    public static class Polymorphism
    {
        public static void GetPersonAgeAndSalaryExample()
        {
            Manager manager1 = new Manager("Grace", new DateTime(1988, 2, 15), 5500);
            SalesManager manager2 = new SalesManager("Reuben", new DateTime(1985, 4, 16), 6000);

            List<Manager> managers = new List<Manager>();
            managers.Add(manager1);
            managers.Add(manager2);

            foreach(Manager manager in managers)
            {
                PrintManager(manager);
            }
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
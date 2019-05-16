using System;

namespace BasicOOConcepts.Model.Inheritance
{
    public class Manager : Person
    {
        private int _Salary;

        public Manager(string name, DateTime birthdate, int salary) : base(name, birthdate)
        {
            _Salary = salary;
        }

        public virtual int GetSalary()
        {
            return _Salary;
        }
    }
}
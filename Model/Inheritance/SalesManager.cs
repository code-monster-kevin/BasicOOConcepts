using System;

namespace BasicOOConcepts.Model.Inheritance
{
    public class SalesManager : Manager
    {
        private int _Commission;
        private int _Salary;

        public SalesManager(string name, DateTime birthdate, int salary) : base(name, birthdate, salary)
        {
            _Commission = 4;
            _Salary = salary;
        }

        public override int GetSalary()
        {
            int TotalSales = 50000;
            int SalesBonus = (TotalSales * _Commission)/100;
            return _Salary + SalesBonus;
        }
    }
}
using System;

namespace BasicOOConcepts.Model.Inheritance
{
    public class Person
    {
        public int _ID { get; }
        private string _Name;
        private DateTime _BirthDate;

        public Person(string name, DateTime birthdate)
        {
            Random rand = new Random();
            _ID = rand.Next(9999999);
            _Name = name;
            _BirthDate = birthdate;
        }
        
        public int GetID
        {
            get {
                return _ID;
            }
        }
        
        public int GetAge
        {
            get {
                return DateTime.Today.Year - _BirthDate.Year;
            }
        }

        public string GetName
        {
            get {
                if (_Name != null) {
                    return _Name;
                }
                return "Name not set";
            }
        }
    }
}
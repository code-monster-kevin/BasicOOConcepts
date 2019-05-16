using System;

namespace BasicOOConcepts.Model.Encapsulation
{
    public class Person
    {
        public Person(string name, DateTime birthdate)
        {
            Random rand = new Random();
            _ID = rand.Next(9999999);
            _Name = name;
            _BirthDate = birthdate;
        }
        private int _ID;
        private string _Name;
        private DateTime _BirthDate;

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
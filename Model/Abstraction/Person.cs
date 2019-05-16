using System;

namespace BasicOOConcepts.Model.Abstraction
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public string FavouriteFood { get; set; }
        public string EducationLevel { get; set; }
        public string National_ID { get; set; }
        public string EPF_Number { get; set; }
        public string DriversLicense_Number { get; set; }
        public Person BestFriend { get; set; }
        public string Hobby { get; set; }
    }
}
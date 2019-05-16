namespace BasicOOConcepts.Model.Classification
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public Person Father { get; set; }
        public Person Mother { get; set; }
    }
}
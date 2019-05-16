using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class SaveToCloud : IStorage
    {
        public void Save(string message, string location)
        {
            Console.WriteLine("Message \"{0}\" saved to cloud at {1}", message, location);
        }
    }
}
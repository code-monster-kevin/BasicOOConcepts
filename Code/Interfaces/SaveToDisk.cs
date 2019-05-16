using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class SaveToDisk : IStorage
    {
        public void Save(string message, string location)
        {

            Console.WriteLine("Message \"{0}\" saved to disk at {1}", message, location);
        }
    }
}
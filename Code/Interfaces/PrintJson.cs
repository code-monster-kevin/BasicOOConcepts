using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class PrintJson : IPrintOutput
    {
        public void Print(string message)
        {

            Console.WriteLine(CreateJson(message));
        }

        private string CreateJson(string message)
        {
            string json = "{ \"message\": \"" + message + "\" }";
            return json;
        }
    }
}
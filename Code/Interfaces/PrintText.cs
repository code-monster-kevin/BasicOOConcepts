using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class PrintText : IPrintOutput
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
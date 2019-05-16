using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class PrintPdf : IPrintOutput
    {
        public void Print(string message)
        {
            Console.WriteLine("Pdf file {0}.pdf created", message);
        }
    }
}
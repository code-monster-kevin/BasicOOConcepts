using System;

namespace BasicOOConcepts.Code.Interfaces
{
    public class PrintWeb : IPrintOutput
    {
        public void Print(string message)
        {

            Console.WriteLine(CreateWebPage(message));
        }

        private string CreateWebPage(string message)
        {
            string webpage = "<html><body>" + message + "</body></html>";
            return webpage;
        }
    }
}
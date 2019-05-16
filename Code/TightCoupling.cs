using System;
using BasicOOConcepts.Code.Interfaces;

namespace BasicOOConcepts.Code
{
    public class TightCoupling
    {
        public void SaveAndPrintMessage(string message, string location)
        {
            PrintWeb printWeb = new PrintWeb();
            SaveToDisk saveToDisk = new SaveToDisk();
            
            if (message != null) {
                saveToDisk.Save(message, location);
                printWeb.Print(message);
                Console.WriteLine();
            }
        }
    }
}
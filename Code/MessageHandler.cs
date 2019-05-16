using System;
using BasicOOConcepts.Code.Interfaces;

namespace BasicOOConcepts.Code
{
    public class MessageHandler
    {
        private IStorage _storage;
        private IPrintOutput _printoutput;
        public MessageHandler(IStorage storage, IPrintOutput printoutput)
        {
            _storage = storage;
            _printoutput = printoutput;
        }

        public void SaveAndPrintMessage(string message, string location) {
            if (message != null) {
                _storage.Save(message, location);
                _printoutput.Print(message);
                Console.WriteLine();
            }
        }
    }
}
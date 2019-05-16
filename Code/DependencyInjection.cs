using System;
using BasicOOConcepts.Code.Interfaces;

namespace BasicOOConcepts.Code
{
    public static class DependencyInjection
    {
        public static void InjectMethods()
        {
            SaveToDisk saveToDisk = new SaveToDisk();
            SaveToCloud saveToCloud = new SaveToCloud();
            PrintText printText = new PrintText();
            PrintWeb printWeb = new PrintWeb();
            PrintPdf printPdf = new PrintPdf();
            PrintJson PrintJson = new PrintJson();

            MessageHandler handler1 = new MessageHandler(saveToDisk, printText);
            MessageHandler handler2 = new MessageHandler(saveToCloud, printWeb);
            MessageHandler handler3 = new MessageHandler(saveToDisk, printPdf);
            MessageHandler handler4 = new MessageHandler(saveToCloud, PrintJson);

            handler1.SaveAndPrintMessage("handler1 message", "D:\\logs\\");
            handler2.SaveAndPrintMessage("handler2 message", "bucket1.aws.com\\myfolder\\");
            handler3.SaveAndPrintMessage("handler3 message", "D:\\logs\\");
            handler4.SaveAndPrintMessage("handler4 message", "bucket1.aws.com\\myfolder\\");
        }
    }
}
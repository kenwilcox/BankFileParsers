using System;
using System.Collections.Generic;
using System.Linq;

namespace BankFileParsers
{
    public static class Program
    {
        static void Main()
        {
            var parser = new BaiParser();

            const string fileName = @"C:\Temp\bank_files\BAI.txt";
            var bai = parser.Parse(fileName);
            var trans = BaiTranslator.Translate(bai);

            var summary = BaiTranslator.GetSummaryInformation(trans);
            Console.WriteLine("Summary Count: " + summary.Count);

            var dictionaryKeys = new List<string> { "PREAUTHORIZED ACH FROM", "ORIGINATOR ID", "ENTRY DESCRIPTION", 
                "PAYMENT ID", "RECEIVER INFORMATION", "ADDENDA INFORMATION" };
            
            var detail = BaiTranslator.GetDetailInformation(trans, dictionaryKeys);
            var detailDictionary = detail.Where(p => p.TextDictionary.Count > 0).ToList();
            Console.WriteLine("Detail Count: " + detail.Count);
            Console.WriteLine("Detail with Dictionary: " + detailDictionary.Count);

            //parser.Write(fileName + ".new", bai);

            // Dump to CSV?
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankFileParsers.Example
{
    public static class Program
    {
        static void Main()
        {
            var parser = new BaiParser();

            const string fileName = @"BAI-sample.txt";
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

            // Verify that the parser works - do a diff with the imput file
            parser.Write(fileName + ".new", bai);

            // Dump to CSV?
            //detail.CsvFieldSeparator('|');
            // Set the prefix
            //detail.CsvFieldPrefix('[');
            // different than the postfix
            //detail.CsvFieldPostfix(']');
            // or set them to the same
            //detail.CsvFieldPrefixPostfix('"');
            // or turn them all off
            //detail.CsvDisablePrefixPostFix();
            var csv = detail.ExportToCsv(dictionaryKeys);

            // you can even just export a single column if you want
            //var csv = detail.ExportToCsv(null, new List<string> { "FileIdentificationNumber" });
            // It can be just a dictionary key
            //var csv = detail.ExportToCsv(new List<string>{"PAYMENT ID"}, new List<string>());
            File.WriteAllText(@"BAI-sample.csv", csv);
        }
    }
}

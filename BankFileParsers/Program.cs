using System;
// ReSharper disable LoopCanBeConvertedToQuery
// What ReSharper suggested is more confusing to read IMO

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

            // Use the pretty print to get ReSharper to not be stupid
            //Console.WriteLine("Pretty Print");
            //var pp = BaiTranslator.PrettyPrint(trans, 80);
            //Console.WriteLine(pp);

            // Figure out the longest detail text
            //var max = 0;
            //Detail held = null;
            //foreach (var group in trans.Groups)
            //{
            //    foreach (var account in group.Accounts)
            //    {
            //        foreach (var detail in account.Details)
            //        {
            //            if (detail.Text.Length <= max) continue;
            //            max = detail.Text.Length;
            //            held = detail;
            //        }
            //    }
            //}
            //Console.WriteLine("Max: " + max);
            //if (held != null) Console.WriteLine(held.TextDictionary.Count);

            var summary = BaiTranslator.GetSummaryInformation(trans);
            Console.WriteLine("Summary Count: " + summary.Count);

            //parser.Write(fileName + ".new", bai);
        }
    }
}

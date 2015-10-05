using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFileParsers
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var parser = new BaiParser();
            var translator = new BaiTranslator();

            const string fileName = @"C:\Temp\bank_files\BAI.txt";
            var bai = parser.Parse(fileName);
            var trans = translator.Translate(bai);
            Console.WriteLine(trans.FileIdentificationNumber);
            parser.Write(fileName + ".new", bai);
        }
    }
}

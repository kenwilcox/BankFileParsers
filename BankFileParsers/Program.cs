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
            var bai = parser.Parse(@"C:\Temp\bank_files\BAI-File-From-Bank.txt");
            Console.WriteLine(bai.FileHeader);
            Console.WriteLine(bai.FileTrailer);
            Console.ReadKey();
        }
    }
}

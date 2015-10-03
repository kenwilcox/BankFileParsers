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
            var fileName = @"C:\Temp\bank_files\BAI.txt";
            var bai = parser.Parse(fileName);
            parser.Write(fileName + ".new", bai);
        }
    }
}

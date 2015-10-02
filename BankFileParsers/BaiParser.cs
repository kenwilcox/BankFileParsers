using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFileParsers
{
    public class BaiParser
    {
        private string[] _data;

        public BaiFile Parse(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception("File not found, nothing to parse");
            _data = File.ReadAllLines(fileName);
            return _Parse();
        }

        private BaiFile _Parse()
        {
            var bai = new BaiFile();

            foreach (var data in _data.Select((value, index) => new { value, index }))
            {
                var line = data.value;
                if (data.index == 0 && line.StartsWith("01"))
                    bai.FileHeader = line;
                if (data.index == _data.Length -1  && line.StartsWith("99"))
                    bai.FileTrailer = line;
            }

            return bai;
        }
    }

    public class BaiFile
    {
        public string FileHeader { get; internal set; }
        public List<BaiGroup> Groups { get; internal set; }
        public string FileTrailer { get; internal set; }

        public BaiFile()
        {
            Groups = new List<BaiGroup>();
        }
    }

    public class BaiGroup
    {
        public string GroupHeader { get; internal set; }
        public string AccountIdentifier { get; internal set; }
        public List<BaiDetails> TransactionDetails { get; internal set; }
        public string GroupTrailer { get; internal set; }

        public BaiGroup()
        {
            TransactionDetails = new List<BaiDetails>();
        }
    }

    public class BaiDetails
    {
        public string TransactionDetail { get; internal set; }
        public List<string> Continuation { get; internal set; }
        public string AccountTrailer { get; internal set; }

        public BaiDetails()
        {
            Continuation = new List<string>();
        }
    }
}

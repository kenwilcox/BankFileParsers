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

        public void Write(string fileName, BaiFile data)
        {
            var lines = new List<string>();
            lines.Add(data.FileHeader);
            foreach (var group in data.Groups)
            {
                lines.Add(group.GroupHeader);
                foreach (var groupC in group.Continuation)
                {
                    lines.Add(groupC);
                }
                foreach (var account in group.Accounts)
                {
                    lines.Add(account.AccountIdentifier);

                    lines.Add(account.AccountTrailer);
                }
                lines.Add(group.GroupTrailer);
            }
            lines.Add(data.FileTrailer);

            File.WriteAllLines(fileName, lines.ToArray());
        }

        private BaiFile _Parse()
        {
            var bai = new BaiFile();
            var group = new BaiGroup("--default--");
            var account = new BaiAccount("--default--");
            var detail = new BaiDetail("--default--");
            var continuation = ContinuationType.Account;

            foreach (var data in _data.Select((value, index) => new { value, index }))
            {
                var line = data.value;
                if (data.index == 0 && line.StartsWith("01"))
                    bai.FileHeader = line;
                else if (data.index == _data.Length -1  && line.StartsWith("99"))
                    bai.FileTrailer = line;

                else if (line.StartsWith("02"))
                {
                    continuation = ContinuationType.Group;
                    group = new BaiGroup(line);
                }
                else if (line.StartsWith("98"))
                {
                    group.GroupTrailer = line;
                    bai.Groups.Add(group);
                }

                else if (line.StartsWith("03"))
                {
                    continuation = ContinuationType.Account;
                    //group.AccountIdentifier = line;
                    account = new BaiAccount(line);
                }
                
                else if (line.StartsWith("49"))
                {
                    if (detail.TransactionDetail != "--default--")
                        account.Details.Add(detail);
                    account.AccountTrailer = line;
                    group.Accounts.Add(account);
                }

                else if (line.StartsWith("16"))
                {
                    continuation = ContinuationType.Transaction;                    
                }

                else if (line.StartsWith("88"))
                {
                    switch (continuation)
                    {
                        case ContinuationType.Group:
                            group.Continuation.Add(line);
                            break;
                        case ContinuationType.Account:
                            account.Continuation.Add(line);
                            break;
                        case ContinuationType.Transaction:
                            detail.Continuation.Add(line);
                            break;
                    }
                }

                else throw new NotImplementedException("I don't know what to do with this line: " + line);

            }

            return bai;
        }
    }

    public enum ContinuationType
    {
        Group,
        Account,
        Transaction
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
        //public string AccountIdentifier { get; internal set; }
        public List<string> Continuation { get; internal set; }
        public List<BaiAccount> Accounts { get; internal set; }
        public string GroupTrailer { get; internal set; }

        public BaiGroup(string line)
        {
            GroupHeader = line;
            Continuation = new List<string>();
            Accounts = new List<BaiAccount>();
        }
    }

    public class BaiAccount
    {
        public string AccountIdentifier { get; internal set; }
        public List<string> Continuation { get; internal set; }
        public List<BaiDetail> Details { get; internal set; }
        public string AccountTrailer { get; internal set; }

        public BaiAccount(string line)
        {
            AccountIdentifier = line;
            Continuation = new List<string>();
            Details = new List<BaiDetail>();
        }
    }

    public class BaiDetail
    {
        public string TransactionDetail { get; private set; }
        public List<string> Continuation { get; internal set; }
        public BaiDetail(string line)
        {
            TransactionDetail = line;
            Continuation = new List<string>();
        }
    }
}

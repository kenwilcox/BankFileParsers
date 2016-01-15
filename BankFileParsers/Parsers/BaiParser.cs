using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                lines.AddRange(group.GroupContinuation);
                foreach (var account in group.Accounts)
                {
                    lines.Add(account.AccountIdentifier);
                    lines.AddRange(account.AccountContinuation);

                    foreach (var detail in account.Details)
                    {
                        lines.Add(detail.TransactionDetail);
                        lines.AddRange(detail.DetailContinuation);
                    }

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
                    account = new BaiAccount(line);
                    detail = new BaiDetail("--default--");
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
                    if (detail.TransactionDetail != "--default--")
                    {
                        account.Details.Add(detail);
                    }
                    continuation = ContinuationType.Detail;
                    detail = new BaiDetail(line);
                }

                else if (line.StartsWith("88"))
                {
                    switch (continuation)
                    {
                        case ContinuationType.Group:
                            group.GroupContinuation.Add(line);
                            break;
                        case ContinuationType.Account:
                            account.AccountContinuation.Add(line);
                            break;
                        case ContinuationType.Detail:
                            detail.DetailContinuation.Add(line);
                            break;
                    }
                }

                else throw new NotImplementedException("I don't know what to do with this line: " + line);

            }

            return bai;
        }
    }
}

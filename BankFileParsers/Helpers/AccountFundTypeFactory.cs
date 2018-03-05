using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BankFileParsers
{
    internal class AccountFundTypeFactory
    {
        public string RecordCode { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CurrencyCode { get; set; }

        private readonly Stack _stack;

        public AccountFundTypeFactory(IEnumerable<string> data)
        {
            var lineData = "";
            foreach (var section in data)
            {
                var line = section.Trim();
                if (!line.EndsWith("/")) throw new Exception("I got a line without a trailing /");
                line = line.Replace("/", "");

                if (line.StartsWith("03"))
                {
                    // The first thre fields are record, account and currency
                    var fields = line.Split(',');
                    RecordCode = fields[0];
                    CustomerAccountNumber = fields[1];
                    CurrencyCode = fields[2];
                    var trailing = fields.Count() > 2? ",":"";
                    var replaced = string.Format("{0},{1},{2}{3}", fields[0], fields[1], fields[2], trailing);
                    line = line.Substring(replaced.Length);
                }
                else if (line.StartsWith("88"))
                {
                    line = line.Substring(2);
                }
                else throw new Exception("I got a bad line: " + line);
                lineData += line;
            }
            _stack = new Stack(lineData.Split(',').Reverse().ToArray());
        }

        public FundType GetNext()
        {
            return FundTypeHelper.GetNext(_stack, CurrencyCode);
        }
    }
}
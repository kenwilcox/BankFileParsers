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

        private string lineData = "";
        private string[] _data;
        private Stack _stack;

        public AccountFundTypeFactory(List<string> data)
        {
            var line = "";
            foreach (var section in data)
            {
                line = section;
                if (!line.EndsWith("/")) throw new Exception("I got a line without a trailing /");
                line = line.Replace("/", "");

                if (line.StartsWith("03"))
                {
                    // The first thre fields are record, account and currency
                    var fields = line.Split(',');
                    RecordCode = fields[0];
                    CustomerAccountNumber = fields[1];
                    CurrencyCode = fields[2];
                    var replaced = string.Format("{0},{1},{2},", fields[0], fields[1], fields[2]);
                    line = line.Substring(replaced.Length);
                }
                else if (line.StartsWith("88"))
                {
                    line = line.Substring(2);
                }
                else throw new Exception("I got a bad line: " + line);
                lineData += line;
            }
            _data = lineData.Split(',');
            var dump = _data.Reverse();
            _stack = new Stack(dump.ToArray());
        }

        public FundType GetNext()
        {
            if (_stack.Count >= 4)
            {
                var typeCode = _stack.Pop().ToString();
                var amount = _stack.Pop().ToString();
                var itemCount = _stack.Pop().ToString();
                var fundsType = _stack.Pop().ToString();

                if (fundsType.ToUpper() == "S")
                {
                    var immediate = _stack.Pop().ToString();
                    var oneDay = _stack.Pop().ToString();
                    var moreDays = _stack.Pop().ToString();

                    return new FundType(typeCode, amount, itemCount, fundsType, immediate, oneDay, moreDays);
                }
                if (fundsType.ToUpper() == "D")
                {
                    // next field is the number of distripution pairs
                    // number of days, avalible amount
                    throw new Exception("I don't want to deal with this one yet");
                }
                if (fundsType.ToUpper() == "V")
                {
                    var date = _stack.Pop().ToString();
                    var time = _stack.Pop().ToString();
                    var value = BaiFileHelpers.DateTimeFromFields(date, time);
                    return new FundType(typeCode, amount, itemCount, fundsType, value);
                }
                return new FundType(typeCode, amount, itemCount, fundsType);
            }
            return null;
        }
    }
}
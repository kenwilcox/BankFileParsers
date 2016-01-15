using System;
using System.Collections.Generic;

namespace BankFileParsers
{
    public class Account
    {
        public string IdentifierRecordCode { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CurrencyCode { get; set; }

        public List<FundType> FundsTypes { get; set; }
        public List<Detail> Details { get; set; }

        public string TrailerRecordCode { get; set; }
        public decimal AccountControlTotal { get; set; }
        public int NumberOfRecords { get; set; }

        public Account(BaiAccount data, string currencyCode)
        {
            FundsTypes = new List<FundType>();
            Details = new List<Detail>();

            var list = new List<string> {data.AccountIdentifier};
            list.AddRange(data.AccountContinuation);

            var factory = new AccountFundTypeFactory(list);
            IdentifierRecordCode = factory.RecordCode;
            CustomerAccountNumber = factory.CustomerAccountNumber;
            CurrencyCode = factory.CurrencyCode;

            var fundType = factory.GetNext();
            while (fundType != null)
            {
                FundsTypes.Add(fundType);
                fundType = factory.GetNext();
            }


            // Time to get the details
            foreach (var detail in data.Details)
            {
                Details.Add(new Detail(detail, currencyCode));
            }

            var fields = data.AccountTrailer.Split(',');
            if (fields.Length != 3) throw new NotImplementedException("Bai file does not have proper number of AccountTrailer elements, I don't know how to handle this");
            TrailerRecordCode = fields[0];
            AccountControlTotal = BaiFileHelpers.GetAmount(fields[1], CurrencyCode);
            NumberOfRecords = int.Parse(fields[2].Replace("/", ""));
        }
    }
}
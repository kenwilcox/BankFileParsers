using System;
using System.Collections.Generic;

namespace BankFileParsers
{
    public class Group
    {
        public string HeaderRecordCode { get; set; }
        public string UltimateReceiverIdentification { get; set; }
        public string OriginatorIdentification { get; set; }
        public GroupStatus GroupStatus { get; set; }
        public DateTime AsOfDateTime { get; set; }
        public string CurrencyCode { get; set; }
        public AsOfDateModifier AsOfDateModifier { get; set; }

        public List<Account> Accounts { get; set; }

        public string TrailerRecordCode { get; set; }
        public string GroupControlTotal { get; set; }
        public int NumberOfAccounts { get; set; }
        public int NumberOfRecords { get; set; }

        public Group(BaiGroup data)
        {
            Accounts = new List<Account>();

            if (!data.GroupHeader.Trim().EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            if (!data.GroupTrailer.Trim().EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            var fields = data.GroupHeader.Trim().Split(',');
            if (fields.Length != 8) throw new NotImplementedException("Bai file does not have proper number of GroupHeader elements, I don't know how to handle this");

            HeaderRecordCode = fields[0];
            UltimateReceiverIdentification = fields[1];
            OriginatorIdentification = fields[2];
            GroupStatus = BaiFileHelpers.GetGroupStatus(fields[3]);
            AsOfDateTime = BaiFileHelpers.DateTimeFromFields(fields[4], fields[5]);
            CurrencyCode = BaiFileHelpers.GetCurrencyCode(fields[6]);
            AsOfDateModifier = BaiFileHelpers.GetAsOfDateModifier(fields[7]);

            foreach (var account in data.Accounts)
            {
                Accounts.Add(new Account(account, CurrencyCode));
            }

            fields = data.GroupTrailer.Split(',');
            if (fields.Length != 4) throw new NotImplementedException("Bai file does not have proper number of FileTrailer elements, I don't know how to handle this");
            TrailerRecordCode = fields[0];
            GroupControlTotal = fields[1];
            NumberOfAccounts = int.Parse(fields[2]);
            NumberOfRecords = int.Parse(fields[3].Replace("/", ""));
        }
    }
}
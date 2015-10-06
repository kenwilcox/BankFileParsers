using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFileParsers
{
    public class BaiTranslator
    {
        public TranslatedBaiFile Translate(BaiFile data)
        {

            return new TranslatedBaiFile(data);
            //lines.Add(data.FileHeader);
            //foreach (var group in data.Groups)
            //{
            //    lines.Add(group.GroupHeader);
            //    lines.AddRange(group.GroupContinuation);
            //    foreach (var account in group.Accounts)
            //    {
            //        lines.Add(account.AccountIdentifier);
            //        lines.AddRange(account.AccountContinuation);

            //        foreach (var detail in account.Details)
            //        {
            //            lines.Add(detail.TransactionDetail);
            //            lines.AddRange(detail.DetailContinuation);
            //        }

            //        lines.Add(account.AccountTrailer);
            //    }
            //    lines.Add(group.GroupTrailer);
            //}
            //lines.Add(data.FileTrailer);
        }
    }

    public class TranslatedBaiFile
    {
        public string HeaderRecordCode { get; set; }
        public string SenderIdentification { get; set; }
        public string ReceiverIdentification { get; set; }
        public DateTime FileCreationDateTime { get; set; }
        public string FileIdentificationNumber { get; set; }
        public string PhysicalRecordLength { get; set; }
        public string BlockSize { get; set; }
        public string VersionNumber { get; set; }

        public List<Group> Groups { get; set; }

        public string TrailerRecordCode { get; set; }
        public string FileControlTotal { get; set; }
        public int NumberOfGroups { get; set; }
        public int NumberOfRecords { get; set; }

        public TranslatedBaiFile(BaiFile data)
        {
            Groups = new List<Group>();

            // Translate myself, and walk the file
            if (!data.FileHeader.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            if (!data.FileTrailer.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            var fields = data.FileHeader.Split(',');
            if (fields.Length != 9) throw new NotImplementedException("Bai file does not have proper number of FileHeader elements, I don't know how to handle this");
            

            HeaderRecordCode = fields[0];
            SenderIdentification = fields[1];
            ReceiverIdentification = fields[2];
            FileIdentificationNumber = fields[5];
            PhysicalRecordLength = fields[6];
            BlockSize = fields[7];
            VersionNumber = fields[8].Replace("/", "");

            if (VersionNumber != "2") throw new NotImplementedException("Bai file not version 2 format, I don't know how to handle this!");

            // Handle date 3, 4
            FileCreationDateTime = BaiFileHelpers.DateTimeFromFields(fields[3], fields[4]);
            // End of Header            

            foreach (var group in data.Groups)
            {
                Groups.Add(new Group(group));
            }

            // Beginning of Trailer
            fields = data.FileTrailer.Split(',');
            if (fields.Length != 4) throw new NotImplementedException("Bai file does not have proper number of FileTrailer elements, I don't know how to handle this");
            TrailerRecordCode = fields[0];
            FileControlTotal = fields[1];
            NumberOfGroups = int.Parse(fields[2]);
            NumberOfRecords = int.Parse(fields[3].Replace("/", ""));
        }
    }

    public enum GroupStatus
    {
        Update = 1,
        Deletion = 2,
        Correction = 3,
        TestOnly = 4
    }

    /// <summary>
    /// Distinguishes same-day data from previous-day data and interim data from final data. As-of-Date Modifier is for identification only and does not affect processing.
    /// Final: Status and Summary data at the close of business on the As-of-Date.
    /// Interim: Status and Summary data may not reflect all activity on the As-of-Date.
    /// Previous-day: As-of-Date is the previous business day.
    /// Same-day: As-of-Date is the current business day. For intraday reporting.
    /// </summary>
    public enum AsOfDateModifier
    {
        InterimPreviousDay = 1,
        FinalPreviousDay = 2,
        InterimSameDay = 3,
        FinalSameDay = 4,
        Missing
    }

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

            if (!data.GroupHeader.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            if (!data.GroupTrailer.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            var fields = data.GroupHeader.Split(',');
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

            var list = new List<string>();
            list.Add(data.AccountIdentifier);
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

    public class Detail
    {
        public Detail(BaiDetail data, string currencyCode)
        {
            var fields = data.TransactionDetail.Split(',');
            if (fields.Length < 2) throw new Exception("ARRRRGH!");
        }
    }

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

    public class FundType
    {
        public string TypeCode { get; set; }
        public string Amount { get; set; }
        public string ItemCount { get; set; }
        public string FundsType { get; set; }
        public string Immediate { get; set; }
        public string OneDay { get; set; }
        public string TwoOrMoreDays { get; set; }
        public DateTime? AvalibleDate { get; set; }

        public FundType(string typeCode, string amount, string itemCount, string fundsType)
        {
            TypeCode = typeCode;
            Amount =amount;
            ItemCount = itemCount;
            FundsType = fundsType;
        }

        public FundType(string typeCode, string amount, string itemCount, string fundsType, string immediate, string oneDay, string moreDays) :
            this(typeCode, amount, itemCount, fundsType)
        {
            Immediate = immediate;
            OneDay = oneDay;
            TwoOrMoreDays = moreDays;
        }

        public FundType(string typeCode, string amount, string itemCount, string fundsType, DateTime avalibleDate) :
            this(typeCode, amount, itemCount, fundsType)
        {
            AvalibleDate = avalibleDate;
        }
    }
}

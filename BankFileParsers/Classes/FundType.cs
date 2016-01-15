using System;
using System.Collections.Generic;

namespace BankFileParsers
{
    public class FundType
    {
        public string TypeCode { get; set; }
        public TransactionDetail Detail { get; set; }
        public string Amount { get; set; }
        public string ItemCount { get; set; }
        public string FundsType { get; set; }
        public string Immediate { get; set; }
        public string OneDay { get; set; }
        public string TwoOrMoreDays { get; set; }
        public DateTime? AvalibleDate { get; set; }
        public string NumberOfDistributions { get; set; }
        public Dictionary<int, decimal> DistributionInfo { get; set; }

        public FundType(string typeCode, string amount, string itemCount, string fundsType)
        {
            TypeCode = typeCode;
            Detail = BaiFileHelpers.GetTransactionDetail(typeCode);
            Amount = amount;
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

        public FundType(string typeCode, string amount, string itemCount, string fundsType, string distributions, Dictionary<int, decimal> info) :
            this(typeCode, amount, itemCount, fundsType)
        {
            NumberOfDistributions = distributions;
            DistributionInfo = info;
        }
    }
}
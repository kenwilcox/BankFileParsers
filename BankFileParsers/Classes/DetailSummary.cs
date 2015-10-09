using System;
using System.Collections.Generic;

namespace BankFileParsers
{
    public class DetailSummary
    {
        [Usage(UsageType.Both)]
        public DateTime Date { get; set; }
        [Usage(UsageType.Oracle)]
        public DateTime CreationDate { get; set; }
        [Usage(UsageType.Oracle)]
        public string FileIdentificationNumber { get; set; }
        [Usage(UsageType.Both)]
        public decimal Amount { get; set; }
        [Usage(UsageType.Both)]
        public string CustomerAccountNumber { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string SenderIdentification { get; set; }
        [Usage(UsageType.Both)]
        public string BankReferenceNumber { get; set; }
        [Usage(UsageType.Both)]
        public string CustomerReferenceNumber { get; set; }
        [Usage(UsageType.Both)]
        public string Text { get; set; }
        [Usage(UsageType.Both)]
        public string TypeCode { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string TypeDescription { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string FundType { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string Immediate { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string OneDay { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string TwoOrMoreDays { get; set; }
        [Usage(UsageType.Mbsi)]
        public Dictionary<string, string> TextDictionary { get; set; }

        public DetailSummary()//List<string> dictionaryKeys)
        {
            TextDictionary = new Dictionary<string, string>();
        }
    }
}

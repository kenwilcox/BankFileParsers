using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFileParsers
{
    /// <summary>
    /// A hodge podge of what Oracle/JD Edwards and Treasury Software export
    /// Hopefully it's enough to do something with
    /// </summary>
    public class SummaryHeader
    {
        // Oracle states the FileCreationDate, which I would guess is wrong
        // Treasury Software states AsOfDate, which should be more correct
        // You can export a file tomorrow for yesterdays date, you don't
        // Want to use tomorrows date, right?
        [Usage(UsageType.Both)]
        public DateTime Date { get; set; }
        [Usage(UsageType.Both)]
        public string SenderIdentification { get; set; }
        [Usage(UsageType.Oracle)]
        public string ReceiverIndetification { get; set; }
        [Usage(UsageType.Oracle)]
        public string FileIdentificationNumber { get; set; }
        [Usage(UsageType.Oracle)]
        public string CurrencyCode { get; set; }
        [Usage(UsageType.Both)]
        public string CustomerAccountNumber { get; set; }
        [Usage(UsageType.Both)]
        public decimal Amount { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string Count { get; set; }
        [Usage(UsageType.TreasurySoftware)]
        public string FundType { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class Usage : Attribute
    {
        public UsageType Type { get; private set; }
        public Usage(UsageType usageType)
        {
            Type = usageType;
        }
    }

    public enum UsageType
    {
        Both,
        Oracle,
        TreasurySoftware
    }
}

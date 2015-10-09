using System.Collections.Generic;

namespace BankFileParsers
{
    public class BaiAccount
    {
        public string AccountIdentifier { get; internal set; }
        public List<string> AccountContinuation { get; internal set; }
        public List<BaiDetail> Details { get; internal set; }
        public string AccountTrailer { get; internal set; }

        public BaiAccount(string line)
        {
            AccountIdentifier = line;
            AccountContinuation = new List<string>();
            Details = new List<BaiDetail>();
        }
    }
}
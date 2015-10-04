using System.Collections.Generic;

namespace BankFileParsers
{
    public class BaiGroup
    {
        public string GroupHeader { get; internal set; }
        public List<string> GroupContinuation { get; internal set; }
        public List<BaiAccount> Accounts { get; internal set; }
        public string GroupTrailer { get; internal set; }

        public BaiGroup(string line)
        {
            GroupHeader = line;
            GroupContinuation = new List<string>();
            Accounts = new List<BaiAccount>();
        }
    }
}
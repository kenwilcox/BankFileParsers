using System.Collections.Generic;

namespace BankFileParsers
{
    public class BaiFile
    {
        public string FileHeader { get; internal set; }
        public List<BaiGroup> Groups { get; internal set; }
        public string FileTrailer { get; internal set; }

        public BaiFile()
        {
            Groups = new List<BaiGroup>();
        }
    }
}
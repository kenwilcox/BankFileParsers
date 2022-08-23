using System.Collections.Generic;

namespace BankFileParsers
{
    public class BaiDetail
    {
        public string TransactionDetail { get; private set; }
        public List<string> DetailContinuation { get; internal set; }
        public BaiDetail(string line)
        {
            TransactionDetail = line;
            DetailContinuation = new List<string>();
        }

        /// <summary>
        /// Overwrite the TransactionDetail line with a new string
        /// </summary>
        /// <param name="line">New string to overwrite with</param>
        public void SetTransactionDetail(string line)
        {
            TransactionDetail = line;
        }
    }
}
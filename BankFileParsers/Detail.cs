using System;

namespace BankFileParsers
{
    public class Detail
    {
        public Detail(BaiDetail data, string currencyCode)
        {
            // TODO: Finish up the Detail object - list of things?
            var fields = data.TransactionDetail.Split(',');
            if (fields.Length < 2) throw new Exception("ARRRRGH!");
        }
    }
}
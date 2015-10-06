using System.Globalization;
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
}

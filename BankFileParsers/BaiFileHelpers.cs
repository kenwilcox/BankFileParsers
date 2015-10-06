using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFileParsers
{
    public static class BaiFileHelpers
    {
        private static List<TransactionDetail> _transactionDetail;
        
        public static DateTime DateTimeFromFields(string date, string time)
        {
            // An end of day can be 9999, if it is they really ment 2400
            var dateString = date;
            if (time == "9999") dateString += "2400";
            else dateString += time;

            return DateTime.ParseExact(dateString, "yyMMddHHmm", CultureInfo.InvariantCulture);
        }

        public static GroupStatus GetGroupStatus(string statusCode)
        {
            var ret = GroupStatus.Update;
            switch (statusCode)
            {
                case "1":
                    ret = GroupStatus.Update;
                    break;
                case "2":
                    ret = GroupStatus.Deletion;
                    break;
                case "3":
                    ret = GroupStatus.Correction;
                    break;
                case "4":
                    ret = GroupStatus.TestOnly;
                    break;
            }
            return ret;
        }

        public static string GetCurrencyCode(string code)
        {
            return code == string.Empty ? "USD" : code;
        }

        private static float GetDivisor(string currencyCode)
        {
            return 100.0f;
        }

        public static decimal GetAmount(string amount, string currencyCode)
        {
            var value = int.Parse(amount);
            var divisor = GetDivisor(currencyCode);
            return (decimal) (value / divisor);
        }

        public static AsOfDateModifier GetAsOfDateModifier(string modifier)
        {
            var ret = AsOfDateModifier.Missing;
            switch (modifier)
            {
                case "1":
                    ret = AsOfDateModifier.InterimPreviousDay;
                    break;
                case "2":
                    ret = AsOfDateModifier.FinalPreviousDay;
                    break;
                case "3":
                    ret = AsOfDateModifier.InterimSameDay;
                    break;
                case "4":
                    ret = AsOfDateModifier.FinalSameDay;
                    break;
            }
            return ret;
        }

        public static TransactionDetail GetTransactionDetail(string typeCode)
        {
            if (_transactionDetail == null) _transactionDetail = TransactionDetailBuilder.Build();
            var item = _transactionDetail.First(i => i.TypeCode == typeCode);
            if (item == null) throw new Exception("Invalid TypeCode: " + typeCode);
            return item;
        }

    }

    public class TransactionDetail
    {
        public CategoryTypeCodes CategoryType { get; set; }
        public string TypeCode { get; set; }
        public TransactionType Transaction { get; set; }
        public LevelType Level { get; set; }
        public string Description { get; set; }
    }

    public enum TransactionType
    {
        Credit,
        Debit,
        NotApplicable,
        Reference
    }


    public enum LevelType
    {
        Status,
        Summary,
        Detail
    }

    public enum CategoryTypeCodes
    {
        UniformBankAdministrationInstituteBalance,
        SummaryAndDetailCredits,
        Lockbox,
        Concentration,
        PreauthorizedAutomatedClearingHouse,
        OtherDeposits,
        MoneyTransfer,
        Security,
        ZeroBalanceAccountDisbursing,
        Other,
        CorrespondentBankFederalReserve,
        Miscellaneous,
        SummaryAndDetailDebits,
        PayableThroughDraft,
        AutomatedClearingHouse,
        ChecksPaid,
        DepositedItemsReturned,
        LoanTransactions,
        NonMonetaryInformation
    }

}

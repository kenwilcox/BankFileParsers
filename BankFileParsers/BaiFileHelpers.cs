using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

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
            if (time == string.Empty) dateString += "0000";
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

        private static int GetDecimalPlaces(string currencyCode)
        {
            currencyCode = GetCurrencyCode(currencyCode);
            var zeroDecimal = new List<string> { "BRL", "EUR", "JPY", "KMF", "XAF", "XOF", "XPF" };
            var oneDecimal = new List<string> { "MRO" };
            var threeDecimal = new List<string> { "BHD", "EGP", "IQD", "JOD", "KWD", "LYD", "MTL", "OMR", "SDP", "TND", "YDD" };

            if (zeroDecimal.Contains(currencyCode)) return 0;
            if (oneDecimal.Contains(currencyCode)) return 1;
            if (threeDecimal.Contains(currencyCode)) return 3;
            // Everything else should be two decimal places
            return 2;
        }

        public static decimal GetAmount(string amount, string currencyCode)
        {
            amount = amount.Insert(amount.Length - GetDecimalPlaces(currencyCode), ".");
            return decimal.Parse(amount);
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
            // It looks like our bank uses type codes that are not in the spec - return a "dummy record"
            var item = _transactionDetail.FirstOrDefault(i => i.TypeCode == typeCode) ?? new TransactionDetail()
            {
                CategoryType = CategoryTypeCodes.NonMonetaryInformation,
                Transaction = TransactionType.NotApplicable,
                Level = LevelType.Status,
                TypeCode = typeCode,
                Description = "Unknown Type Code"
            };
            return item;
        }

    }
}

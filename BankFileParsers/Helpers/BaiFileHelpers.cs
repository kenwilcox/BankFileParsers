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

            const string format = "yyMMddHHmm";
            var hourPos = format.IndexOf("HH", StringComparison.Ordinal);
            var hour = dateString.Substring(hourPos, 2);
            var addDay = hour == "24";
            if (addDay) dateString = dateString.Substring(0, hourPos) + "00" + dateString.Substring(hourPos + 2);

            var dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            if (addDay) dateTime += TimeSpan.FromHours(24);

            return dateTime;
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
            amount = TrimStart(amount, "+");
            var neededLength = GetDecimalPlaces(currencyCode);
            if (string.IsNullOrEmpty(amount)) return 0;
            if (amount.Length < neededLength) amount = amount.PadLeft(neededLength + 1, '0');
            amount = amount.Insert(amount.Length - neededLength, ".");
            return decimal.Parse(amount);
        }

        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
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

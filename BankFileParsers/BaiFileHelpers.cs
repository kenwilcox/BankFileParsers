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
    }
}

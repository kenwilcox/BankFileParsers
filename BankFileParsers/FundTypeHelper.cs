using System;
using System.Collections;

namespace BankFileParsers
{
    public static class FundTypeHelper
    {
        public static FundType GetNext(Stack stack)
        {
            if (stack.Count < 4) return null;
            var typeCode = stack.Pop().ToString();
            var amount = stack.Pop().ToString();
            var itemCount = stack.Pop().ToString();
            var fundsType = stack.Pop().ToString();

            switch (fundsType.ToUpper())
            {
                case "S":
                    var immediate = stack.Pop().ToString();
                    var oneDay = stack.Pop().ToString();
                    var moreDays = stack.Pop().ToString();

                    return new FundType(typeCode, amount, itemCount, fundsType, immediate, oneDay, moreDays);
                case "D":
                    // next field is the number of distripution pairs
                    // number of days, avalible amount
                    throw new Exception("I don't want to deal with this one yet");
                case "V":
                    var date = stack.Pop().ToString();
                    var time = stack.Pop().ToString();
                    var value = BaiFileHelpers.DateTimeFromFields(date, time);
                    return new FundType(typeCode, amount, itemCount, fundsType, value);
            }
            return new FundType(typeCode, amount, itemCount, fundsType);
        }
    }
}

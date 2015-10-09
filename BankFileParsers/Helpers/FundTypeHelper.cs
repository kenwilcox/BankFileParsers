using System.Collections;
using System.Collections.Generic;

namespace BankFileParsers
{
    public static class FundTypeHelper
    {
        public static FundType GetNext(Stack stack, string currencyCode)
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
                    var info = new Dictionary<int, decimal>();
                    var count = int.Parse(stack.Pop().ToString());
                    for (var i = 0; i < count; i++)
                    {
                        var key = int.Parse(stack.Pop().ToString());
                        var v = BaiFileHelpers.GetAmount(stack.Pop().ToString(), currencyCode);
                        info.Add(key, v);
                    }
                    return new FundType(typeCode, amount, itemCount, fundsType, count.ToString(), info);
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

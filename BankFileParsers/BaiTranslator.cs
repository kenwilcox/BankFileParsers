using System;

namespace BankFileParsers
{
    public class BaiTranslator
    {
        public static TranslatedBaiFile Translate(BaiFile data)
        {
            return new TranslatedBaiFile(data);
        }

        private static string Format(string name, object value, int indent)
        {
            var space = "";
            for (var i = 1; i < indent; i++) space += "  ";
            return string.Format("{0}{1}: {2}{3}", space, name, value, Environment.NewLine);
        }

        /// <summary>
        /// Pretty prints the translated object
        /// </summary>
        /// <param name="data">The object to pretty print</param>
        /// <returns>A string of the pretty printed data</returns>
        public static string PrettyPrint(TranslatedBaiFile data, int maxWidth=60)
        {
            // I wanted to make this use reflection, but I also wanted to remove ReShaper warnings/hints
            // This is ugly - almost on purpose - ugh
            var ret = "";
            var indent = 1;

            ret += Format("HeaderRecordCode", data.HeaderRecordCode, indent);
            ret += Format("SenderIdentification", data.SenderIdentification, indent);
            ret += Format("ReceiverIdentification", data.ReceiverIdentification, indent);
            ret += Format("FileCreationDateTime", data.FileCreationDateTime, indent);
            ret += Format("FileIdentificationNumber", data.FileIdentificationNumber, indent);
            ret += Format("PhysicalRecordLength", data.PhysicalRecordLength, indent);
            ret += Format("BlockSize", data.BlockSize, indent);
            ret += Format("VersionNumber", data.VersionNumber, indent);
            
            foreach (var group in data.Groups)
            {
                indent++;
                ret += Format("HeaderRecordCode", group.HeaderRecordCode, indent);
                ret += Format("UltimateReceiverIdentification", group.UltimateReceiverIdentification, indent);
                ret += Format("OriginatorIdentification", group.OriginatorIdentification, indent);
                ret += Format("GroupStatus", group.GroupStatus, indent);
                ret += Format("AsOfDateTime", group.AsOfDateTime, indent);
                ret += Format("CurrencyCode", group.CurrencyCode, indent);
                ret += Format("AsOfDateModifier", group.AsOfDateModifier, indent);

                foreach (var account in group.Accounts)
                {
                    indent++;
                    ret += Format("IdentifierRecordCode", account.IdentifierRecordCode, indent);
                    ret += Format("CustomerAccountNumber", account.CustomerAccountNumber, indent);
                    ret += Format("CurrencyCode", account.CurrencyCode, indent);
                    ret += Format("FundTypes", "", indent);
                    // funds
                    indent++;
                    foreach (var fundType in account.FundsTypes)
                    {
                        ret += Format("TypeCode", fundType.TypeCode, indent);
                        ret += Format("TransactionDetail", "", indent);
                        indent++;
                        ret += Format("CategoryType", fundType.Detail.CategoryType, indent);
                        ret += Format("TypeCode", fundType.Detail.TypeCode, indent);
                        ret += Format("Transaction", fundType.Detail.Transaction, indent);
                        ret += Format("Level", fundType.Detail.Level, indent);
                        ret += Format("Description", fundType.Detail.Description, indent);
                        indent--;

                    }
                    indent--;
                    
                    // details
                    ret += Format("Details", "", indent);
                    indent++;
                    foreach (var detail in account.Details)
                    {
                        ret += Format("Detail", detail.RecordCode, indent);
                        indent++;
                        ret += Format("RecordCode", detail.RecordCode, indent);
                        ret += Format("TypeCode", detail.TypeCode, indent);
                        ret += Format("Amount", detail.Amount, indent);
                        ret += Format("FundsType", detail.FundsType, indent);
                        ret += Format("Immediate", detail.Immediate, indent);
                        ret += Format("OneDay", detail.OneDay, indent);
                        ret += Format("TwoOrMoreDays", detail.TwoOrMoreDays, indent);
                        ret += Format("AvalibleDate", detail.AvalibleDate, indent);
                        ret += Format("BankReferenceNumber", detail.BankReferenceNumber, indent);
                        ret += Format("CustomerReferenceNumber", detail.CustomerReferenceNumber, indent);
                        ret += Format("Text", detail.Text.Substring(0, Math.Min(detail.Text.Length, maxWidth)), indent);
                        indent--;
                    }
                    indent--;
                    ret += Format("TrailerRecordCode", account.TrailerRecordCode, indent);
                    ret += Format("AccountControlTotal", account.AccountControlTotal, indent);
                    ret += Format("NumberOfRecords", account.NumberOfRecords, indent);
                }

                ret += Format("TrailerRecordCode", group.TrailerRecordCode, indent);
                ret += Format("GroupControlTotal", group.GroupControlTotal, indent);
                ret += Format("NumberOfAccounts", group.NumberOfAccounts, indent);
                ret += Format("NumberOfRecords", group.NumberOfRecords, indent);
            }

            indent--;

            ret += Format("TrailerRecordCode", data.TrailerRecordCode, indent);
            ret += Format("FileControlTotal", data.FileControlTotal, indent);
            ret += Format("NumberOfGroups", data.NumberOfGroups, indent);
            ret += Format("NumberOfRecords", data.NumberOfRecords, indent);
            return ret;
        }

        public static string GetSummaryInformation(TranslatedBaiFile data)
        {
            return "--this is just a placeholder--";
        }

        public static string GetDetailInformation(TranslatedBaiFile data)
        {
            return "--this is just a placeholder--";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

    public class TranslatedBaiFile
    {
        public string HeaderRecordCode { get; set; }
        public string SenderIdentification { get; set; }
        public string ReceiverIdentification { get; set; }
        public DateTime FileCreationDateTime { get; set; }
        public string FileIdentificationNumber { get; set; }
        public string PhysicalRecordLength { get; set; }
        public string BlockSize { get; set; }
        public string VersionNumber { get; set; }

        public string TrailerRecordCode { get; set; }
        public string FileControlTotal { get; set; }
        public int NumberOfGroups { get; set; }
        public int NumberOfRecords { get; set; }

        public TranslatedBaiFile(BaiFile data)
        {
            // Translate myself, and walk the file
            if (!data.FileHeader.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            if (!data.FileTrailer.EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            var fields = data.FileHeader.Split(',');
            if (fields.Length != 9) throw new NotImplementedException("Bai file does not have proper number of FileHeader elements, I don't know how to handle this");
            

            HeaderRecordCode = fields[0];
            SenderIdentification = fields[1];
            ReceiverIdentification = fields[2];
            FileIdentificationNumber = fields[5];
            PhysicalRecordLength = fields[6];
            BlockSize = fields[7];
            VersionNumber = fields[8].Replace("/", "");

            if (VersionNumber != "2") throw new NotImplementedException("Bai file not version 2 format, I don't know how to handle this!");

            // Handle date 3, 4
            // An end of day can be 9999, if it is they really ment 2400
            var dateString = fields[3];
            if (fields[4] == "9999") dateString += "2400";
            else dateString += fields[4];

            FileCreationDateTime = DateTime.ParseExact(dateString, "yyMMddHHmm", CultureInfo.InvariantCulture);
            // End of Header

            // Beginning of Trailer
            fields = data.FileTrailer.Split(',');
            if (fields.Length != 4) throw new NotImplementedException("Bai file does not have proper number of FileTrailer elements, I don't know how to handle this");
            TrailerRecordCode = fields[0];
            FileControlTotal = fields[1];
            NumberOfGroups = int.Parse(fields[2]);
            NumberOfRecords = int.Parse(fields[3].Replace("/", ""));
        }
    }
}

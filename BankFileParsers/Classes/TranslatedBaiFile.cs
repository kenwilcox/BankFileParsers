using System;
using System.Collections.Generic;

namespace BankFileParsers
{
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

        public List<Group> Groups { get; set; }

        public string TrailerRecordCode { get; set; }
        public string FileControlTotal { get; set; }
        public int NumberOfGroups { get; set; }
        public int NumberOfRecords { get; set; }

        public TranslatedBaiFile(BaiFile data)
        {
            Groups = new List<Group>();

            // Translate myself, and walk the file
            if (!data.FileHeader.Trim().EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            if (!data.FileTrailer.Trim().EndsWith("/")) throw new NotImplementedException("Bai file is not properly formatted, I don't know how to handle this");
            var fields = data.FileHeader.Trim().Split(',');
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
            FileCreationDateTime = BaiFileHelpers.DateTimeFromFields(fields[3], fields[4]);
            // End of Header

            foreach (var group in data.Groups)
            {
                Groups.Add(new Group(group));
            }

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
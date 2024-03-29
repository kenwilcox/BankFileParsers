﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankFileParsers
{
    public class BaiParser
    {
        private string[] _data;

        /// <summary>
        /// Parse BAI2 file, given path of file.
        /// </summary>
        /// <param name="fileName">Full path of BAI2 file to parse</param>
        /// <returns>A <see cref="BaiFile"/> object</returns>
        /// <exception cref="Exception"></exception>
        public BaiFile Parse(string fileName)
        {
            if (!File.Exists(path: fileName)) throw new Exception(message: "File not found, nothing to parse");
            _data = File.ReadAllLines(path: fileName);
            return InternalParse();
        }

        /// <summary>
        /// Parse contents of a BAI2 file.
        /// </summary>
        /// <param name="fileText">Text contents of BAI2 file</param>
        /// <returns>A <see cref="BaiFile"/> object</returns>
        /// <exception cref="Exception"></exception>
        public BaiFile ParseText(string fileText)
        {
            // Extract all lines from file text by splitting on all possible newline chars
            _data = fileText.Split(separator: new []{"\r\n", "\r", "\n", Environment.NewLine}, options: StringSplitOptions.RemoveEmptyEntries);
            return InternalParse();
        }

        /// <summary>
        /// Construct BAI2 file contents and write to given file.
        /// </summary>
        /// <param name="fileName">Full path of BAI2 file to write to</param>
        /// <param name="data">BAI file data</param>
        public void Write(string fileName, BaiFile data)
        {
            var lines = new List<string>
            {
                data.FileHeader
            };
            foreach (var group in data.Groups)
            {
                lines.Add(group.GroupHeader);
                lines.AddRange(group.GroupContinuation);
                foreach (var account in group.Accounts)
                {
                    lines.Add(account.AccountIdentifier);
                    lines.AddRange(account.AccountContinuation);

                    foreach (var detail in account.Details)
                    {
                        lines.Add(detail.TransactionDetail);
                        lines.AddRange(detail.DetailContinuation);
                    }

                    lines.Add(account.AccountTrailer);
                }
                lines.Add(group.GroupTrailer);
            }
            lines.Add(data.FileTrailer);

            File.WriteAllLines(fileName, lines.ToArray());
        }

        /// <summary>
        /// Construct and return BAI2 file contents as an array of file lines.
        /// </summary>
        /// <param name="data">BAI2 file data contained in a <see cref="BaiFile"/> object</param>
        /// <returns>An array of strings, each corresponding to one line in BAI2 file</returns>
        public string[] GetFileText(BaiFile data)
        {
            var lines = new List<string>
            {
                data.FileHeader
            };
            foreach (var group in data.Groups)
            {
                lines.Add(group.GroupHeader);
                lines.AddRange(group.GroupContinuation);
                foreach (var account in group.Accounts)
                {
                    lines.Add(account.AccountIdentifier);
                    lines.AddRange(account.AccountContinuation);

                    foreach (var detail in account.Details)
                    {
                        lines.Add(detail.TransactionDetail);
                        lines.AddRange(detail.DetailContinuation);
                    }

                    lines.Add(account.AccountTrailer);
                }
                lines.Add(group.GroupTrailer);
            }
            lines.Add(data.FileTrailer);

            return lines.ToArray();
        }

        /// <summary>
        /// Main parser logic
        /// </summary>
        /// <returns>A <see cref="BaiFile"/> object, contained parsed file data</returns>
        /// <exception cref="NotImplementedException"></exception>
        private BaiFile InternalParse()
        {
            var bai = new BaiFile();
            var group = new BaiGroup("--default--");
            var account = new BaiAccount("--default--");
            var detail = new BaiDetail("--default--");
            var continuation = ContinuationType.Account;

            foreach (var data in _data.Select((value, index) => new { value, index }))
            {
                var line = data.value;
                if (data.index == 0 && line.StartsWith("01"))
                    bai.FileHeader = line;
                else if (data.index == _data.Length -1  && line.StartsWith("99"))
                    bai.FileTrailer = line;

                else if (line.StartsWith("02"))
                {
                    continuation = ContinuationType.Group;
                    group = new BaiGroup(line);
                }
                else if (line.StartsWith("98"))
                {
                    group.GroupTrailer = line;
                    bai.Groups.Add(group);
                }

                else if (line.StartsWith("03"))
                {
                    continuation = ContinuationType.Account;
                    account = new BaiAccount(line);
                    detail = new BaiDetail("--default--");
                }

                else if (line.StartsWith("49"))
                {
                    if (detail.TransactionDetail != "--default--")
                        account.Details.Add(detail);
                    account.AccountTrailer = line;
                    group.Accounts.Add(account);
                }

                else if (line.StartsWith("16"))
                {
                    if (detail.TransactionDetail != "--default--")
                    {
                        account.Details.Add(detail);
                    }
                    continuation = ContinuationType.Detail;
                    detail = new BaiDetail(line);
                }

                else if (line.StartsWith("88"))
                {
                    switch (continuation)
                    {
                        case ContinuationType.Group:
                            group.GroupContinuation.Add(line);
                            break;
                        case ContinuationType.Account:
                            account.AccountContinuation.Add(line);
                            break;
                        case ContinuationType.Detail:
                            detail.DetailContinuation.Add(line);
                            break;
                    }
                }

                else throw new NotImplementedException("I don't know what to do with this line: " + line);

            }

            return bai;
        }
    }
}

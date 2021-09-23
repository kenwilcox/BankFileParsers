using System;
using System.Linq;

namespace BuildTransactionDetail
{
    /// <summary>
    /// This program generates the code for the TransactionDetailBuilder.Build method
    /// It was a quick hack in LINQPad, put in here for those folks that don't have it
    /// </summary>
    public static class Program
    {
        private static int _count;
        static void Main()
        {
            _count = 0;
            #region APPENDIX A
            // You should be able to copy/paste the tables in the PDF here
            // each item needs to all be on one line - some wrap to a new line - clean those up first
            // this will generate all the needed TransactionDetail objects
            #region UniformBankAdministrationInstituteBalance - page 46 - pdf 51
            const string uniformBankAdministrationInstituteBalance = @"010 NA Status Opening Ledger
011 NA Status Average Opening Ledger MTD
012 NA Status Average Opening Ledger YTD
015 NA Status Closing Ledger
020 NA Status Average Closing Ledger MTD
021 NA Status Average Closing Ledger – Previous Month
022 NA Status Aggregate Balance Adjustments
024 NA Status Average Closing Ledger YTD – Previous Month
025 NA Status Average Closing Ledger YTD
030 NA Status Current Ledger
037 NA Status ACH Net Position
039 NA Status Opening Available + Total Same-Day ACH DTC Deposit
040 NA Status Opening Available
041 NA Status Average Opening Available MTD
042 NA Status Average Opening Available YTD
043 NA Status Average Available – Previous Month
044 NA Status Disbursing Opening Available Balance
045 NA Status Closing Available
050 NA Status Average Closing Available MTD
051 NA Status Average Closing Available – Last Month
054 NA Status Average Closing Available YTD – Last Month
055 NA Status Average Closing Available YTD
056 NA Status Loan Balance
057 NA Status Total Investment Position
059 NA Status Current Available (CRS Supressed)
060 NA Status Current Available
061 NA Status Average Current Available MTD
062 NA Status Average Current Available YTD
063 NA Status Total Float
065 NA Status Target Balance
066 NA Status Adjusted Balance
067 NA Status Adjusted Balance MTD
068 NA Status Adjusted Balance YTD
070 NA Status 0-Day Float
072 NA Status 1-Day Float
073 NA Status Float Adjustment
074 NA Status 2 or More Days Float
075 NA Status 3 or More Days Float
076 NA Status Adjustment to Balances
077 NA Status Average Adjustment to Balances MTD
078 NA Status Average Adjustment to Balances YTD
079 NA Status 4-Day Float
080 NA Status 5-Day Float
081 NA Status 6-Day Float
082 NA Status Average 1-Day Float MTD
083 NA Status Average 1-Day Float YTD
084 NA Status Average 2-Day Float MTD
085 NA Status Average 2-Day Float YTD
086 NA Status Transfer Calculation";
            #endregion
            #region SummaryAndDetailCredits - page 48 - pdf 53
            const string summaryAndDetailCredits = @"100 CR Summary Total Credits
101 CR Summary Total Credit Amount MTD
105 CR Summary Credits Not Detailed
106 CR Summary Deposits Subject to Float
107 CR Summary Total Adjustment Credits YTD
108 CR Detail Credit (Any Type)
109 CR Summary Current Day Total Lockbox Deposits";
            #endregion
            #region Lockbox - page 49 - pdf 54
            const string lockbox = @"110 CR Summary Total Lockbox Deposits
115 CR Detail Lockbox Deposit
116 CR Detail Item in Lockbox Deposit
118 CR Detail Lockbox Adjustment Credit
120 CR Summary EDI* Transaction Credit
121 CR Detail EDI Transaction Credit
122 CR Detail EDIBANX Credit Received
123 CR Detail EDIBANX Credit Return";
            #endregion
            #region Concentration - page 49 - pdf 54
            const string concentration = @"130 CR Summary Total Concentration Credits
131 CR Summary Total DTC Credits
135 CR Detail DTC Concentration Credit
136 CR Detail Item in DTC Deposit
140 CR Summary Total ACH Credits
142 CR Detail ACH Credit Received
143 CR Detail Item in ACH Deposit
145 CR Detail ACH Concentration Credit
146 CR Summary Total Bank Card Deposits
147 CR Detail Individual Bank Card Deposit";
            #endregion
            #region PreauthorizedAutomatedClearingHouse - page 50 - pdf 55
            const string preauthorizedAutomatedClearingHouse = @"150 CR Summary Total Preauthorized Payment Credits
155 CR Detail Preauthorized Draft Credit
156 CR Detail Item in PAC Deposit
160 CR Summary Total ACH Disbursing Funding Credits
162 CR Summary Corporate Trade Payment Settlement
163 CR Summary Corporate Trade Payment Credits
164 CR Detail Corporate Trade Payment Credit
165 CR Detail Preauthorized ACH Credit
166 CR Detail ACH Settlement
167 CR Summary ACH Settlement Credits
168 CR Detail ACH Return Item or Adjustment Settlement
169 CR Detail Miscellaneous ACH Credit";
            #endregion
            #region OtherDeposits - page 50 - pdf 55
            const string otherDeposits = @"170 CR Summary Total Other Check Deposits
171 CR Detail Individual Loan Deposit
172 CR Detail Deposit Correction
173 CR Detail Bank-Prepared Deposit
174 CR Detail Other Deposit
175 CR Detail Check Deposit Package
176 CR Detail Re-presented Check Deposit
178 CR Summary List Post Credits
180 CR Summary Total Loan Proceeds
182 CR Summary Total Bank-Prepared Deposits
184 CR Detail Draft Deposit
185 CR Summary Total Miscellaneous Deposits
186 CR Summary Total Cash Letter Credits
187 CR Detail Cash Letter Credit
188 CR Summary Total Cash Letter Adjustments
189 CR Detail Cash Letter Adjustment";
            #endregion
            #region MoneyTransfer - page 51 - pdf 56
            const string moneyTransfer = @"190 CR Summary Total Incoming Money Transfers
191 CR Detail Individual Incoming Internal Money Transfer
195 CR Detail Incoming Money Transfer
196 CR Detail Money Transfer Adjustment
198 CR Detail Compensation
200 CR Summary Total Automatic Transfer Credits
201 CR Detail Individual Automatic Transfer Credit
202 CR Detail Bond Operations Credit
205 CR Summary Total Book Transfer Credits
206 CR Detail Book Transfer Credit
207 CR Summary Total International Money Transfer Credits
208 CR Detail Individual International Money Transfer Credit
210 CR Summary Total International Credits
212 CR Detail Foreign Letter of Credit
213 CR Detail Letter of Credit
214 CR Detail Foreign Exchange of Credit
215 CR Summary Total Letters of Credit
216 CR Detail Foreign Remittance Credit
218 CR Detail Foreign Collection Credit
221 CR Detail Foreign Check Purchase
222 CR Detail Foreign Checks Deposited
224 CR Detail Commission
226 CR Detail International Money Market Trading
227 CR Detail Standing Order
229 CR Detail Miscellaneous International Credit";
            #endregion
            #region Security - page 52 - pdf 57
            const string security = @"230 CR Summary Total Security Credits
231 CR Summary Total Collection Credits
232 CR Detail Sale of Debt Security
233 CR Detail Securities Sold
234 CR Detail Sale of Equity Security
235 CR Detail Matured Reverse Repurchase Order
236 CR Detail Maturity of Debt Security
237 CR Detail Individual Collection Credit
238 CR Detail Collection of Dividends
239 CR Summary Total Bankers’ Acceptance Credits
240 CR Detail Coupon Collections – Banks
241 CR Detail Bankers’ Acceptances
242 CR Detail Collection of Interest Income
243 CR Detail Matured Fed Funds Purchased
244 CR Detail Interest/Matured Principal Payment
245 CR Summary Monthly Dividends
246 CR Detail Commercial Paper
247 CR Detail Capital Change
248 CR Detail Savings Bonds Sales Adjustment
249 CR Detail Miscellaneous Security Credit
250 CR Summary Total Checks Posted and Returned
251 CR Summary Total Debit Reversals
252 CR Detail Debit Reversal
254 CR Detail Posting Error Correction Credit
255 CR Detail Check Posted and Returned
256 CR Summary Total ACH Return Items
257 CR Detail Individual ACH Return Item
258 CR Detail ACH Reversal Credit
260 CR Summary Total Rejected Credits
261 CR Detail Individual Rejected Credit
263 CR Detail Overdraft
266 CR Detail Return Item
268 CR Detail Return Item Adjustment";
            #endregion
            #region ZeroBalanceAccountDisbursing - page 54 - pdf 59
            const string zeroBalanceAccountDisbursing = @"270 CR Summary Total ZBA Credits
271 CR Summary Net Zero-Balance Amount
274 CR Detail Cumulative** ZBA or Disbursement Credits
275 CR Detail ZBA Credit
276 CR Detail ZBA Float Adjustment
277 CR Detail ZBA Credit Transfer
278 CR Detail ZBA Credit Adjustment
280 CR Summary Total Controlled Disbursing Credits
281 CR Detail Individual Controlled Disbursing Credit
285 CR Summary Total DTC Disbursing Credits
286 CR Detail Individual DTC Disbursing Credit";
            #endregion
            #region Other - page 54 - pdf 59
            const string other = @"294 CR Summary Total ATM Credits
295 CR Detail ATM Credit
301 CR Detail Commercial Deposit
302 CR Summary Correspondent Bank Deposit
303 CR Summary Total Wire Transfers In – FF
304 CR Summary Total Wire Transfers In – CHF
305 CR Summary Total Fed Funds Sold
306 CR Detail Fed Funds Sold
307 CR Summary Total Trust Credits
308 CR Detail Trust Credit
309 CR Summary Total Value - Dated Funds
310 CR Summary Total Commercial Deposits
315 CR Summary Total International Credits – FF
316 CR Summary Total International Credits – CHF
318 CR Summary Total Foreign Check Purchased
319 CR Summary Late Deposit
320 CR Summary Total Securities Sold – FF
321 CR Summary Total Securities Sold – CHF
324 CR Summary Total Securities Matured – FF
325 CR Summary Total Securities Matured – CHF
326 CR Summary Total Securities Interest
327 CR Summary Total Securities Matured
328 CR Summary Total Securities Interest – FF
329 CR Summary Total Securities Interest – CHF
330 CR Summary Total Escrow Credits
331 CR Detail Individual Escrow Credit
332 CR Summary Total Miscellaneous Securities Credits – FF
336 CR Summary Total Miscellaneous Securities Credits – CHF
338 CR Summary Total Securities Sold
340 CR Summary Total Broker Deposits
341 CR Summary Total Broker Deposits – FF
342 CR Detail Broker Deposit
343 CR Summary Total Broker Deposits – CHF
344 CR Detail Individual Back Value Credit
345 CR Detail Item in Brokers Deposit
346 CR Detail Sweep Interest Income
347 CR Detail Sweep Principal Sell
348 CR Detail Futures Credit
349 CR Detail Principal Payments Credit
350 CR Summary Investment Sold
351 CR Detail Individual Investment Sold
352 CR Summary Total Cash Center Credits
353 CR Detail Cash Center Credit
354 CR Detail Interest Credit
355 CR Summary Investment Interest
356 CR Summary Total Credit Adjustment
357 CR Detail Credit Adjustment
358 CR Detail YTD Adjustment Credit
359 CR Detail Interest Adjustment Credit
360 CR Summary Total Credits Less Wire Transfer and Returned Checks
361 CR Summary Grand Total Credits Less Grand Total Debits";
            #endregion
            #region CorrespondentBankFederalReserve - page 56 - pdf 61
            const string correspondentBankFederalReserve = @"362 CR Detail Correspondent Collection
363 CR Detail Correspondent Collection Adjustment
364 CR Detail Loan Participation
366 CR Detail Currency and Coin Deposited
367 CR Detail Food Stamp Letter
368 CR Detail Food Stamp Adjustment
369 CR Detail Clearing Settlement Credit
370 CR Summary Total Back Value Credits
372 CR Detail Back Value Adjustment
373 CR Detail Customer Payroll
374 CR Detail FRB Statement Recap
376 CR Detail Savings Bond Letter or Adjustment
377 CR Detail Treasury Tax and Loan Credit
378 CR Detail Transfer of Treasury Credit
379 CR Detail FRB Government Checks Cash Letter Credit
381 CR Detail FRB Government Check Adjustment
382 CR Detail FRB Postal Money Order Credit
383 CR Detail FRB Postal Money Order Adjustment
384 CR Detail FRB Cash Letter Auto Charge Credit
385 CR Summary Total Universal Credits
386 CR Detail FRB Cash Letter Auto Charge Adjustment
387 CR Detail FRB Fine-Sort Cash Letter Credit
388 CR Detail FRB Fine-Sort Adjustment
389 CR Summary Total Freight Payment Credits";
            #endregion
            #region Miscellaneous - page 57 - pdf 62
            const string miscellaneous = @"390 CR Summary Total Miscellaneous Credits
391 CR Detail Universal Credit
392 CR Detail Freight Payment Credit
393 CR Detail Itemized Credit Over $10,000
394 CR Detail Cumulative** Credits
395 CR Detail Check Reversal
397 CR Detail Float Adjustment
398 CR Detail Miscellaneous Fee Refund
399 CR Detail Miscellaneous Credit";
            #endregion
            #region SummaryAndDetailDebits - page 58 - pdf 63
            const string summaryAndDetailDebits = @"400 DB Summary Total Debits
401 DB Summary Total Debit Amount MTD
403 DB Summary Today’s Total Debits
405 DB Summary Total Debit Less Wire Transfers and Charge-Backs
406 DB Summary Debits not Detailed
408 DB Detail Float Adjustment
409 DB Detail Debit (Any Type)
410 DB Summary Total YTD Adjustment
412 DB Summary Total Debits (Excluding Returned Items)";
            #endregion
            #region LockboxDebits - page 59 - pdf 64
            const string lockboxDebits = @"415 DB Detail Lockbox Debit
416 DB Summary Total Lockbox Debits
420 DB Summary EDI Transaction Debits
421 DB Detail EDI Transaction Debit
422 DB Detail EDIBANX Settlement Debit
423 DB Detail EDIBANX Return Item Debit";
            #endregion
            #region PayableThroughDraft - page 59 - pdf 64
            const string payableThroughDraft = @"430 DB Summary Total Payable–Through Drafts
435 DB Detail Payable–Through Draft";
            #endregion
            #region AutomatedClearingHouse - page 59 - pdf 64
            const string automatedClearingHouse = @"445 DB Detail ACH Concentration Debit
446 DB Summary Total ACH Disbursement Funding Debits
447 DB Detail ACH Disbursement Funding Debit
450 DB Summary Total ACH Debits
451 DB Detail ACH Debit Received
452 DB Detail Item in ACH Disbursement or Debit
455 DB Detail Preauthorized ACH Debit
462 DB Detail Account Holder Initiated ACH Debit
463 DB Summary Corporate Trade Payment Debits
464 DB Detail Corporate Trade Payment Debit
465 DB Summary Corporate Trade Payment Settlement
466 DB Detail ACH Settlement
467 DB Summary ACH Settlement Debits
468 DB Detail ACH Return Item or Adjustment Settlement
469 DB Detail Miscellaneous ACH Debit";
            #endregion
            #region ChecksPaid - page 60 - pdf 65
            const string checksPaid = @"470 DB Summary Total Check Paid
471 DB Summary Total Check Paid – Cumulative MTD
472 DB Detail Cumulative** Checks Paid
474 DB Detail Certified Check Debit
475 DB Detail Check Paid
476 DB Detail Federal Reserve Bank Letter Debit
477 DB Detail Bank Originated Debit
478 DB Summary List Post Debits
479 DB Detail List Post Debit
480 DB Summary Total Loan Payments
481 DB Detail Individual Loan Payment
482 DB Summary Total Bank-Originated Debits
484 DB Detail Draft
485 DB Detail DTC Debit
486 DB Summary Total Cash Letter Debits
487 DB Detail Cash Letter Debit
489 DB Detail Cash Letter Adjustment";
            #endregion
            #region MoneyTransferDebits - page 61 - pdf 66
            const string moneyTransferDebits = @"490 DB Summary Total Outgoing Money Transfers
491 DB Detail Individual Outgoing Internal Money Transfer
493 DB Detail Customer Terminal Initiated Money Transfer
495 DB Detail Outgoing Money Transfer
496 DB Detail Money Transfer Adjustment
498 DB Detail Compensation
500 DB Summary Total Automatic Transfer Debits
501 DB Detail Individual Automatic Transfer Debit
502 DB Detail Bond Operations Debit
505 DB Summary Total Book Transfer Debits
506 DB Detail Book Transfer Debit
507 DB Summary Total International Money Transfer Debits
508 DB Detail Individual International Money Transfer Debits
510 DB Summary Total International Debits
512 DB Detail Letter of Credit Debit
513 DB Detail Letter of Credit
514 DB Detail Foreign Exchange Debit
515 DB Summary Total Letters of Credit
516 DB Detail Foreign Remittance Debit
518 DB Detail Foreign Collection Debit
522 DB Detail Foreign Checks Paid
524 DB Detail Commission
526 DB Detail International Money Market Trading
527 DB Detail Standing Order
529 DB Detail Miscellaneous International Debit";
            #endregion
            #region SecurityDebits - page 62 - pdf 67
            const string securityDebits = @"530 DB Summary Total Security Debits
531 DB Detail Securities Purchased
532 DB Summary Total Amount of Securities Purchased
533 DB Detail Security Collection Debit
534 DB Summary Total Miscellaneous Securities DB – FF
535 DB Detail Purchase of Equity Securities
536 DB Summary Total Miscellaneous Securities Debit – CHF
537 DB Summary Total Collection Debit
538 DB Detail Matured Repurchase Order
539 DB Summary Total Bankers’ Acceptances Debit
540 DB Detail Coupon Collection Debit
541 DB Detail Bankers’ Acceptances
542 DB Detail Purchase of Debt Securities
543 DB Detail Domestic Collection
544 DB Detail Interest/Matured Principal Payment
546 DB Detail Commercial paper
547 DB Detail Capital Change
548 DB Detail Savings Bonds Sales Adjustment
549 DB Detail Miscellaneous Security Debit";
            #endregion
            #region DepositedItemsReturned - page 63 - pdf 68
            const string depositedItemsReturned = @"550 DB Summary Total Deposited Items Returned
551 DB Summary Total Credit Reversals
552 DB Detail Credit Reversal
554 DB Detail Posting Error Correction Debit
555 DB Detail Deposited Item Returned
556 DB Summary Total ACH Return Items
557 DB Detail Individual ACH Return Item
558 DB Detail ACH Reversal Debit
560 DB Summary Total Rejected Debits
561 DB Detail Individual Rejected Debit
563 DB Detail Overdraft
564 DB Detail Overdraft Fee
566 DB Detail Return Item
567 DB Detail Return Item Fee
568 DB Detail Return Item Adjustment";
            #endregion
            #region ZeroBalanceAccountDisbursingDebits - page 64 - pdf 69
            const string zeroBalanceAccountDisbursingDebits = @"570 DB Summary Total ZBA Debits
574 DB Detail Cumulative ZBA Debits
575 DB Detail ZBA Debit
577 DB Detail ZBA Debit Transfer
578 DB Detail ZBA Debit Adjustment
580 DB Summary Total Controlled Disbursing Debits
581 DB Detail Individual Controlled Disbursing Debit
583 DB Summary Total Disbursing Checks Paid – Early Amount
584 DB Summary Total Disbursing Checks Paid – Later Amount
585 DB Summary Disbursing Funding Requirement
586 DB Summary FRB Presentment Estimate (Fed Estimate)
587 DB Summary Late Debits (After Notification)
588 DB Summary Total Disbursing Checks Paid-Last Amount";
            #endregion
            #region OtherDebits - page 64 - pdf 69
            const string otherDebits = @"590 DB Summary Total DTC Debits
594 DB Summary Total ATM Debits
595 DB Detail ATM Debit
596 DB Summary Total APR Debits
597 DB Detail ARP Debit
601 DB Summary Estimated Total Disbursement
602 DB Summary Adjusted Total Disbursement
610 DB Summary Total Funds Required
611 DB Summary Total Wire Transfers Out- CHF
612 DB Summary Total Wire Transfers Out – FF
613 DB Summary Total International Debit – CHF
614 DB Summary Total International Debit – FF
615 DB Summary Total Federal Reserve Bank – Commercial Bank Debit
616 DB Detail Federal Reserve Bank – Commercial Bank Debit
617 DB Summary Total Securities Purchased – CHF
618 DB Summary Total Securities Purchased – FF
621 DB Summary Total Broker Debits – CHF
622 DB Detail Broker Debit
623 DB Summary Total Broker Debits – FF
625 DB Summary Total Broker Debits
626 DB Summary Total Fed Funds Purchased
627 DB Detail Fed Funds Purchased
628 DB Summary Total Cash Center Debits
629 DB Detail Cash Center Debit
630 DB Summary Total Debit Adjustments
631 DB Detail Debit Adjustment
632 DB Summary Total Trust Debits
633 DB Detail Trust Debit
634 DB Detail YTD Adjustment Debit
640 DB Summary Total Escrow Debits
641 DB Detail Individual Escrow Debit
644 DB Detail Individual Back Value Debit
646 DB Summary Transfer Calculation Debit
650 DB Summary Investments Purchased
651 DB Detail Individual Investment purchased
654 DB Detail Interest Debit
655 DB Summary Total Investment Interest Debits
656 DB Detail Sweep Principal Buy
657 DB Detail Futures Debit
658 DB Detail Principal Payments Debit
659 DB Detail Interest Adjustment Debit";
            #endregion
            #region CorrespondentBankFederalReserveDebits - page 66 - pdf 71
            const string correspondentBankFederalReserveDebits = @"661 DB Detail Account Analysis Fee
662 DB Detail Correspondent Collection Debit
663 DB Detail Correspondent Collection Adjustment
664 DB Detail Loan Participation
665 DB Summary Intercept Debits
666 DB Detail Currency and Coin Shipped
667 DB Detail Food Stamp Letter
668 DB Detail Food Stamp Adjustment
669 DB Detail Clearing Settlement Debit
670 DB Summary Total Back Value Debits
672 DB Detail Back Value Adjustment
673 DB Detail Customer Payroll
674 DB Detail FRB Statement Recap
676 DB Detail Savings Bond Letter or Adjustment
677 DB Detail Treasury Tax and Loan Debit
678 DB Detail Transfer of Treasury Debit
679 DB Detail FRB Government Checks Cash Letter Debit
681 DB Detail FRB Government Check Adjustment
682 DB Detail FRB Postal Money Order Debit
683 DB Detail FRB Postal Money Order Adjustment
684 DB Detail FRB Cash Letter Auto Charge Debit
685 DB Summary Total Universal Debits
686 DB Detail FRB Cash Letter Auto Charge Adjustment
687 DB Detail FRB Fine-Sort Cash Letter Debit
688 DB Detail FRB Fine-Sort Adjustment
689 DB Summary FRB Freight Payment Debits
690 DB Summary Total Miscellaneous Debits
691 DB Detail Universal Debit
692 DB Detail Freight Payment Debit
693 DB Detail Itemized Debit Over $10,000
694 DB Detail Deposit Reversal
695 DB Detail Deposit Correction Debit
696 DB Detail Regular Collection Debit
697 DB Detail Cumulative** Debits
698 DB Detail Miscellaneous Fees
699 DB Detail Miscellaneous Debit";
            #endregion
            #region LoanTransactions - page 68 - pdf 73
            const string loanTransactions = @"701 NA Status Principal Loan Balance
703 NA Status Available Commitment Amount
705 NA Status Payment Amount Due
707 NA Status Principal Amount Past Due
709 NA Status Interest Amount Past Due
720 CR Summary Total Loan Payment
721 CR Detail Amount Applied to Interest
722 CR Detail Amount Applied to Principal
723 CR Detail Amount Applied to Escrow
724 CR Detail Amount Applied to Late Charges
725 CR Detail Amount Applied to Buydown
726 CR Detail Amount Applied to Misc. Fees
727 CR Detail Amount Applied to Deferred Interest Detail
728 CR Detail Amount Applied to Service Charge
760 DB Summary Loan Disbursement";
            #endregion
            #region NonMonetaryInformation - page 68 - pdf 73
            const string nonMonetaryInformation = @"890 ---- Detail Contains Non-monetary Information";
            #endregion
            #endregion

            #region Export method calls
            Export(uniformBankAdministrationInstituteBalance, "CategoryTypeCodes.UniformBankAdministrationInstituteBalance");
            Export(summaryAndDetailCredits, "CategoryTypeCodes.SummaryAndDetailCredits");
            Export(lockbox, "CategoryTypeCodes.Lockbox");
            Export(concentration, "CategoryTypeCodes.Concentration");
            Export(preauthorizedAutomatedClearingHouse, "CategoryTypeCodes.PreauthorizedAutomatedClearingHouse");
            Export(otherDeposits, "CategoryTypeCodes.OtherDeposits");
            Export(moneyTransfer, "CategoryTypeCodes.MoneyTransfer");
            Export(security, "CategoryTypeCodes.Security");
            Export(zeroBalanceAccountDisbursing, "CategoryTypeCodes.ZeroBalanceAccountDisbursing");
            Export(other, "CategoryTypeCodes.Other");
            Export(correspondentBankFederalReserve, "CategoryTypeCodes.CorrespondentBankFederalReserve");
            Export(miscellaneous, "CategoryTypeCodes.Miscellaneous");
            Export(summaryAndDetailDebits, "CategoryTypeCodes.SummaryAndDetailDebits");
            Export(lockboxDebits, "CategoryTypeCodes.Lockbox"); // This isn't a different group - distinguish by trans type
            Export(payableThroughDraft, "CategoryTypeCodes.PayableThroughDraft");
            Export(automatedClearingHouse, "CategoryTypeCodes.AutomatedClearingHouse");
            Export(checksPaid, "CategoryTypeCodes.ChecksPaid");
            Export(moneyTransferDebits, "CategoryTypeCodes.MoneyTransfer"); // This isn't a different group - distinguish by trans type
            Export(securityDebits, "CategoryTypeCodes.Security"); // This isn't a different group - distinguish by trans type
            Export(depositedItemsReturned, "CategoryTypeCodes.DepositedItemsReturned");
            Export(zeroBalanceAccountDisbursingDebits, "CategoryTypeCodes.ZeroBalanceAccountDisbursing"); // This isn't a different group - distinguish by trans type
            Export(otherDebits, "CategoryTypeCodes.Other"); // This isn't a different group - distinguish by trans type
            Export(correspondentBankFederalReserveDebits, "CategoryTypeCodes.CorrespondentBankFederalReserve"); // This isn't a different group - distinguish by trans type
            Export(loanTransactions, "CategoryTypeCodes.LoanTransactions");
            Export(nonMonetaryInformation, "CategoryTypeCodes.NonMonetaryInformation");
            #endregion
            Console.WriteLine("//Count: " + _count);
        }

        private static void Export(string data, string categoryType)
        {
            var lines = data.Split(new[] { Environment.NewLine, "\r", "\n" }, StringSplitOptions.None);
            Console.WriteLine("#region " + categoryType.Replace("CategoryTypeCodes.", ""));
            foreach (var line in lines)
            {
                _count++;
                var detail = GetTransactionDetail(categoryType, line);
                Console.WriteLine(detail);
            }
            Console.WriteLine("#endregion");
        }


        // Define other methods and classes here
        private static string GetTransactionType(string transType)
        {
            switch (transType)
            {
                case "NA": return "TransactionType.NotApplicable";
                case "CR": return "TransactionType.Credit";
                case "DB": return "TransactionType.Debit";
                case "----": return "TransactionType.Reference";
            }
            throw new Exception("I don't understand TransType: " + transType);
        }

        private static string GetLevelType(string levelType)
        {
            switch (levelType)
            {
                case "Status": return "LevelType.Status";
                case "Summary": return "LevelType.Summary";
                case "Detail": return "LevelType.Detail";
            }
            throw new Exception("I don't understand LevelType: " + levelType);
        }

        private static string GetTransactionDetail(string categoryType, string line)
        {
            // break up the line into bits
            var parts = line.Split(' ');
            var index = 0;
            var typeCode = parts[index++];
            var transactionType = GetTransactionType(parts[index++]);
            var levelType = GetLevelType(parts[index++]);
            var rest = parts.Skip(index).Take(parts.Length - index).ToArray();
            var description = string.Join(" ", rest);
            // I don't care to have asterisks in my description - you can keep them if you want
            description = description.Replace("*", "");

            return _transactionDetailTemplate
              .Replace("%CATEGORYTYPE%", categoryType)
              .Replace("%TRANSACTIONTYPE%", transactionType)
              .Replace("%LEVELTYPE%", levelType)
              .Replace("%TYPECODE%", "\"" + typeCode + "\"")
              .Replace("%DESCRIPTION%", "\"" + description + "\"");
        }

        private const string _transactionDetailTemplate = @"new TransactionDetail()
{
  CategoryType = %CATEGORYTYPE%,
  Transaction = %TRANSACTIONTYPE%,
  Level = %LEVELTYPE%,
  TypeCode = %TYPECODE%,
  Description = %DESCRIPTION%
},";
    }
}

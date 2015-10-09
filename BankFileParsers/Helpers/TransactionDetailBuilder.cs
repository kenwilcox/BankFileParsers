using System.Collections.Generic;

namespace BankFileParsers
{
    public static class TransactionDetailBuilder
    {
        /// <summary>
        /// This code was generated using BuildTransactionDetail tool. It would be silly to modify this by hand.
        /// Please update this code using the BuildTransactionDetail tool.
        /// It is already configured to dump the code to out.txt in the build directory
        /// </summary>
        /// <returns></returns>
        public static List<TransactionDetail> Build()
        {
            var list = new List<TransactionDetail>
            {
                #region UniformBankAdministrationInstituteBalance
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "010",
                    Description = "Opening Ledger"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "011",
                    Description = "Average Opening Ledger MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "012",
                    Description = "Average Opening Ledger YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "015",
                    Description = "Closing Ledger"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "020",
                    Description = "Average Closing Ledger MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "021",
                    Description = "Average Closing Ledger – Previous Month"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "022",
                    Description = "Aggregate Balance Adjustments"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "024",
                    Description = "Average Closing Ledger YTD – Previous Month"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "025",
                    Description = "Average Closing Ledger YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "030",
                    Description = "Current Ledger"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "037",
                    Description = "ACH Net Position"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "039",
                    Description = "Opening Available + Total Same-Day ACH DTC Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "040",
                    Description = "Opening Available"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "041",
                    Description = "Average Opening Available MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "042",
                    Description = "Average Opening Available YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "043",
                    Description = "Average Available – Previous Month"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "044",
                    Description = "Disbursing Opening Available Balance"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "045",
                    Description = "Closing Available"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "050",
                    Description = "Average Closing Available MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "051",
                    Description = "Average Closing Available – Last Month"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "054",
                    Description = "Average Closing Available YTD – Last Month"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "055",
                    Description = "Average Closing Available YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "056",
                    Description = "Loan Balance"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "057",
                    Description = "Total Investment Position"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "059",
                    Description = "Current Available (CRS Supressed)"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "060",
                    Description = "Current Available"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "061",
                    Description = "Average Current Available MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "062",
                    Description = "Average Current Available YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "063",
                    Description = "Total Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "065",
                    Description = "Target Balance"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "066",
                    Description = "Adjusted Balance"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "067",
                    Description = "Adjusted Balance MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "068",
                    Description = "Adjusted Balance YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "070",
                    Description = "0-Day Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "072",
                    Description = "1-Day Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "073",
                    Description = "Float Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "074",
                    Description = "2 or More Days Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "075",
                    Description = "3 or More Days Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "076",
                    Description = "Adjustment to Balances"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "077",
                    Description = "Average Adjustment to Balances MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "078",
                    Description = "Average Adjustment to Balances YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "079",
                    Description = "4-Day Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "080",
                    Description = "5-Day Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "081",
                    Description = "6-Day Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "082",
                    Description = "Average 1-Day Float MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "083",
                    Description = "Average 1-Day Float YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "084",
                    Description = "Average 2-Day Float MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "085",
                    Description = "Average 2-Day Float YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.UniformBankAdministrationInstituteBalance,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "086",
                    Description = "Transfer Calculation"
                },

                #endregion
                #region SummaryAndDetailCredits
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "100",
                    Description = "Total Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "101",
                    Description = "Total Credit Amount MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "105",
                    Description = "Credits Not Detailed"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "106",
                    Description = "Deposits Subject to Float"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "107",
                    Description = "Total Adjustment Credits YTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "108",
                    Description = "Credit (Any Type)"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailCredits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "109",
                    Description = "Current Day Total Lockbox Deposits"
                },

                #endregion
                #region Lockbox
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "110",
                    Description = "Total Lockbox Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "115",
                    Description = "Lockbox Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "116",
                    Description = "Item in Lockbox Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "118",
                    Description = "Lockbox Adjustment Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "120",
                    Description = "EDI Transaction Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "121",
                    Description = "EDI Transaction Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "122",
                    Description = "EDIBANX Credit Received"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "123",
                    Description = "EDIBANX Credit Return"
                },

                #endregion
                #region Concentration
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "130",
                    Description = "Total Concentration Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "131",
                    Description = "Total DTC Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "135",
                    Description = "DTC Concentration Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "136",
                    Description = "Item in DTC Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "140",
                    Description = "Total ACH Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "142",
                    Description = "ACH Credit Received"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "143",
                    Description = "Item in ACH Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "145",
                    Description = "ACH Concentration Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "146",
                    Description = "Total Bank Card Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Concentration,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "147",
                    Description = "Individual Bank Card Deposit"
                },

                #endregion
                #region PreauthorizedAutomatedClearingHouse
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "150",
                    Description = "Total Preauthorized Payment Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "155",
                    Description = "Preauthorized Draft Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "156",
                    Description = "Item in PAC Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "160",
                    Description = "Total ACH Disbursing Funding Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "162",
                    Description = "Corporate Trade Payment Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "163",
                    Description = "Corporate Trade Payment Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "164",
                    Description = "Corporate Trade Payment Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "165",
                    Description = "Preauthorized ACH Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "166",
                    Description = "ACH Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "167",
                    Description = "ACH Settlement Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "168",
                    Description = "ACH Return Item or Adjustment Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PreauthorizedAutomatedClearingHouse,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "169",
                    Description = "Miscellaneous ACH Credit"
                },

                #endregion
                #region OtherDeposits
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "170",
                    Description = "Total Other Check Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "171",
                    Description = "Individual Loan Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "172",
                    Description = "Deposit Correction"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "173",
                    Description = "Bank-Prepared Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "174",
                    Description = "Other Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "175",
                    Description = "Check Deposit Package"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "176",
                    Description = "Re-presented Check Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "178",
                    Description = "List Post Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "180",
                    Description = "Total Loan Proceeds"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "182",
                    Description = "Total Bank-Prepared Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "184",
                    Description = "Draft Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "185",
                    Description = "Total Miscellaneous Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "186",
                    Description = "Total Cash Letter Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "187",
                    Description = "Cash Letter Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "188",
                    Description = "Total Cash Letter Adjustments"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.OtherDeposits,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "189",
                    Description = "Cash Letter Adjustment"
                },

                #endregion
                #region MoneyTransfer
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "190",
                    Description = "Total Incoming Money Transfers"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "191",
                    Description = "Individual Incoming Internal Money Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "195",
                    Description = "Incoming Money Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "196",
                    Description = "Money Transfer Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "198",
                    Description = "Compensation"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "200",
                    Description = "Total Automatic Transfer Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "201",
                    Description = "Individual Automatic Transfer Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "202",
                    Description = "Bond Operations Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "205",
                    Description = "Total Book Transfer Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "206",
                    Description = "Book Transfer Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "207",
                    Description = "Total International Money Transfer Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "208",
                    Description = "Individual International Money Transfer Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "210",
                    Description = "Total International Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "212",
                    Description = "Foreign Letter of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "213",
                    Description = "Letter of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "214",
                    Description = "Foreign Exchange of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "215",
                    Description = "Total Letters of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "216",
                    Description = "Foreign Remittance Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "218",
                    Description = "Foreign Collection Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "221",
                    Description = "Foreign Check Purchase"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "222",
                    Description = "Foreign Checks Deposited"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "224",
                    Description = "Commission"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "226",
                    Description = "International Money Market Trading"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "227",
                    Description = "Standing Order"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "229",
                    Description = "Miscellaneous International Credit"
                },

                #endregion
                #region Security
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "230",
                    Description = "Total Security Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "231",
                    Description = "Total Collection Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "232",
                    Description = "Sale of Debt Security"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "233",
                    Description = "Securities Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "234",
                    Description = "Sale of Equity Security"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "235",
                    Description = "Matured Reverse Repurchase Order"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "236",
                    Description = "Maturity of Debt Security"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "237",
                    Description = "Individual Collection Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "238",
                    Description = "Collection of Dividends"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "239",
                    Description = "Total Bankers’ Acceptance Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "240",
                    Description = "Coupon Collections – Banks"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "241",
                    Description = "Bankers’ Acceptances"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "242",
                    Description = "Collection of Interest Income"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "243",
                    Description = "Matured Fed Funds Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "244",
                    Description = "Interest/Matured Principal Payment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "245",
                    Description = "Monthly Dividends"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "246",
                    Description = "Commercial Paper"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "247",
                    Description = "Capital Change"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "248",
                    Description = "Savings Bonds Sales Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "249",
                    Description = "Miscellaneous Security Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "250",
                    Description = "Total Checks Posted and Returned"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "251",
                    Description = "Total Debit Reversals"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "252",
                    Description = "Debit Reversal"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "254",
                    Description = "Posting Error Correction Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "255",
                    Description = "Check Posted and Returned"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "256",
                    Description = "Total ACH Return Items"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "257",
                    Description = "Individual ACH Return Item"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "258",
                    Description = "ACH Reversal Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "260",
                    Description = "Total Rejected Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "261",
                    Description = "Individual Rejected Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "263",
                    Description = "Overdraft"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "266",
                    Description = "Return Item"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "268",
                    Description = "Return Item Adjustment"
                },

                #endregion
                #region ZeroBalanceAccountDisbursing
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "270",
                    Description = "Total ZBA Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "271",
                    Description = "Net Zero-Balance Amount"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "274",
                    Description = "Cumulative ZBA or Disbursement Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "275",
                    Description = "ZBA Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "276",
                    Description = "ZBA Float Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "277",
                    Description = "ZBA Credit Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "278",
                    Description = "ZBA Credit Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "280",
                    Description = "Total Controlled Disbursing Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "281",
                    Description = "Individual Controlled Disbursing Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "285",
                    Description = "Total DTC Disbursing Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "286",
                    Description = "Individual DTC Disbursing Credit"
                },

                #endregion
                #region Other
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "294",
                    Description = "Total ATM Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "295",
                    Description = "ATM Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "301",
                    Description = "Commercial Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "302",
                    Description = "Correspondent Bank Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "303",
                    Description = "Total Wire Transfers In – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "304",
                    Description = "Total Wire Transfers In – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "305",
                    Description = "Total Fed Funds Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "306",
                    Description = "Fed Funds Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "307",
                    Description = "Total Trust Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "308",
                    Description = "Trust Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "309",
                    Description = "Total Value - Dated Funds"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "310",
                    Description = "Total Commercial Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "315",
                    Description = "Total International Credits – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "316",
                    Description = "Total International Credits – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "318",
                    Description = "Total Foreign Check Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "319",
                    Description = "Late Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "320",
                    Description = "Total Securities Sold – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "321",
                    Description = "Total Securities Sold – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "324",
                    Description = "Total Securities Matured – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "325",
                    Description = "Total Securities Matured – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "326",
                    Description = "Total Securities Interest"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "327",
                    Description = "Total Securities Matured"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "328",
                    Description = "Total Securities Interest – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "329",
                    Description = "Total Securities Interest – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "330",
                    Description = "Total Escrow Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "331",
                    Description = "Individual Escrow Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "332",
                    Description = "Total Miscellaneous Securities Credits – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "336",
                    Description = "Total Miscellaneous Securities Credits – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "338",
                    Description = "Total Securities Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "340",
                    Description = "Total Broker Deposits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "341",
                    Description = "Total Broker Deposits – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "342",
                    Description = "Broker Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "343",
                    Description = "Total Broker Deposits – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "344",
                    Description = "Individual Back Value Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "345",
                    Description = "Item in Brokers Deposit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "346",
                    Description = "Sweep Interest Income"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "347",
                    Description = "Sweep Principal Sell"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "348",
                    Description = "Futures Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "349",
                    Description = "Principal Payments Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "350",
                    Description = "Investment Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "351",
                    Description = "Individual Investment Sold"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "352",
                    Description = "Total Cash Center Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "353",
                    Description = "Cash Center Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "354",
                    Description = "Interest Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "355",
                    Description = "Investment Interest"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "356",
                    Description = "Total Credit Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "357",
                    Description = "Credit Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "358",
                    Description = "YTD Adjustment Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "359",
                    Description = "Interest Adjustment Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "360",
                    Description = "Total Credits Less Wire Transfer and Returned Checks"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "361",
                    Description = "Grand Total Credits Less Grand Total Debits"
                },

                #endregion
                #region CorrespondentBankFederalReserve
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "362",
                    Description = "Correspondent Collection"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "363",
                    Description = "Correspondent Collection Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "364",
                    Description = "Loan Participation"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "366",
                    Description = "Currency and Coin Deposited"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "367",
                    Description = "Food Stamp Letter"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "368",
                    Description = "Food Stamp Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "369",
                    Description = "Clearing Settlement Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "370",
                    Description = "Total Back Value Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "372",
                    Description = "Back Value Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "373",
                    Description = "Customer Payroll"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "374",
                    Description = "FRB Statement Recap"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "376",
                    Description = "Savings Bond Letter or Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "377",
                    Description = "Treasury Tax and Loan Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "378",
                    Description = "Transfer of Treasury Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "379",
                    Description = "FRB Government Checks Cash Letter Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "381",
                    Description = "FRB Government Check Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "382",
                    Description = "FRB Postal Money Order Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "383",
                    Description = "FRB Postal Money Order Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "384",
                    Description = "FRB Cash Letter Auto Charge Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "385",
                    Description = "Total Universal Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "386",
                    Description = "FRB Cash Letter Auto Charge Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "387",
                    Description = "FRB Fine-Sort Cash Letter Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "388",
                    Description = "FRB Fine-Sort Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "389",
                    Description = "Total Freight Payment Credits"
                },

                #endregion
                #region Miscellaneous
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "390",
                    Description = "Total Miscellaneous Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "391",
                    Description = "Universal Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "392",
                    Description = "Freight Payment Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "393",
                    Description = "Itemized Credit Over $10,000"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "394",
                    Description = "Cumulative Credits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "395",
                    Description = "Check Reversal"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "397",
                    Description = "Float Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "398",
                    Description = "Miscellaneous Fee Refund"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Miscellaneous,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "399",
                    Description = "Miscellaneous Credit"
                },

                #endregion
                #region SummaryAndDetailDebits
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "400",
                    Description = "Total Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "401",
                    Description = "Total Debit Amount MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "403",
                    Description = "Today’s Total Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "405",
                    Description = "Total Debit Less Wire Transfers and Charge-Backs"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "406",
                    Description = "Debits not Detailed"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "408",
                    Description = "Float Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "409",
                    Description = "Debit (Any Type)"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "410",
                    Description = "Total YTD Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.SummaryAndDetailDebits,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "412",
                    Description = "Total Debits (Excluding Returned Items)"
                },

                #endregion
                #region Lockbox
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "415",
                    Description = "Lockbox Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "416",
                    Description = "Total Lockbox Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "420",
                    Description = "EDI Transaction Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "421",
                    Description = "EDI Transaction Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "422",
                    Description = "EDIBANX Settlement Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Lockbox,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "423",
                    Description = "EDIBANX Return Item Debit"
                },

                #endregion
                #region PayableThroughDraft
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PayableThroughDraft,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "430",
                    Description = "Total Payable–Through Drafts"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.PayableThroughDraft,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "435",
                    Description = "Payable–Through Draft"
                },

                #endregion
                #region AutomatedClearingHouse
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "445",
                    Description = "ACH Concentration Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "446",
                    Description = "Total ACH Disbursement Funding Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "447",
                    Description = "ACH Disbursement Funding Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "450",
                    Description = "Total ACH Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "451",
                    Description = "ACH Debit Received"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "452",
                    Description = "Item in ACH Disbursement or Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "455",
                    Description = "Preauthorized ACH Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "462",
                    Description = "Account Holder Initiated ACH Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "463",
                    Description = "Corporate Trade Payment Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "464",
                    Description = "Corporate Trade Payment Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "465",
                    Description = "Corporate Trade Payment Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "466",
                    Description = "ACH Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "467",
                    Description = "ACH Settlement Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "468",
                    Description = "ACH Return Item or Adjustment Settlement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.AutomatedClearingHouse,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "469",
                    Description = "Miscellaneous ACH Debit"
                },

                #endregion
                #region ChecksPaid
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "470",
                    Description = "Total Check Paid"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "471",
                    Description = "Total Check Paid – Cumulative MTD"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "472",
                    Description = "Cumulative Checks Paid"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "474",
                    Description = "Certified Check Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "475",
                    Description = "Check Paid"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "476",
                    Description = "Federal Reserve Bank Letter Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "477",
                    Description = "Bank Originated Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "478",
                    Description = "List Post Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "479",
                    Description = "List Post Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "480",
                    Description = "Total Loan Payments"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "481",
                    Description = "Individual Loan Payment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "482",
                    Description = "Total Bank-Originated Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "484",
                    Description = "Draft"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "485",
                    Description = "DTC Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "486",
                    Description = "Total Cash Letter Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "487",
                    Description = "Cash Letter Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ChecksPaid,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "489",
                    Description = "Cash Letter Adjustment"
                },

                #endregion
                #region MoneyTransfer
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "490",
                    Description = "Total Outgoing Money Transfers"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "491",
                    Description = "Individual Outgoing Internal Money Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "493",
                    Description = "Customer Terminal Initiated Money Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "495",
                    Description = "Outgoing Money Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "496",
                    Description = "Money Transfer Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "498",
                    Description = "Compensation"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "500",
                    Description = "Total Automatic Transfer Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "501",
                    Description = "Individual Automatic Transfer Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "502",
                    Description = "Bond Operations Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "505",
                    Description = "Total Book Transfer Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "506",
                    Description = "Book Transfer Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "507",
                    Description = "Total International Money Transfer Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "508",
                    Description = "Individual International Money Transfer Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "510",
                    Description = "Total International Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "512",
                    Description = "Letter of Credit Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "513",
                    Description = "Letter of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "514",
                    Description = "Foreign Exchange Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "515",
                    Description = "Total Letters of Credit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "516",
                    Description = "Foreign Remittance Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "518",
                    Description = "Foreign Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "522",
                    Description = "Foreign Checks Paid"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "524",
                    Description = "Commission"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "526",
                    Description = "International Money Market Trading"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "527",
                    Description = "Standing Order"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.MoneyTransfer,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "529",
                    Description = "Miscellaneous International Debit"
                },

                #endregion
                #region Security
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "530",
                    Description = "Total Security Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "531",
                    Description = "Securities Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "532",
                    Description = "Total Amount of Securities Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "533",
                    Description = "Security Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "534",
                    Description = "Total Miscellaneous Securities DB – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "535",
                    Description = "Purchase of Equity Securities"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "536",
                    Description = "Total Miscellaneous Securities Debit – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "537",
                    Description = "Total Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "538",
                    Description = "Matured Repurchase Order"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "539",
                    Description = "Total Bankers’ Acceptances Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "540",
                    Description = "Coupon Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "541",
                    Description = "Bankers’ Acceptances"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "542",
                    Description = "Purchase of Debt Securities"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "543",
                    Description = "Domestic Collection"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "544",
                    Description = "Interest/Matured Principal Payment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "546",
                    Description = "Commercial paper"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "547",
                    Description = "Capital Change"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "548",
                    Description = "Savings Bonds Sales Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Security,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "549",
                    Description = "Miscellaneous Security Debit"
                },

                #endregion
                #region DepositedItemsReturned
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "550",
                    Description = "Total Deposited Items Returned"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "551",
                    Description = "Total Credit Reversals"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "552",
                    Description = "Credit Reversal"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "554",
                    Description = "Posting Error Correction Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "555",
                    Description = "Deposited Item Returned"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "556",
                    Description = "Total ACH Return Items"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "557",
                    Description = "Individual ACH Return Item"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "558",
                    Description = "ACH Reversal Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "560",
                    Description = "Total Rejected Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "561",
                    Description = "Individual Rejected Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "563",
                    Description = "Overdraft"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "564",
                    Description = "Overdraft Fee"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "566",
                    Description = "Return Item"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "567",
                    Description = "Return Item Fee"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.DepositedItemsReturned,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "568",
                    Description = "Return Item Adjustment"
                },

                #endregion
                #region ZeroBalanceAccountDisbursing
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "570",
                    Description = "Total ZBA Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "574",
                    Description = "Cumulative ZBA Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "575",
                    Description = "ZBA Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "577",
                    Description = "ZBA Debit Transfer"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "578",
                    Description = "ZBA Debit Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "580",
                    Description = "Total Controlled Disbursing Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "581",
                    Description = "Individual Controlled Disbursing Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "583",
                    Description = "Total Disbursing Checks Paid – Early Amount"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "584",
                    Description = "Total Disbursing Checks Paid – Later Amount"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "585",
                    Description = "Disbursing Funding Requirement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "586",
                    Description = "FRB Presentment Estimate (Fed Estimate)"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "587",
                    Description = "Late Debits (After Notification)"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.ZeroBalanceAccountDisbursing,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "588",
                    Description = "Total Disbursing Checks Paid-Last Amount"
                },

                #endregion
                #region Other
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "590",
                    Description = "Total DTC Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "594",
                    Description = "Total ATM Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "595",
                    Description = "ATM Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "596",
                    Description = "Total APR Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "597",
                    Description = "ARP Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "601",
                    Description = "Estimated Total Disbursement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "602",
                    Description = "Adjusted Total Disbursement"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "610",
                    Description = "Total Funds Required"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "611",
                    Description = "Total Wire Transfers Out- CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "612",
                    Description = "Total Wire Transfers Out – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "613",
                    Description = "Total International Debit – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "614",
                    Description = "Total International Debit – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "615",
                    Description = "Total Federal Reserve Bank – Commercial Bank Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "616",
                    Description = "Federal Reserve Bank – Commercial Bank Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "617",
                    Description = "Total Securities Purchased – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "618",
                    Description = "Total Securities Purchased – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "621",
                    Description = "Total Broker Debits – CHF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "622",
                    Description = "Broker Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "623",
                    Description = "Total Broker Debits – FF"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "625",
                    Description = "Total Broker Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "626",
                    Description = "Total Fed Funds Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "627",
                    Description = "Fed Funds Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "628",
                    Description = "Total Cash Center Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "629",
                    Description = "Cash Center Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "630",
                    Description = "Total Debit Adjustments"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "631",
                    Description = "Debit Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "632",
                    Description = "Total Trust Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "633",
                    Description = "Trust Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "634",
                    Description = "YTD Adjustment Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "640",
                    Description = "Total Escrow Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "641",
                    Description = "Individual Escrow Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "644",
                    Description = "Individual Back Value Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "646",
                    Description = "Transfer Calculation Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "650",
                    Description = "Investments Purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "651",
                    Description = "Individual Investment purchased"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "654",
                    Description = "Interest Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "655",
                    Description = "Total Investment Interest Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "656",
                    Description = "Sweep Principal Buy"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "657",
                    Description = "Futures Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "658",
                    Description = "Principal Payments Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.Other,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "659",
                    Description = "Interest Adjustment Debit"
                },

                #endregion
                #region CorrespondentBankFederalReserve
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "661",
                    Description = "Account Analysis Fee"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "662",
                    Description = "Correspondent Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "663",
                    Description = "Correspondent Collection Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "664",
                    Description = "Loan Participation"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "665",
                    Description = "Intercept Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "666",
                    Description = "Currency and Coin Shipped"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "667",
                    Description = "Food Stamp Letter"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "668",
                    Description = "Food Stamp Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "669",
                    Description = "Clearing Settlement Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "670",
                    Description = "Total Back Value Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "672",
                    Description = "Back Value Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "673",
                    Description = "Customer Payroll"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "674",
                    Description = "FRB Statement Recap"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "676",
                    Description = "Savings Bond Letter or Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "677",
                    Description = "Treasury Tax and Loan Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "678",
                    Description = "Transfer of Treasury Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "679",
                    Description = "FRB Government Checks Cash Letter Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "681",
                    Description = "FRB Government Check Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "682",
                    Description = "FRB Postal Money Order Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "683",
                    Description = "FRB Postal Money Order Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "684",
                    Description = "FRB Cash Letter Auto Charge Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "685",
                    Description = "Total Universal Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "686",
                    Description = "FRB Cash Letter Auto Charge Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "687",
                    Description = "FRB Fine-Sort Cash Letter Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "688",
                    Description = "FRB Fine-Sort Adjustment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "689",
                    Description = "FRB Freight Payment Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "690",
                    Description = "Total Miscellaneous Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "691",
                    Description = "Universal Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "692",
                    Description = "Freight Payment Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "693",
                    Description = "Itemized Debit Over $10,000"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "694",
                    Description = "Deposit Reversal"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "695",
                    Description = "Deposit Correction Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "696",
                    Description = "Regular Collection Debit"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "697",
                    Description = "Cumulative Debits"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "698",
                    Description = "Miscellaneous Fees"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.CorrespondentBankFederalReserve,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Detail,
                    TypeCode = "699",
                    Description = "Miscellaneous Debit"
                },

                #endregion
                #region LoanTransactions
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "701",
                    Description = "Principal Loan Balance"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "703",
                    Description = "Available Commitment Amount"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "705",
                    Description = "Payment Amount Due"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "707",
                    Description = "Principal Amount Past Due"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.NotApplicable,
                    Level = LevelType.Status,
                    TypeCode = "709",
                    Description = "Interest Amount Past Due"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Summary,
                    TypeCode = "720",
                    Description = "Total Loan Payment"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "721",
                    Description = "Amount Applied to Interest"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "722",
                    Description = "Amount Applied to Principal"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "723",
                    Description = "Amount Applied to Escrow"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "724",
                    Description = "Amount Applied to Late Charges"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "725",
                    Description = "Amount Applied to Buydown"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "726",
                    Description = "Amount Applied to Misc. Fees"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "727",
                    Description = "Amount Applied to Deferred Interest Detail"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Credit,
                    Level = LevelType.Detail,
                    TypeCode = "728",
                    Description = "Amount Applied to Service Charge"
                },
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.LoanTransactions,
                    Transaction = TransactionType.Debit,
                    Level = LevelType.Summary,
                    TypeCode = "760",
                    Description = "Loan Disbursement"
                },

                #endregion
                #region NonMonetaryInformation
                new TransactionDetail()
                {
                    CategoryType = CategoryTypeCodes.NonMonetaryInformation,
                    Transaction = TransactionType.Reference,
                    Level = LevelType.Detail,
                    TypeCode = "890",
                    Description = "Contains Non-monetary Information"
                }

                #endregion
            };
            return list;
        }
    }
}

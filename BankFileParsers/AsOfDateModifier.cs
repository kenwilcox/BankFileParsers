namespace BankFileParsers
{
    /// <summary>
    /// Distinguishes same-day data from previous-day data and interim data from final data. As-of-Date Modifier is for identification only and does not affect processing.
    /// Final: Status and Summary data at the close of business on the As-of-Date.
    /// Interim: Status and Summary data may not reflect all activity on the As-of-Date.
    /// Previous-day: As-of-Date is the previous business day.
    /// Same-day: As-of-Date is the current business day. For intraday reporting.
    /// </summary>
    public enum AsOfDateModifier
    {
        InterimPreviousDay = 1,
        FinalPreviousDay = 2,
        InterimSameDay = 3,
        FinalSameDay = 4,
        Missing
    }
}
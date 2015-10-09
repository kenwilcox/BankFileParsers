namespace BankFileParsers
{
    public class TransactionDetail
    {
        public CategoryTypeCodes CategoryType { get; set; }
        public string TypeCode { get; set; }
        public TransactionType Transaction { get; set; }
        public LevelType Level { get; set; }
        public string Description { get; set; }
    }
}
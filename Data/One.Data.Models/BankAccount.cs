namespace One.Data.Models
{
    using One.Data.Common.Models;

    public class BankAccount : BaseModel<int>
    {
        public int Number { get; set; }
    }
}

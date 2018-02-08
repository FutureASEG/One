namespace One.Data.Models
{
    using System.Collections.Generic;

    using One.Data.Common.Models;

    public class Bank : BaseModel<int>
    {
        public string Name { get; set; }
    }
}

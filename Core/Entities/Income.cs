using System;

namespace Core.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public IncomeType IncomeType {get;set;}
        public int IncomeTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
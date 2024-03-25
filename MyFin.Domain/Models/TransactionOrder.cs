namespace MyFin.Domain.Models
{
    public class TransactionOrder : Base
    {
        public string Title { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime? DateOrder { get; set; } 
    }
}

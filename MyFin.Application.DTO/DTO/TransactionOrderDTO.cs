namespace MyFin.Application.DTO.DTO
{
    public class TransactionOrderDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime? DateOrder { get; set; }
    }
}

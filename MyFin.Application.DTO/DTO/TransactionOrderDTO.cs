namespace MyFin.Application.DTO.DTO
{
    public record struct TransactionOrderDTO(
        int? Id,
        string Title, 
        decimal Value, 
        DateTime? DateOrder
    );
}

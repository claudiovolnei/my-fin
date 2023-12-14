using MyFin.Application.DTO.DTO;

namespace MyFin.Application.Interfaces
{
    public interface IApplicationServiceTransactionOrder
    {
        void Add(TransactionOrderDTO transactionOrderDTO);

        TransactionOrderDTO GetById(int id);

        IEnumerable<TransactionOrderDTO> GetAll();

        void Update(TransactionOrderDTO transactionOrderDTO);

        void Remove(TransactionOrderDTO transactionOrderDTO);

        void Dispose();
    }
}

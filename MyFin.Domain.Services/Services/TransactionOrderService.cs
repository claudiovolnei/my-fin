using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Core.Interfaces.Services;
using MyFin.Domain.Models;

namespace MyFin.Domain.Services.Services
{
    public class TransactionOrderService : BaseService<TransactionOrder>, ITransactionOrderService
    {
        public readonly ITransactionOrderRepository _repositoryTransactionOrder;
        public TransactionOrderService(ITransactionOrderRepository repositoryTransactionOrder) : base(repositoryTransactionOrder) 
        {
            _repositoryTransactionOrder = repositoryTransactionOrder;
        }
    }
}

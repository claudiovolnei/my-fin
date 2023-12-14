using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Core.Interfaces.Services;
using MyFin.Domain.Models;

namespace MyFin.Domain.Services.Services
{
    public class ServiceTransactionOrder : ServiceBase<TransactionOrder>, IServiceTransactionOrder
    {
        public readonly IRepositoryTransactionOrder _repositoryTransactionOrder;
        public ServiceTransactionOrder(IRepositoryTransactionOrder repositoryTransactionOrder) : base(repositoryTransactionOrder) 
        {
            _repositoryTransactionOrder = repositoryTransactionOrder;
        }
    }
}

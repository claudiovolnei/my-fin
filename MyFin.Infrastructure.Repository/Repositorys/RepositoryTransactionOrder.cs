using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Models;
using MyFin.Infrastructure.Data;

namespace MyFin.Infrastructure.Repository.Repositorys
{
    public class RepositoryTransactionOrder : RepositoryBase<TransactionOrder>, IRepositoryTransactionOrder
    {
        private readonly MyFinDbContext _myFinDbContext;
        public RepositoryTransactionOrder(MyFinDbContext myFinDbContext) : base(myFinDbContext) 
        {
            _myFinDbContext = myFinDbContext;
        }
    }
}

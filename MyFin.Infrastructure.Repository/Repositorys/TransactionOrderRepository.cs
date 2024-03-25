using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Models;
using MyFin.Infrastructure.Data;

namespace MyFin.Infrastructure.Repository.Repositorys
{
    public class TransactionOrderRepository : BaseRepository<TransactionOrder>, ITransactionOrderRepository
    {
        private readonly MyFinDbContext _myFinDbContext;
        public TransactionOrderRepository(MyFinDbContext myFinDbContext) : base(myFinDbContext) 
        {
            _myFinDbContext = myFinDbContext;
        }
    }
}

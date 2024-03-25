using AutoMapper;
using MyFin.Application.DTO.DTO;
using MyFin.Application.Interfaces;
using MyFin.Domain.Core.Interfaces.Services;
using MyFin.Domain.Models;

namespace MyFin.Application.Service
{
    public class TransactionOrderApplicationService : ITransactionOrderApplicationService
    {
        private readonly ITransactionOrderService _serviceTransactionOrder;
        private readonly IMapper _mapper;
        public TransactionOrderApplicationService(ITransactionOrderService serviceTransactionOrder, IMapper mapper)
        {
            _serviceTransactionOrder = serviceTransactionOrder;
            _mapper = mapper; 
        }
        public void Add(TransactionOrderDTO transactionOrderDTO)
        {
            var transactionOrder = _mapper.Map<TransactionOrder>(transactionOrderDTO);
            _serviceTransactionOrder.Add(transactionOrder);
        }

        public void Dispose()
        {
            _serviceTransactionOrder?.Dispose();
        }

        public IEnumerable<TransactionOrderDTO> GetAll()
        {
            var transactionsOrders = _serviceTransactionOrder.GetAll();
            return _mapper.Map<IEnumerable<TransactionOrderDTO>>(transactionsOrders);
        }

        public TransactionOrderDTO GetById(int id)
        {
            var transactionOrder = _serviceTransactionOrder.GetById(id);
            return _mapper.Map<TransactionOrderDTO>(transactionOrder);
        }

        public void Remove(TransactionOrderDTO transactionOrderDTO)
        {
            var transactionOrder = _mapper.Map<TransactionOrder>(transactionOrderDTO);
             _serviceTransactionOrder.Remove(transactionOrder);
        }

        public void Update(TransactionOrderDTO transactionOrderDTO)
        {
            var transactionOrder = _mapper.Map<TransactionOrder>(transactionOrderDTO);
            _serviceTransactionOrder.Update(transactionOrder);
        }
    }
}

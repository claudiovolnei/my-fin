using Microsoft.Extensions.DependencyInjection;
using MyFin.Application.Interfaces;
using MyFin.Application.Service;
using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Core.Interfaces.Services;
using MyFin.Domain.Services.Services;
using MyFin.Infrastructure.Repository.Repositorys;

namespace MyFin.Infrastructure.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static void Load(IServiceCollection services)
        {
            #region Registra IOC

            #region IOC Application
            services.AddTransient<ITransactionOrderApplicationService, TransactionOrderApplicationService>();
            #endregion

            #region IOC Services
            services.AddTransient<ITransactionOrderService, TransactionOrderService>();
            #endregion

            #region IOC Repositorys SQL
            services.AddTransient<ITransactionOrderRepository, TransactionOrderRepository>();
            #endregion           

            #endregion
        }
    }
}

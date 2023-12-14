using Microsoft.Extensions.DependencyInjection;
using MyFin.Application.Interfaces;
using MyFin.Application.Service;
using MyFin.Domain.Core.Interfaces.Repositorys;
using MyFin.Domain.Core.Interfaces.Services;
using MyFin.Domain.Services.Services;

namespace MyFin.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(IServiceCollection services)
        {
            #region Registra IOC

            #region IOC Application
            services.AddTransient<IApplicationServiceTransactionOrder, ApplicationServiceTransactionOrder>();
            #endregion

            #region IOC Services
            services.AddTransient<IServiceTransactionOrder, ServiceTransactionOrder>();
            #endregion

            #region IOC Repositorys SQL
            services.AddTransient<IRepositoryTransactionOrder, IRepositoryTransactionOrder>();
            #endregion           

            #endregion
        }
    }
}

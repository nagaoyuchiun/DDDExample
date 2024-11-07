using Contracts.Interface;
using Contracts.Interface.IRepository;
using Infrastructure.DataAccesses.DbContexts;
using Infrastructure.Repositories;
using Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ServiceFactory
{
    public static class RepositoryFactory
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<ISiteRepository, SiteRepository>();
            return services;
        }
    }
}

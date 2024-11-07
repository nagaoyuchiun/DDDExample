using Infrastructure.Interfaces.IRepository;
using Infrastructure.Repositories;
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

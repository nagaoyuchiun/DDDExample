using Application.Service;
using Contracts.Interface;
using Contracts.Interface.IProvider;
using Contracts.Interface.IService;
using Infrastructure.DataAccesses.DbContexts;
using Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ServiceFactory
{
    public static class ApplicationFactory
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUnitOfWork<ExampleDbContext>, UnitOfWork<ExampleDbContext>>();
            services.AddScoped<IUserContext, UserContext>();
            services.AddScoped<ITimeProvider, Infrastructure.Provider.TimeProvide>();
            return services;
        }
    }
}

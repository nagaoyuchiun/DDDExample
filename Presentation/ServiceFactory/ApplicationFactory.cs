using Application.Service;
using Infrastructure.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ServiceFactory
{
    public static class ApplicationFactory
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}

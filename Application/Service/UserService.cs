using Contracts.DTO;
using Contracts.Interface;
using Contracts.Interface.IRepository;
using Contracts.Interface.IService;
using Domains.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class UserService : IUserService
    {
        private readonly ISiteRepository _siteRepository;
        public UserService(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }        

        public LoginInfoDTO Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

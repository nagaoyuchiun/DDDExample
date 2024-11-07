using Contracts.DTO;
using Contracts.Interface.IService;
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
        public LoginInfoDTO Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

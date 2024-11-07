using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.IService
{
    public interface IUserService
    {
        public LoginInfoDTO Login(string username, string password);
    }
}

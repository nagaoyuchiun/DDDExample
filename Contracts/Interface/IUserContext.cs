using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
     public interface IUserContext
    {
        public int UserNo { get; }

        public string EmplId { get; }

        public string DeptId { get; }
    }
}

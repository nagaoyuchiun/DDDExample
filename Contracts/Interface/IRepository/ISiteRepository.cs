using Contracts.Interface.IBaseHandleCollection;
using Domains;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.IRepository
{
    public interface ISiteRepository : ICreate<Site>, IRead<Site>, IUpdate<Site>
    {

    }
}

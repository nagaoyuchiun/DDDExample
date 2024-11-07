using Domains;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.IRepository
{
    public interface ISiteRepository
    {
        public Task<Site?> Get(int id);
        public Task<IIdentifiable> Create(Site site);
        public Task Update(Site site);
        public Task Delete(Site site);
        public Task<IEnumerable<Site>> Query(IQueryParameter<Site> queryParameter);

    }
}

using Domains;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IQueryParameter<T> where T : IIdentifiable
    {
        public IQueryable<T> ApplyFilters(IQueryable<T> query);
    }
}

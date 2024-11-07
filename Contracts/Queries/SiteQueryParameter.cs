using Contracts.Interface;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Queries
{
    public class SiteQueryParameter : IQueryParameter<Site>
    {
        public Guid? Id { get; set; } = Guid.Empty;
        public int? CreateAtNo { get; set; }
        public DateTime? BeginCreateDateTime { get; set; }
        public DateTime? EndCreateDateTime { get; set; }

        public IQueryable<Site> ApplyFilters(IQueryable<Site> query)
        {
            if (Id.HasValue)
            {
                query = query.Where(site => site.Id == Id.Value);
            }

            if (CreateAtNo.HasValue)
            {
                query = query.Where(site => site.CreateAtNo == CreateAtNo.Value);
            }

            if (BeginCreateDateTime.HasValue)
            {
                query = query.Where(site => site.CreateDateTime > BeginCreateDateTime.Value);
            }

            if (EndCreateDateTime.HasValue)
            {
                query = query.Where(site => site.CreateDateTime <= EndCreateDateTime.Value);
            }

            return query;
        }
    }
}

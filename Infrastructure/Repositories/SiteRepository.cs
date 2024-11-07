using Domains;
using Domains.Entities;
using Infrastructure.DataAccesses.DbContexts;
using Infrastructure.Interfaces;
using Infrastructure.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private readonly ExampleDbContext _context;
        public SiteRepository(ExampleDbContext context)
        {
            _context = context;
        }

        public async Task<IIdentifiable> Create(Site site)
        {
            _context.Sites.Add(site);
            await _context.SaveChangesAsync();
            return site;
        }

        public async Task Delete(Site site)
        {
            site.GenerateDeleteKey();
            _context.Sites.Update(site);
            await _context.SaveChangesAsync();
        }

        public async Task<Site?> Get(int id)
        {
            return await _context.Sites.FindAsync(id);
        }

        public async  Task<IEnumerable<Site>> Query(IQueryParameter<Site> queryParameter)
        {
            var query = _context.Sites.AsQueryable();
            return await queryParameter.ApplyFilters(query).ToListAsync();
        }

        public async Task Update(Site site)
        {
            _context.Sites.Update(site);
            await _context.SaveChangesAsync();
        }
    }
}

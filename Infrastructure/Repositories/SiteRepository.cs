using Contracts.Interface;
using Contracts.Interface.IProvider;
using Contracts.Interface.IRepository;
using Domains;
using Domains.Entities;
using Infrastructure.DataAccesses.DbContexts;
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
        private readonly IUserContext _userContext;
        private readonly ITimeProvider _timeProvider;
        private readonly IUnitOfWork<ExampleDbContext> _unitOfWork;
        public SiteRepository(IUserContext userContext, ITimeProvider timeProvider, IUnitOfWork<ExampleDbContext> unitOfWork)
        {
            _userContext = userContext;
            _timeProvider = timeProvider;
            _unitOfWork = unitOfWork;
        }

        public async Task<IIdentifiable> Create(Site site)
        {
            site.CreateAtNo = _userContext.UserNo;
            site.Id = Guid.NewGuid();
            site.CreateDateTime = _timeProvider.GetNow();
            _unitOfWork.GetContext().Sites.Add(site);
            await _unitOfWork.SaveChangesAsync();
            return site;
        }

        public async Task Delete(Site site)
        {
            site.GenerateDeleteKey();
            site.UpdateAtNo = _userContext.UserNo;
            site.UpdateDateTime = _timeProvider.GetNow();
            _unitOfWork.GetContext().Sites.Update(site);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Site?> Get(int id)
        {
            return await _unitOfWork.GetContext().Sites.FindAsync(id);
        }

        public async Task<IEnumerable<Site>> Query(IQueryParameter<Site> queryParameter)
        {
            var query = _unitOfWork.GetContext().Sites.AsQueryable();
            return await queryParameter.ApplyFilters(query).ToListAsync();
        }

        public async Task Update(Site site)
        {
            site.UpdateAtNo = _userContext.UserNo;
            site.UpdateDateTime = _timeProvider.GetNow();
            _unitOfWork.GetContext().Sites.Update(site);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}

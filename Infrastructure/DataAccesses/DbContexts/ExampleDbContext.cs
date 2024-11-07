using Domains.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccesses.DbContexts
{
    public class ExampleDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IUserContext _userContext;
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options, IConfiguration configuration, IUserContext userContext) : base(options)
        {
            _configuration = configuration;
            _userContext = userContext;
        }

        public DbSet<Site> Sites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleDbContext).Assembly);
        }
    }
}

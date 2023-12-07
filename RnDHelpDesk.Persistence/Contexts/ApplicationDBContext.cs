using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RnDHelpDesk.Domain.Entities;
using System.Reflection;

namespace RnDHelpDesk.Persistence.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}

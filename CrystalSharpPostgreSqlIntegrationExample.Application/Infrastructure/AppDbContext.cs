using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrystalSharp.PostgreSql.Database;
using CrystalSharpPostgreSqlIntegrationExample.Application.Domain.Aggregates.CurrencyAggregate;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.Infrastructure
{
    public class AppDbContext : DbContext
    {
        private readonly IPostgreSqlEntityFrameworkCoreContext _postgreSqlEfContext;
        public DbSet<Currency> Currency { get; set; }

        public AppDbContext()
        {
            //
        }

        public AppDbContext(DbContextOptions<AppDbContext> options, IPostgreSqlEntityFrameworkCoreContext postgreSqlEfContext)
            : base(options)
        {
            _postgreSqlEfContext = postgreSqlEfContext;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _postgreSqlEfContext.SaveChanges(this, cancellationToken).ConfigureAwait(false);
        }
    }
}

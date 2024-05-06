using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpPostgreSqlIntegrationExample.Application.Domain.Aggregates.CurrencyAggregate.Events;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.EventHandlers
{
    public class CurrencyDeletedDomainEventHandler : ISynchronousDomainEventHandler<CurrencyDeletedDomainEvent>
    {
        public async Task Handle(CurrencyDeletedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpPostgreSqlIntegrationExample.Application.Domain.Aggregates.CurrencyAggregate.Events;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.EventHandlers
{
    public class CurrencyCreatedDomainEventHandler : ISynchronousDomainEventHandler<CurrencyCreatedDomainEvent>
    {
        public async Task Handle(CurrencyCreatedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}

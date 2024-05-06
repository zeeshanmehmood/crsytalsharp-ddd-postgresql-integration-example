using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpPostgreSqlIntegrationExample.Application.Domain.Aggregates.CurrencyAggregate.Events;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.EventHandlers
{
    public class CurrencyNameChangedDomainEventHandler : ISynchronousDomainEventHandler<CurrencyNameChangedDomainEvent>
    {
        public async Task Handle(CurrencyNameChangedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Application;
using CrystalSharp.Application.Handlers;
using CrystalSharpPostgreSqlIntegrationExample.Application.Commands;
using CrystalSharpPostgreSqlIntegrationExample.Application.Domain.Aggregates.CurrencyAggregate;
using CrystalSharpPostgreSqlIntegrationExample.Application.Infrastructure;
using CrystalSharpPostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.CommandHandlers
{
    public class CreateCurrencyCommandHandler : CommandHandler<CreateCurrencyCommand, CurrencyResponse>
    {
        private readonly AppDbContext _dbContext;

        public CreateCurrencyCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<CommandExecutionResult<CurrencyResponse>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken = default)
        {
            if (request == null) return await Fail("Invalid command.");

            Currency currency = Currency.Create(request.Name);

            await _dbContext.Currency.AddAsync(currency, cancellationToken).ConfigureAwait(false);
            await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            CurrencyResponse response = new() { GlobalUId = currency.GlobalUId, Name = currency.Name };

            return await Ok(response);
        }
    }
}

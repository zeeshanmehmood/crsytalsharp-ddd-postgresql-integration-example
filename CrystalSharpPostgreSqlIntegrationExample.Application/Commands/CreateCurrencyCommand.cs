using CrystalSharp.Application;
using CrystalSharpPostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.Commands
{
    public class CreateCurrencyCommand : ICommand<CommandExecutionResult<CurrencyResponse>>
    {
        public string Name { get; set; }
    }
}

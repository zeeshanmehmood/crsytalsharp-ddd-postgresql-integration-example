using System;
using CrystalSharp.Application;
using CrystalSharpPostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.Commands
{
    public class ChangeCurrencyCommand : ICommand<CommandExecutionResult<CurrencyResponse>>
    {
        public Guid GlobalUId { get; set; }
        public string Name { get; set; }
    }
}

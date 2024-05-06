using System;
using CrystalSharp.Application;
using CrystalSharpPostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.Commands
{
    public class DeleteCurrencyCommand : ICommand<CommandExecutionResult<DeleteCurrencyResponse>>
    {
        public Guid GlobalUId { get; set; }
    }
}

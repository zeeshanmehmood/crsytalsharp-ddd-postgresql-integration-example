using System;
using CrystalSharp.Application;
using CrystalSharpPostgreSqlIntegrationExample.Application.ReadModels;

namespace CrystalSharpPostgreSqlIntegrationExample.Application.Queries
{
    public class CurrencyDetailQuery : IQuery<QueryExecutionResult<CurrencyReadModel>>
    {
        public Guid GlobalUId { get; set; }
    }
}

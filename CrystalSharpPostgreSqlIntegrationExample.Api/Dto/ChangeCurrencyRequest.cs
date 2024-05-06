using System;

namespace CrystalSharpPostgreSqlIntegrationExample.Api.Dto
{
    public class ChangeCurrencyRequest
    {
        public Guid GlobalUId { get; set; }
        public string Name { get; set; }
    }
}

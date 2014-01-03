using DddOrdersSample.Core.Infrastructure;

namespace DddOrdersSample.Core.Shared
{
    public class Currency
    {
        public CurrencyId Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }

    public class CurrencyId : BaseStringId
    {
        public CurrencyId(string id) : base(id)
        {
        }
    }
}
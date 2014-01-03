using DddOrdersSample.Core.Shared;

namespace DddOrdersSample.Core.Accounting
{
    public class Account
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public CurrencyId CurrencyId { get; set; }
    }
}
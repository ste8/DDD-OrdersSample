namespace DddOrdersSample.Core.Shared
{
    public class Price
    {
        public Price(decimal unitPrice, CurrencyId currencyId, decimal discount)
        {
            UnitPrice = unitPrice;
            Discount = discount;
            CurrencyId = currencyId;
        }

        public decimal UnitPrice { get; private set; }

        public decimal Discount { get; private set; }

        public CurrencyId CurrencyId { get; private set; }

        public Price ChangeUnitPrice(decimal unitPrice)
        {
            return new Price(unitPrice, CurrencyId, Discount);
        }

        public Price ChangeDiscount(decimal discount)
        {
            return new Price(UnitPrice, CurrencyId, discount);
        }
    }
}
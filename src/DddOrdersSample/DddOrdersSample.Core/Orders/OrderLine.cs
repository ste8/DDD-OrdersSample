using DddOrdersSample.Core.Catalog;
using DddOrdersSample.Core.Shared;

namespace DddOrdersSample.Core.Orders
{
    public class OrderLine
    {
        public OrderLine(Product product, Quantity quantity, Price price)
        {
            Id = new OrderLineId();
            Product = new OrderProduct(product);
            Quantity = quantity;
            Price = price;
        }

        public OrderLineId Id { get; private set; }

        public OrderProduct Product { get; private set; }

        public Quantity Quantity { get; private set; }

        public Price Price { get; private set; }

        public void ChangeQuantity(Quantity quantity)
        {
            Quantity = quantity;
        }

        public void ChangeUnitPrice(decimal unitPrice)
        {
            Price = Price.ChangeUnitPrice(unitPrice);
        }

        public void ChangeDiscount(decimal discount)
        {
            Price = Price.ChangeDiscount(discount);
        }
    }
}
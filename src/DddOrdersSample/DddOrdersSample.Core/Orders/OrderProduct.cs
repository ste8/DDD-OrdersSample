using DddOrdersSample.Core.Catalog;

namespace DddOrdersSample.Core.Orders
{
    public class OrderProduct
    {
        public string Id { get; private set; }

        public string Description { get; private set; }

        public OrderProduct(Product product)
        {
            Id = product.Id;
            Description = product.Description;
        }
    }
}
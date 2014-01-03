using DddOrdersSample.Core.Accounting;

namespace DddOrdersSample.Core.Orders
{
    public class OrderFactory
    {
        public Order CreateOrder(Account account)
        {
            var order = new Order();
            order.InitAccount(account);
            return order;
        }
    }
}

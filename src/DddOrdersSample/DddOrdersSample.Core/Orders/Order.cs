using System;
using System.Collections.Generic;
using System.Linq;
using DddOrdersSample.Core.Accounting;
using DddOrdersSample.Core.Catalog;
using DddOrdersSample.Core.Shared;

namespace DddOrdersSample.Core.Orders
{
    public class Order
    {
        public CurrencyId CurrencyId { get; private set; }

        public void InitAccount(Account account)
        {
            CurrencyId = account.CurrencyId;
        }

        private readonly List<OrderLine> _orderLines = new List<OrderLine>();

        public OrderLine AddOrderLine(Product product, Quantity quantity, Price price)
        {
            if (price == null) throw new NullReferenceException("Price");
            if (price.CurrencyId != CurrencyId)
                throw new Exception(string.Format("Currency '{0}' is not the same of the document ('{1}')!", 
                    price.CurrencyId, CurrencyId));

            var orderLine = new OrderLine(product, quantity, price);
            _orderLines.Add(orderLine);
            return orderLine;
        }

        private OrderLine GetOrderLine(OrderLineId orderLineId)
        {
            var line = _orderLines.FirstOrDefault(ol => Equals(ol.Id, orderLineId));
            if (line == null) throw new Exception("Order line not found");
            return line;
        }

        public void ChangeLineQuantity(OrderLineId lineId, Quantity quantity)
        {
            var line = GetOrderLine(lineId);
            line.ChangeQuantity(quantity);
        }

        public void RemoveLine(OrderLineId orderLineId)
        {
            _orderLines.RemoveAll(ol => Equals(ol.Id, orderLineId));
        }
    }
}

using System;
using DddOrdersSample.Core.Infrastructure;

namespace DddOrdersSample.Core.Orders
{
    public class OrderLineId : BaseGuidId
    {
        public OrderLineId()
        {

        }

        public OrderLineId(Guid id)
            : base(id)
        {

        }
    }
}
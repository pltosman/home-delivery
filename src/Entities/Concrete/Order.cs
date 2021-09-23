using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public Order(string orderNumber, string sender)
        {
            this.OrderNumber = orderNumber;
            this.Sender = sender;
        }

        public string OrderNumber { get; set; }
        public string Sender { get; set; }
    }
}
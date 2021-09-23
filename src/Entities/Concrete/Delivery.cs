using System;
using Core.Entities;
using Entities.Dtos;

namespace Entities.Concrete
{
    public class Delivery :IEntity
    {
        public Guid Id { get; set; }

        public DeliveryState State { get; set; }

        public AccessWindow AccessWindow { get; set; }

        public Recipient Recipient { get; set; }

        public Order Order { get; set; }
    }
}

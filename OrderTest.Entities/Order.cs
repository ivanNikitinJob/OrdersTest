using OrderTest.Enums;
using System;
using System.Collections.Generic;

namespace OrderTest.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public OrderStatus Status { get; set; }
        public virtual IList<Product> ProductsList { get; set; }
    }
}

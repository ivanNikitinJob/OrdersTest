using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTest.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public virtual decimal TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}

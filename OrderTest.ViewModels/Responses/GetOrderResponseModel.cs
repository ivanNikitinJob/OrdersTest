using OrderTest.Enums;
using System;
using System.Collections.Generic;

namespace OrderTest.ViewModels
{
    public class GetOrderResponseModel
    {
        public Guid Id { get; set; }
        public string CreationDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public virtual List<GetOrderProductItem> ProductsList { get; set; }

        public GetOrderResponseModel()
        {
            ProductsList = new List<GetOrderProductItem>();
        }
    }

    public class GetOrderProductItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual decimal TotalPrice { get; set; }
    }
}

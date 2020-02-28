using OrderTest.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTest.ViewModels.Responses
{
    public class GetOrdersResponseModel
    {
        public List<GetOrdersResponseItem> Orders { get; set; }

        public GetOrdersResponseModel()
        {
            Orders = new List<GetOrdersResponseItem>();
        }
    }

    public class GetOrdersResponseItem
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public OrderStatus Status { get; set; }
    }
}

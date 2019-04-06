﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStore.Models
{
    public class Order
    {
        public Order()
        {
            ProductOrders = new List<ProductOrder>();
        }

        public int OrderId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TimeOfOrder { get; set; } = DateTime.Now;
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public virtual List<ProductOrder> ProductOrders { get; set; }
    }
}
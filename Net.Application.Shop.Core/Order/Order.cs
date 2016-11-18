﻿using Net.Framework.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop.Core
{
    [Table("Order")]
    public class Order : ModelBase
    {
        public Order()
        {
            this.Items = new List<OrderItem>();
        }

        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        public int TotalPrice { get; set; }

        public OrderStatus OrderStatus { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual List<OrderItem> Items { get; set; }
    }

    public enum OrderStatus
    {
        待支付 = 1,
        已支付 = 2,
        已发货 = 3,
        已完成 = 10
    }
}

﻿using System;

namespace ServeMe.Repository.Models
{
    public class CartDbModel
    {
        public int CartID { get; set; }

        public int OrderID { get; set; }

        public int StatusID { get; set; }

        public int ServiceID { get; set; }

        public double Rate { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        public OrderDbModel Order { get; set; }

        public StatusDbModel Status { get; set; }

        public ServiceDbModel Service { get; set; }
    }
}

﻿using System;

namespace ServeMe.Models
{
    public class ItemRequestModel
    {
        public ServiceCategoryDto ServiceCategory { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }
    }
}

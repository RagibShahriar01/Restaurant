﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Cart
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

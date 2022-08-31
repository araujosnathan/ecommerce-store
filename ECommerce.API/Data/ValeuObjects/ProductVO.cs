﻿using System;
namespace ECommerce.API.Data.ValeuObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageURL { get; set; }
    }
}


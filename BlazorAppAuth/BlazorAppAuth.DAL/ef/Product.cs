﻿using System;
using System.Collections.Generic;

namespace BlazorAppAuth.DAL
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }

        public virtual ProductCategory Category { get; set; } = null!;
    }
}

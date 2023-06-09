using System;
using System.Collections.Generic;

namespace BlazorAppAuth.DAL
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string IconCss { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}

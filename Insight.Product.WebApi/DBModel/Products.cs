using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Insight.Product.WebApi.DBModel
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public int ModelYear { get; set; }
        public decimal ProductPrice { get; set; }
        public string Currency { get; set; }
    }
}

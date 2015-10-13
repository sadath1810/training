using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string[] Tags { get; set; }
        public string ImageUrl { get; set; }
    }
}
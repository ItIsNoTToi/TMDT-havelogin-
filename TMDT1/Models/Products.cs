using System;
using System.Collections.Generic;

namespace TMDT1.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public int CategoryId { get; set; }
        public float Rate { get; set; }
        public List<ProductReviews>? ProductReviews { get; set; } // Thay đổi kiểu thành List<ProductReview>
    }

    public class ProductReviews
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public float Rate { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

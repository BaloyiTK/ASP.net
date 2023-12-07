using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

        // New property to store the user ID who created the product
        public int UserId { get; set; }

        // Navigation property to represent the user who created the product
        public User User { get; set; }
    }
}

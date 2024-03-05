using System.ComponentModel.DataAnnotations;

namespace HealthyFoods.Models.Order
{
    public class OrderCreateVM
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }
        [Display(Name ="Food Name")]
        public string ProductName { get; set; } = null!;
        public int QuantityInStock { get; set; }
        public string? Picture { get; set; }
        [Required]
        [Range(0, 50)]
        public int CountOfProducts { get; set; }

        public string AddressDelivery { get; set; } = null!;

        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

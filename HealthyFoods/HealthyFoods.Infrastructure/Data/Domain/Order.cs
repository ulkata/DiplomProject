using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyFoods.Infrastructure.Data.Domain
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
       
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; } = null!;
        
        [Required]
        public  DateTime DateOrder { get; set; }
     

        [Required]
        [Range(0, 50)]
        public int CountOfProducts{ get; set; }
       
        [Required]
        [MaxLength(50)]
        public string AddressDelivery { get; set; } = null!;
        
        [Required]
        [Range(0,100)]
        public decimal Price { get; set; }

        [Required]
        [Range(0,100)]
        public decimal Discount { get; set; }
        public decimal TotalPrice { get { return this.CountOfProducts * this.Price - this.CountOfProducts * this.Price * this.Discount / 100; } }



    }
}

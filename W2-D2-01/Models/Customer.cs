using System.ComponentModel.DataAnnotations;

namespace W2_D2_01.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public Pizza Order { get; set; }
    }
}

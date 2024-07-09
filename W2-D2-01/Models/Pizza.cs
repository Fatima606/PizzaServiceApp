using System.ComponentModel.DataAnnotations;

namespace W2_D2_01.Models
{
    public enum SizeEnum
    {
        Small,
        Medium,
        Large
    }
    public enum BaseEnum
    {
        Thick,
        Thin
    }
    public enum ToppingEnum
    {
        Pepperoni=1,
        Chicken=2,
        Extra_Cheese=3,
        Mushrooms=4,
        Spinach=5,
        Olives=6

    }

    public class Pizza
    {
        
        [Required]
        public SizeEnum Size { get; set; }
        [Required]
        public BaseEnum Base { get; set; }
        [Required]
        public List<ToppingEnum> Toppings { get; set; }
    } 
}

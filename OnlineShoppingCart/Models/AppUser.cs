using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingCart.Models
{
    public class AppUser : ShareModel
    {
        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The EncryptedPassword field is required.")]
        public string EncryptedPassword { get; set; }

        // Navigation property for roles
        public List<AppRole> Roles { get; set; }

        // Navigation property for shopping cart
        public ShoppingCart ShoppingCart { get; set; }

        // Additional identification details
    }
}

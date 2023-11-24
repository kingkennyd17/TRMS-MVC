using System.ComponentModel.DataAnnotations;

namespace Fintrak.TRMS.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
        public string grant_type { get; set; }
        public bool RememberMe { get; set; }
    }
}

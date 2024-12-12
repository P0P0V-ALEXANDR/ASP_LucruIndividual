using System.ComponentModel.DataAnnotations;

namespace Studiu_Individual.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; } = string.Empty;  // Initializare cu string gol

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;  // Initializare cu string gol
    }
}

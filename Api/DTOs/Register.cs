using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class Register
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
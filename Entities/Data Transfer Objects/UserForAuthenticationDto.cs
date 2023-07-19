using System.ComponentModel.DataAnnotations;

namespace Entities.Data_Transfer_Objects
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Username is required.")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; init; }
    }
}

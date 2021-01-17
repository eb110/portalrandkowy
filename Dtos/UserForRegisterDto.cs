using System.ComponentModel.DataAnnotations;

namespace PortalRandkowy.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Nazwa wymagana")]
        public string Username { get; set; }
        [Required(ErrorMessage="Has£o wymagane")]
        [StringLength(12, MinimumLength=8, ErrorMessage="Has£o musi miec od 8 do 12 znaków")]
        public string Password { get; set; }
    }
}
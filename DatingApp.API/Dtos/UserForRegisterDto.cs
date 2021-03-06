using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    
        
        [StringLength(8, MinimumLength = 4,ErrorMessage="You must specify a password between 4 to 8 Characters")]     
        public string Password { get; set; }
    }
}
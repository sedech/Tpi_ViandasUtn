using System.ComponentModel.DataAnnotations;

namespace ViandasUtn.Models
{
    public class CreateAndUpdateUserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName
        {
            get; set;
        }
    }
}

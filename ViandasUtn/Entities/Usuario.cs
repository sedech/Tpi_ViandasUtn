using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViandasUtn
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }

        public Usuario( int id, string name, string lastName, string password, string email, string userName)
        {
                Id = id;
                Name = name;
                LastName = lastName;
                Password   = password;
                Email = email;
                UserName = userName;
        }

        public Usuario()
        {
        }
    }

}

    

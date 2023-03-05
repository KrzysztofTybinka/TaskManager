using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MinLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        public string Login { get; set; }

        [Required, MaxLength(50), NotMapped, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public string Role { get;set; }
    }
}

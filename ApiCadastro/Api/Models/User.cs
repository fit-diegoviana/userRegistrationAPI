using System.ComponentModel.DataAnnotations;

namespace ApiCadastro.Api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

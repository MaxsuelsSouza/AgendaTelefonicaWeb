using System.ComponentModel.DataAnnotations;

namespace AgendaTelefonica.Api.Damain.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Telefone { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Senha { get; set; } = string.Empty;

    }
}
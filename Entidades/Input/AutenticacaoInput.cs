using System.ComponentModel.DataAnnotations;

namespace FitnessDiary.Entidades
{
    public class AutenticacaoInput
    {
        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Senha { get; set; }

    }
}

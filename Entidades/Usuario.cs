using System.ComponentModel.DataAnnotations;

namespace FitnessDiary.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; } 

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Senha { get; set; }

        [Required]
        public DateTime DtaNascimento { get; set; } = DateTime.Now;

        public double? Peso { get; set; }

        public double? Altura { get; set; }

    }
}

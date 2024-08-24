using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDiary.Entidades
{
    public class Treino
    {
        [Key]
        public int IdTreino { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        [Required]
        public int Duracao { get; set; }
        public ICollection<Exercicio> Exercicios { get; set; } = new List<Exercicio>();
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public CategoriaExercicio Categoria { get; set; }
    }


}

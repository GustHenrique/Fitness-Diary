using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDiary.Entidades
{
    public class Treino
    {
        [Key]
        public int IdTreino { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Duracao { get; set; }

        public double CaloriasQueimadas { get; set; }

        // Relação com a classe Exercicio
        public ICollection<Exercicio> Exercicios { get; set; }

        // Relação com a classe Categoria
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public CategoriaExercicio Categoria { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FitnessDiary.Entidades
{
    public class CategoriaExercicio
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        // Relação com a classe Treino
        public ICollection<Treino> Treinos { get; set; }
    }
}

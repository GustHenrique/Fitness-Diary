using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDiary.Entidades
{
    public class Exercicio
    {
        [Key]
        public int IdExercicio { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        public int Repeticoes { get; set; }
        public int Series { get; set; }
        public double Peso { get; set; }
        public double CaloriasQueimadasPorSeries { get; set; }
        public int IdTreino { get; set; }
        [ForeignKey("IdTreino")]
        public Treino Treino { get; set; }
        public int IdGrupoMuscular { get; set; }
        [ForeignKey("IdGrupoMuscular")]
        public GrupoMuscular GrupoMuscular { get; set; }
    }
}

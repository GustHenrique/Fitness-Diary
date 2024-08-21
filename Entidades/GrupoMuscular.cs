using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDiary.Entidades
{
    public class GrupoMuscular
    {
        [Key]
        public int IdGrupoMuscular { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        // Relação com a classe Exercicio
        public ICollection<Exercicio> Exercicios { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDiary.Entidades
{
    public class Treino
    {
        [Key]
        public int IdTreino { get; set; }

        public int IdUsuario { get; set; }  // Adicionando a chave estrangeira explicitamente
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        [Required]
        public string Duracao { get; set; }

        // Relação com a classe Exercicio
        public ICollection<Exercicio> Exercicios { get; set; }

        // Relação com a classe Categoria
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public CategoriaExercicio Categoria { get; set; }
    }

}

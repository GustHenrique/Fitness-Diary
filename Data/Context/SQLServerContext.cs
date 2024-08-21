using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CategoriaExercicio> CategoriaExercicio { get; set; }
        public DbSet<Exercicio> Exercicio { get; set; }
        public DbSet<Treino> Treino { get; set; }
        public DbSet<GrupoMuscular> GrupoMuscular { get; set; }
    }
}

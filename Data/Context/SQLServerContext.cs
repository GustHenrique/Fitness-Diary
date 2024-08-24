using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CategoriaExercicio> CategoriaExercicios { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<GrupoMuscular> GruposMusculares { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaExercicio>()
                .HasData(
                    new CategoriaExercicio { IdCategoria = 1, Nome = "Força" },
                    new CategoriaExercicio { IdCategoria = 2, Nome = "Core e Abdominais" },
                    new CategoriaExercicio { IdCategoria = 3, Nome = "Exercícios com Peso Corporal" },
                    new CategoriaExercicio { IdCategoria = 4, Nome = "Exercícios de Resistência" },
                    new CategoriaExercicio { IdCategoria = 5, Nome = "Exercícios para Grupos Musculares Específicos" }
                );

            modelBuilder.Entity<GrupoMuscular>()
            .HasData(
                new GrupoMuscular { IdGrupoMuscular = 1, Nome = "Peitoral" },
                new GrupoMuscular { IdGrupoMuscular = 2, Nome = "Dorsal" },
                new GrupoMuscular { IdGrupoMuscular = 3, Nome = "Ombros" },
                new GrupoMuscular { IdGrupoMuscular = 4, Nome = "Bíceps" },
                new GrupoMuscular { IdGrupoMuscular = 5, Nome = "Tríceps" },
                new GrupoMuscular { IdGrupoMuscular = 6, Nome = "Quadríceps" },
                new GrupoMuscular { IdGrupoMuscular = 7, Nome = "Isquiotibiais" },
                new GrupoMuscular { IdGrupoMuscular = 8, Nome = "Glúteos" },
                new GrupoMuscular { IdGrupoMuscular = 9, Nome = "Panturrilhas" },
                new GrupoMuscular { IdGrupoMuscular = 10, Nome = "Abdômen" },
                new GrupoMuscular { IdGrupoMuscular = 11, Nome = "Lombar" },
                new GrupoMuscular { IdGrupoMuscular = 12, Nome = "Músculos do Core" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class ExercicioService : IExercicioService
    {
        private readonly SQLServerContext _context;

        public ExercicioService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<List<Exercicio>> GetExerciciosByTreinoIdAsync(int treinoId)
        {
            return await _context.Exercicios
                                 .Where(e => e.IdTreino == treinoId)
                                 .Include(e => e.GrupoMuscular)
                                 .Include(e => e.Treino) // Inclui o Treino relacionado
                                 .ThenInclude(t => t.Categoria) // Inclui a Categoria do Treino, se necessário
                                 .ToListAsync();
        }

        public async Task<Exercicio> GetExercicioByIdAsync(int produtoId)
        {
            return await _context.Exercicios.FindAsync(produtoId);
        }

        public async Task<List<Exercicio>> GetExercicioAsync()
        {
            return await _context.Exercicios.ToListAsync();
        }
        public async Task AddExercicioAsync(Exercicio produto)
        {
            _context.Exercicios.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteExercicioAsync(Exercicio produto)
        {
            _context.Exercicios.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateExercicioAsync(Exercicio produto)
        {
            _context.Exercicios.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}

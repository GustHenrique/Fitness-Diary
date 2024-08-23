using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class CategoriaExercicioService : ICategoriaExercicioService
    {
        private readonly SQLServerContext _context;

        public CategoriaExercicioService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<CategoriaExercicio> GetCategoriaExercicioByIdAsync(int categoriaExercicioId)
        {
            return await _context.CategoriaExercicios.FindAsync(categoriaExercicioId);
        }

        public async Task<List<CategoriaExercicio>> GetCategoriaExercicioAsync()
        {
            return await _context.CategoriaExercicios.ToListAsync();
        }
        public async Task AddCategoriaExercicioAsync(CategoriaExercicio categoriaExercicio)
        {
            _context.CategoriaExercicios.Add(categoriaExercicio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoriaExercicioAsync(CategoriaExercicio categoriaExercicio)
        {
            _context.CategoriaExercicios.Remove(categoriaExercicio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoriaExercicioAsync(CategoriaExercicio categoriaExercicio)
        {
            _context.CategoriaExercicios.Update(categoriaExercicio);
            await _context.SaveChangesAsync();
        }
    }
}

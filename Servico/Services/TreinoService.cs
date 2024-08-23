using FitnessDiary.Components.Pages;
using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class TreinoService : ITreinoService
    {
        private readonly SQLServerContext _context;

        public TreinoService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<Treino> GetTreinoByIdAsync(int treinoId)
        {
            return await _context.Treinos.FindAsync(treinoId);
        }

        public async Task<List<Treino>> GetTreinoAsync()
        {
            return await _context.Treinos.ToListAsync();
        }
        public async Task AddTreinoAsync(Treino treino)
        {
            var usuario = await _context.Usuarios.FindAsync(treino.IdUsuario);
            var categoria = await _context.CategoriaExercicios.FindAsync(treino.IdCategoria);

            if (usuario == null || categoria == null)
            {
                // Trate o caso onde o usuário ou a categoria não existem
                throw new InvalidOperationException("Usuário ou categoria não encontrado.");
            }

            treino.Usuario = usuario;
            treino.Categoria = categoria;

            _context.Treinos.Add(treino);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTreinoAsync(Treino treino)
        {
            _context.Treinos.Remove(treino);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTreinoAsync(Treino treino)
        {
            _context.Treinos.Update(treino);
            await _context.SaveChangesAsync();
        }
    }
}

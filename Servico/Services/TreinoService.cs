using FitnessDiary.Components.Pages;
using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class TreinoService : ITreinoService
    {
        private readonly SQLServerContext _context;
        private IExercicioService _exercicioService;
        private IUsuarioService _usuarioService;

        public TreinoService(SQLServerContext context, IExercicioService exercicioService, IUsuarioService usuarioService)
        {
            _context = context;
            _exercicioService = exercicioService;
            _usuarioService = usuarioService;
        }

        public async Task<Treino> GetTreinoByIdAsync(int treinoId)
        {
            return await _context.Treinos.FindAsync(treinoId);
        }


        public async Task<List<Treino>> GetTreinosByUsuarioIdAsync(int usuarioId)
        {
            return await _context.Treinos
                                 .Where(t => t.IdUsuario == usuarioId)
                                 .Include(e => e.Exercicios)
                                 .ToListAsync();
        }

        public async Task<List<Treino>> GetTreinoAsync()
        {
            return await _context.Treinos.ToListAsync();
        }
        public async Task AddTreinoAsync(Treino treino)
        {
            var usuario = await _context.Usuarios.FindAsync(treino.IdUsuario);
            var categoria = await _context.CategoriaExercicios.FindAsync(treino.IdCategoria);

            foreach (var exercicio in treino.Exercicios)
            {
                exercicio.IdExercicio = 0;
                exercicio.GrupoMuscular = await _context.GruposMusculares.FindAsync(exercicio.IdGrupoMuscular);
            }

            if (usuario == null || categoria == null)
            {
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

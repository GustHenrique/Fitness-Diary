using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly SQLServerContext _context;

        public UsuarioService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int produtoId)
        {
            return await _context.Usuario.FindAsync(produtoId);
        }

        public async Task<List<Usuario>> GetUsuarioAsync()
        {
            return await _context.Usuario.ToListAsync();
        }
        public async Task AddUsuarioAsync(Usuario produto)
        {
            _context.Usuario.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUsuarioAsync(Usuario produto)
        {
            _context.Usuario.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUsuarioAsync(Usuario produto)
        {
            _context.Usuario.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}

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
            return await _context.Usuarios.FindAsync(produtoId);
        }

        public async Task<List<Usuario>> GetUsuarioAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
        public async Task AddUsuarioAsync(Usuario produto)
        {
            _context.Usuarios.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUsuarioAsync(Usuario produto)
        {
            _context.Usuarios.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUsuarioAsync(Usuario produto)
        {
            _context.Usuarios.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> AuthenticateAsync(string email, string senha)
        {
            // Verifica se um usuário com o email fornecido existe
            var usuario = await _context.Usuarios
                .SingleOrDefaultAsync(u => u.Email == email);

            // Se não encontrar o usuário ou a senha não corresponder, retorna nulo
            if (usuario == null || usuario.Senha != senha)
            {
                return null;
            }

            return usuario;
        }
    }
}

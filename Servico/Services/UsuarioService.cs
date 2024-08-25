using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Text;

namespace FitnessDiary.Servico.Implementacoes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly SQLServerContext _context;
        private IEncryptionService _encryptionService;

        public UsuarioService(SQLServerContext context, IEncryptionService encryptionService)
        {
            _context = context;
            _encryptionService = encryptionService;
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int produtoId)
        {
            return await _context.Usuarios.FindAsync(produtoId);
        }

        public async Task<Usuario?> GetUsuarioByEmailAsync(string email)
        {
            return await _context.Usuarios
                                 .Where(t => t.Email == email)
                                 .FirstOrDefaultAsync(); 
        }

        public async Task<List<Usuario>> GetUsuarioAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
        public async Task AddUsuarioAsync(Usuario produto)
        {
            produto.Senha = _encryptionService.Encrypt(produto.Senha);
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
            produto.Senha = _encryptionService.Encrypt(produto.Senha);
            _context.Usuarios.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> AuthenticateAsync(string email, string senha)
        {
            senha = _encryptionService.Encrypt(senha).ToString();

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

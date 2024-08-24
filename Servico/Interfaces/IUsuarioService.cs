using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetUsuarioAsync();
        Task<Usuario> GetUsuarioByIdAsync(int usuarioId);
        Task<Usuario> GetUsuarioByEmailAsync(string email);
        Task AddUsuarioAsync(Usuario usuario);
        Task UpdateUsuarioAsync(Usuario usuario);
        Task DeleteUsuarioAsync(Usuario usuario);
        Task<Usuario> AuthenticateAsync(string email, string senha);
    }
}

using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface ITreinoService
    {
        Task<List<Treino>> GetTreinoAsync();
        Task<List<Treino>> GetTreinosByUsuarioIdAsync(int usuarioId);
        Task<Treino> GetTreinoByIdAsync(int TreinoId);
        Task AddTreinoAsync(Treino Treino);
        Task UpdateTreinoAsync(Treino Treino);
        Task DeleteTreinoAsync(Treino Treino);
    }
}

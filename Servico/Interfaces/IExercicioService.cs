using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface IExercicioService
    {
        Task<List<Exercicio>> GetExercicioAsync();
        Task<Exercicio> GetExercicioByIdAsync(int ExercicioId);
        Task AddExercicioAsync(Exercicio Exercicio);
        Task UpdateExercicioAsync(Exercicio Exercicio);
        Task DeleteExercicioAsync(Exercicio Exercicio);
    }
}

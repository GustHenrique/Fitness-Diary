using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface ICategoriaExercicioService
    {
        Task<List<CategoriaExercicio>> GetCategoriaExercicioAsync();
        Task<CategoriaExercicio> GetCategoriaExercicioByIdAsync(int CategoriaExercicioId);
        Task AddCategoriaExercicioAsync(CategoriaExercicio CategoriaExercicio);
        Task UpdateCategoriaExercicioAsync(CategoriaExercicio CategoriaExercicio);
        Task DeleteCategoriaExercicioAsync(CategoriaExercicio CategoriaExercicio);
    }
}

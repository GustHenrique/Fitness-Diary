using FitnessDiary.Entidades;

namespace FitnessDiary.Servico.Implementacoes
{
    public interface IGrupoMuscularService
    {
        Task<List<GrupoMuscular>> GetGrupoMuscularAsync();
        Task<GrupoMuscular> GetGrupoMuscularByIdAsync(int GrupoMuscularId);
        Task AddGrupoMuscularAsync(GrupoMuscular GrupoMuscular);
        Task UpdateGrupoMuscularAsync(GrupoMuscular GrupoMuscular);
        Task DeleteGrupoMuscularAsync(GrupoMuscular GrupoMuscular);
    }
}

using FitnessDiary.Data.Context;
using FitnessDiary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessDiary.Servico.Implementacoes
{
    public class GrupoMuscularService : IGrupoMuscularService
    {
        private readonly SQLServerContext _context;

        public GrupoMuscularService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<GrupoMuscular> GetGrupoMuscularByIdAsync(int grupoMuscularId)
        {
            return await _context.GruposMusculares.FindAsync(grupoMuscularId);
        }

        public async Task<List<GrupoMuscular>> GetGrupoMuscularAsync()
        {
            return await _context.GruposMusculares.ToListAsync();
        }
        public async Task AddGrupoMuscularAsync(GrupoMuscular grupoMuscular)
        {
            _context.GruposMusculares.Add(grupoMuscular);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGrupoMuscularAsync(GrupoMuscular grupoMuscular)
        {
            _context.GruposMusculares.Remove(grupoMuscular);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGrupoMuscularAsync(GrupoMuscular grupoMuscular)
        {
            _context.GruposMusculares.Update(grupoMuscular);
            await _context.SaveChangesAsync();
        }
    }
}

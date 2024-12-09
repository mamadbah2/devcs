using devcs.Models;

namespace devcs.Services.Interf;

public interface IEtudiantService
{
    Task<List<Cours>> GetCoursAsync(int etudiantId);
    
    Task<List<Absence>> GetAbsencesAsync(int etudiantId);
}
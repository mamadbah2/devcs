using devcs.Data;
using devcs.Models;

namespace devcs.Services;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EtudiantService
{
    private readonly ApplicationDbContext _context;

    public EtudiantService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cours>> GetCoursAsync(int etudiantId)
    {
        var etudiant = await _context.Etudiants
            .FirstOrDefaultAsync(e => e.Id == etudiantId);

        if (etudiant == null)
        {
            return null;
        }

        return await _context.Cours
            .ToListAsync();
    }

    public async Task<List<Absence>> GetAbsencesAsync(int etudiantId)
    {
        return await _context.Absences
            .Include(a => a.Cours)
            .Where(a => a.Etudiant.Id == etudiantId)
            .ToListAsync();
    }
}

using devcs.Services;

namespace devcs.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class EtudiantsController : ControllerBase
{
    private readonly EtudiantService _etudiantService;

    public EtudiantsController(EtudiantService etudiantService)
    {
        _etudiantService = etudiantService;
    }

    [HttpGet("{etudiantId}/cours")]
    public async Task<IActionResult> GetCours(int etudiantId)
    {
        var cours = await _etudiantService.GetCoursAsync(etudiantId);

        if (cours == null)
        {
            return NotFound(new { message = "Étudiant non trouvé ou aucun cours disponible." });
        }

        return Ok(cours);
    }

    
    [HttpGet("{etudiantId}/absences")]
    public async Task<IActionResult> GetAbsences(int etudiantId)
    {
        var absences = await _etudiantService.GetAbsencesAsync(etudiantId);

        if (absences == null || absences.Count == 0)
        {
            return NotFound(new { message = "Aucune absence trouvée pour cet étudiant." });
        }

        return Ok(absences);
    }
}

using devcs.Models;

using Microsoft.AspNetCore.Mvc;

public interface IEtudiantsController
{
    Task<IActionResult> GetCours(int etudiantId);

    Task<IActionResult> GetAbsences(int etudiantId);
}

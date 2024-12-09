using System.Runtime.InteropServices.JavaScript;

namespace devcs.Models;

public class Cours
{
    private int _id;
    private DateTime _date;
    private DateTime _heureDebut;
    private DateTime _heureFin;
    private int _nombreHeure;
    private string _semestre;
    
    public int Id { get => _id; set => _id = value; }
    public DateTime Date { get => _date; set => _date = value; }
    public DateTime HeurDebut { get => _heureDebut; set => _heureDebut = value; }
    public DateTime HeureFin { get => _heureFin; set => _heureFin = value; }
    public int NombreHeure { get => _nombreHeure; set => _nombreHeure = value; }
    public string Semestre { get => _semestre; set => _semestre = value; }
    public virtual ICollection<Absence> Absences {get; set;}
}
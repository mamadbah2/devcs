namespace devcs.Models;

public class Absence
{
    private int _id;
    private DateTime _date = DateTime.Today;
    
    public int Id { get => _id; set => _id = value; }
    public DateTime Date { get => _date; set => _date = value; }
    public Etudiant? Etudiant { get; set; }
    public Cours? Cours { get; set; }
}
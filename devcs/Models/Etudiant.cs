namespace devcs.Models;

public class Etudiant
{
    private int _id;
    private string _matricule;
    private string _nom;
    private string _prenom;
    private Absence _absences;
    private Cours _cours;
    
    public Etudiant() { }
    public int Id { get => _id; set => _id = value; }
    public string Matricule { get => _matricule; set => _matricule = value; }
    public string Nom { get => _nom; set => _nom = value; }
    public string Prenom { get => _prenom; set => _prenom = value; }
    
    public virtual ICollection<Absence> Absences {get; set;}
    
}
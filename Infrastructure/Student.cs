namespace PBInfrastructure;

public class Student {
    
    public int Id {get; set;}
    
    [StringLength(50)]
    public string Name {get; set;}

    public ICollection<Project>? Projects {get; set;}

    public Student(string _Name) {
        Name = _Name;
    }
}
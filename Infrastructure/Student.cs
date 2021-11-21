namespace PB.Infrastructure;

public class Student {
    
    public int Id {get; set;}
    
    [StringLength(50)]
    public string Name {get; set;}

    public ICollection<Project>? Projects {get; set;}


}
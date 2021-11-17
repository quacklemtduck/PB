namespace PBInfrastructure;
public class Application
{
    public int Id {get; set;}
    public int StudentID {get; set;}
    public int ProjectID {get; set;}
    public string? Description {get; set;}

    public Project Project {get; set;}

    public Student Student {get; set;}

}
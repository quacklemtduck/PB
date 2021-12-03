namespace PB.Infrastructure;

public class Supervisor
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Name {get; set;}

    [StringLength(255)]
    [EmailAddress]
    public string Email {get; set;}

    public ICollection<Project> Projects {get; set;} = new HashSet<Project>();
}
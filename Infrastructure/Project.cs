namespace PBInfrastructure;


public class Project
{
    public int ID { get; set; }

    public string? Title { get; set; } //TODO: not nullable

    public string? Description { get; set; }

    public int SupervisorID { get; set; } //TODO: not 0

    [EmailAddress]
    public string? Email { get; set; } //TODO: not nullable

    public DateTime? Deadline { get; set; } 

    public bool getNotification { get; set; }

    public int numberOfStudents {get; set;}

    public ICollection<Student> CollabStudents {get; set;}  = new HashSet<Student>();

    public ICollection<Tag> Tags {get; set;} = new HashSet<Tag>();

    public ICollection<Application> Applications { get; set; } = new HashSet<Application>();

    public ICollection<University> Universities {get; set;} = new HashSet<University>();











    
    
}

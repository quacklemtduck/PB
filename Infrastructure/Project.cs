namespace PBInfrastructure;


public class Project
{
    public int ID { get; set; }

    public string? Title { get; set; } //TODO: not nullable

    public string? Description { get; set; }

    public int SupervisorID { get; set; } //TODO: not 0

    public DateTime? Deadline { get; set; } 

    public bool getNotification { get; set; }










    
    
}

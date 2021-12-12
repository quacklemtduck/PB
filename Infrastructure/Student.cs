namespace PB.Infrastructure;

public class Student {
    
    public int Id {get; set;}
    
    [StringLength(50)]
    public string? Name {get; set;}

    [EmailAddress]
    public string? Email {get; set;}

    public ICollection<Project> Projects {get; set;} = new HashSet<Project>();

    public ICollection<Application> Applications {get; set;} = new HashSet<Application>();
    public University? University {get; set;}


    // public ICollection<int> GetProjectIDs() {
    //     ICollection<int> ProjectIDList = new List<int>();
    //     if(Projects != null) {
    //         foreach (Project p in Projects) 
    //         {
    //         ProjectIDList.Add(p.Id);
    //         }
    //     }
    //     return ProjectIDList;
    // }

}
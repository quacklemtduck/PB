namespace PB.Infrastructure;

public class Student {
    
    public int Id {get; set;}
    
    [StringLength(50)]
    public string Name {get; set;}

    public ICollection<Project> Projects {get; set;}

    public ICollection<int> GetProjectIDs() {
        ICollection<int> ProjectIDList = new List<int>();
        if(Projects != null) {
            foreach (Project p in Projects) 
            {
            ProjectIDList.Add(p.Id);
            }
        }
        return ProjectIDList;
    }

}
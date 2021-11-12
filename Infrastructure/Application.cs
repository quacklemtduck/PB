namespace PBInfrastructure;
public class Application
{
    public int Id {get; set;}
    public int studentID {get; set;}
    public int projectID {get; set;}
    public string? Description {get; set;}

    public Application(int _studentID, int _projectID) {
        studentID = _studentID;
        projectID = _projectID;
    }
}
namespace PB.Core;

public record ApplicationUpdateDTO(int Id, int studentId, int projectId);
public record ApplicationDetailsDTO(int Id, int studentId, int projectId, string Description);
public record ApplicationCreateDTO
{
    public int Id {get; set;}
    public int studentId {get; set;}
    public int projectId {get; set;}
    public string Description {get; set;}

    public ApplicationCreateDTO(int _studentId, int _projectId, string _Description) {
        studentId = _studentId;
        projectId = _projectId;
        Description = _Description;
    }
}

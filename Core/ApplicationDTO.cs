namespace PB.Core;

public record ApplicationUpdateDTO(int Id, string? Description, string Title);
public record ApplicationDetailsDTO(int Id, int studentId, int projectId, string? Description, string Title, string studentName);
public record ApplicationCreateDTO
{
    public int studentId {get; set;}
    public int projectId {get; set;}
    public string? Description {get; set;}
    public string Title {get; set;}

    public ApplicationCreateDTO(int _studentId, int _projectId, string _title) {
        studentId = _studentId;
        projectId = _projectId;
        Title = _title;
    }
}

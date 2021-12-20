namespace PB.Core;

public record StudentDTO();

public record StudentDetailsDTO(int Id, string Name, int EducationId, string Email, ICollection<string>? Projects, ISet<string> Applications);
public record StudentCreateDTO
{
    [StringLength(50)]
    public string? Name {get; set;}

    public int EducationId {get; set;}
    
    [EmailAddress]
    public string? Email {get; set;}

    
}

//public record StudentUpdateDTO(int Id, string Name, ICollection<int> Projects);

public record StudentUpdateDTO : StudentCreateDTO{
    public int Id {get; set;}
    public ICollection<string> Projects {get; set;}
    public ISet<string> Applications {get; set;}

    }
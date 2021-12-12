namespace PB.Core;

//public record StudentDTO();

public record StudentDetailsDTO(int Id, string Name, string? University, string Email, ICollection<string>? Projects, ISet<string> Applications);
public record StudentCreateDTO
{
    [StringLength(50)]
    public string? Name {get; set;}

    public string? University {get; set;}
    
    [EmailAddress]
    public string? Email {get; set;}

    
}

//public record StudentUpdateDTO(int Id, string Name, ICollection<int> Projects);

public record StudentUpdateDTO : StudentCreateDTO{
    public int Id {get; set;}
    public ICollection<int> Projects {get; set;}
    public ICollection<int> Applications {get; set;}

    }
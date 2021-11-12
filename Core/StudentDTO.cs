namespace Core;

public record StudentDTO();

public record StudentDetailsDTO(int Id, string Name, ICollection<int>? Projects);
public record StudentCreateDTO
{
    [StringLength(50)]
    public string Name {get; set;}
}

public record StudentUpdateDTO(int Id, string Name, ICollection<int> Projects);

//StudentUpdateDTO
//StudentDetailsDTO
//StudentCreateDTO??
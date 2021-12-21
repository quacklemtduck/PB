namespace PB.Core;

public record StudentDetailsDTO(int Id, string Name, string Education, string Email, ICollection<string>? Projects, ISet<string> Applications, string University);
public record StudentCreateDTO
{
    [StringLength(50)]
    public string? Name { get; set; }

    public int EducationId { get; set; }

    [EmailAddress]
    public string? Email { get; set; }


}

public record StudentUpdateDTO : StudentCreateDTO
{
    public int Id { get; set; }
}
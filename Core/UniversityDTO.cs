namespace PB.Core
{
    public record UniversityDetailsDTO(string Id, string Name, ICollection<int>? Educations);

    public record EducationDetailsDTO(int Id, string Name, string Grade, string UniversityId);
}

namespace PB.Core
{
    public interface IEducationRepository
    {
        Task<EducationDetailsDTO> ReadByIDAsync(int educationId);
        Task<IReadOnlyCollection<EducationDetailsDTO>> ReadAllByUniversityAsync(string universityId);
        Task<IReadOnlyCollection<EducationDetailsDTO>> ReadAllAsync();

    }
}

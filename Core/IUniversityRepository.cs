namespace PB.Core
{
    public interface IUniversityRepository
    {
        Task<UniversityDetailsDTO> ReadByIDAsync(string universityId);
        Task<IReadOnlyCollection<UniversityDetailsDTO>> ReadAllAsync();

    }
}

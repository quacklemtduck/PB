namespace PB.Core
{
    public interface IApplicationRepository
    {
         Task<ApplicationDetailsDTO> CreateAsync(ApplicationCreateDTO application);
         Task<ApplicationDetailsDTO> ReadAsync(int applicationId);
         Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadAsync();
         Task<Response> UpdateAsync(int id, ApplicationUpdateDTO appliation);
    }
}
namespace PB.Core
{
    public interface IApplicationRepository
    {
         Task<ApplicationDetailsDTO> CreateAsync(ApplicationCreateDTO application);
         Task<Option<ApplicationDetailsDTO>> ReadAsync(int applicationId);
         Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadAllAsync();
         Task<Response> UpdateAsync(int id, ApplicationUpdateDTO appliation);

         Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadFromProject(int projectId);
    }
}
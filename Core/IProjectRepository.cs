namespace PB.Core
{

    public interface IProjectRepository
    {

        Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project);

        Task<Response> DeleteAsync(int projectID);

        Task<Response> UpdateAsync(ProjectCreateDTO project);

        Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId);

        Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync();

        Task<IReadOnlyCollection<ProjectListDTO>> ListAllVisibleAsync();

        Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync(string SupervisorID);

        Task<Response> UpdateStatusAsync(ProjectVisibilityUpdateDTO dto);
        Task<Response> UpdateChosenStudentsAsync(ProjectChosenStudentsUpdateDTO dto);
    }
}
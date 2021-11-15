using Core;

namespace PBInfrastructure;

public class ProjectRepository : IProjectRepository
{
    public Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project)
    {
        throw new NotImplementedException();
    }

    public Task<Status> DeleteAsync(int projectID)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId)
    {
        throw new NotImplementedException();
    }

    public Task<Status> UpdateAsync(int ID, ProjectUpdateDTO project)
    {
        throw new NotImplementedException();
    }
}
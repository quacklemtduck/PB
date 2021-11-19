using Core;

namespace PBInfrastructure;

public class ProjectRepository : IProjectRepository
{

    PBContext _context;

    public ProjectRepository(PBContext context)
    {
        _context = context;
    }

    public Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project)
    {
        throw new NotImplementedException();
    }

    public Task<Response> DeleteAsync(int projectID)
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

    public Task<Response> UpdateAsync(int ID, ProjectUpdateDTO project)
    {
        throw new NotImplementedException();
    }
}
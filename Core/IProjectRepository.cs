namespace Core;

public interface IProjectRepository {

    //create
    Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project);

    //delete
    Task<Status> DeleteAsync(int projectID);

    ////Update: Update state
    Task<Status> UpdateAsync(int ID, ProjectUpdateStateDTO project);

    //Update: Edit
    Task<Status> UpdateAsync(int ID, ProjectDetailsDTO project);

    //Update: Add application
    Task<Status> UpdateAsync(int ID, ProjectUpdateApplicationDTO project);
     
    //Read by id
    Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId); //What is option???

    //List all ProjectListDTO
    Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync();
}

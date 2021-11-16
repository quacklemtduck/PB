namespace PB.Core;

public interface IProjectRepository {

    //create
    Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project);

    //delete
    Task<Response> DeleteAsync(int projectID);

    ////Update: Update state, Add application, Edit
    Task<Response> UpdateAsync(int ID, ProjectUpdateDTO project);

    //Read by id
    Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId); //What is option???

    //List all ProjectListDTO
    Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync();
}

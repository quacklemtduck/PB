namespace PB.Core;

public interface IProjectRepository {

    //create
    Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project);

    //delete
    Task<Response> DeleteAsync(int projectID);

    ////Update: Update state, Add application, Edit
    Task<Response> UpdateAsync(int ID, ProjectUpdateDTO project);
    /*Task<Response> UpdateStateAsync(int ID, ProjectUpdateDTO project);
    Task<Response> UpdateAddApplicationAsync(int ID, ProjectUpdateDTO project);
    Task<Response> UpdateEditAsync(int ID, ProjectUpdateDTO project);*/ //skal de her med, og skal have have mere specifikke dtos?

    //Read by id
    Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId); //What is option???

    //List all ProjectListDTO
    Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync();
}

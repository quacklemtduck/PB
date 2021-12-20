namespace PB.Core
{

    public interface IProjectRepository
    {

        //create
        Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project);

        //delete
        Task<Response> DeleteAsync(int projectID);

        ////Update: Update state, Add application, Edit
        Task<Response> UpdateAsync(ProjectCreateDTO project); //Edit
        /*Task<Response> UpdateStateAsync(int ID, ProjectUpdateDTO project);
        Task<Response> UpdateAddApplicationAsync(int ID, ProjectUpdateDTO project);
        Task<Response> UpdateChooseStudentsAsync(int ID, ProjectUpdateDTO project);*/

        //Read by id
        Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId);

        //List all ProjectListDTO
        Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync();

        //List all supervisor's ProjectListDTO
        Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync(string SupervisorID);

        Task<Response> UpdateStatusAsync(ProjectVisibilityUpdateDTO dto);
    }
}
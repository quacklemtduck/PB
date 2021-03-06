using PB.Core;
using System.Net.Http.Json;

namespace PB.Client.Services

{
    public static class ProjectService
    {
        public async static Task<ICollection<ProjectListDTO>> GetMyProjects(HttpClient http)
        {
            try
            {
                var result = await http.GetFromJsonAsync<ProjectListDTO[]>("api/Projects/GetAllFromSupervisor");
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async static Task<ICollection<ProjectListDTO>> GetVisibleProjects(HttpClient http)
        {
            try
            {
                var result = await http.GetFromJsonAsync<ProjectListDTO[]>("api/Projects/GetAllVisible");
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async static Task<HttpResponseMessage?> PostProject(HttpClient http, ProjectCreateDTO req)
        {
            var result = await http.PostAsJsonAsync("api/Projects/Post", req);
            return result;
        }

        public async static Task<ProjectDetailsDTO?> GetProject(HttpClient http, int? id)
        {
            var result = await http.GetFromJsonAsync<ProjectDetailsDTO>($"api/Projects/get/{id}");
            return result;
        }

        public async static Task<HttpResponseMessage?> UpdateProjectVisibility(HttpClient http, ProjectVisibilityUpdateDTO req)
        {
            var result = await http.PutAsJsonAsync("api/Projects/UpdateStatus", req);
            return result;
        }

        public async static Task<HttpResponseMessage?> DeleteProject(HttpClient http, int id)
        {
            var result = await http.PostAsJsonAsync("api/Projects/DeleteProject", new ProjectDeleteDTO { ID = id });
            return result;
        }

        public async static Task<ICollection<EducationDetailsDTO>> GetAllEducations(HttpClient http)
        {
            return await http.GetFromJsonAsync<EducationDetailsDTO[]>("api/University/GetAllEducations");
        }

        public async static Task<ICollection<ApplicationDetailsDTO>> GetApplications(HttpClient http, int projectId)
        {
            try
            {
                var result = await http.GetFromJsonAsync<ApplicationDetailsDTO[]>($"api/Application/GetFromProject/{projectId}");
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async static Task<HttpResponseMessage?> ApproveApplication(HttpClient http, int id)
        {
            var result = await http.PutAsJsonAsync("api/Application/Approve", new ApplicationIdDTO(id));
            return result;
        }

        public async static Task<HttpResponseMessage?> DeclineApplication(HttpClient http, int id)
        {
            var result = await http.PutAsJsonAsync("api/Application/Decline", new ApplicationIdDTO(id));
            return result;
        }
    }

}
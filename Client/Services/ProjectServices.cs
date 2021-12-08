using PB.Core;
using System.Net.Http.Json;

namespace PB.Client.Services

{
    public static class ProjectService {
        public async static Task<ICollection<ProjectListDTO>> GetMyProjects(HttpClient http){
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

        public async static Task<HttpResponseMessage?> CreateProject(HttpClient http, ProjectCreateDTO req){
            var result = await http.PostAsJsonAsync("api/Projects/Post", req);
            return result;
        }

        public async static Task<ProjectDetailsDTO?> GetProject(HttpClient http, int? id){
            var result = await http.GetFromJsonAsync<ProjectDetailsDTO>($"api/Projects/get/{id}");
            return result;
        }

        public async static Task<HttpResponseMessage?> UpdateProjectVisibility(HttpClient http, ProjectVisibilityUpdateDTO req){
            var result = await http.PutAsJsonAsync("api/Projects/UpdateStatus", req);
            return result;
        }
    }

}
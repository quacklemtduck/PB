using PB.Core;
using System.Net.Http.Json;

namespace PB.Client.Services

{
    public static class SupervisorServices
    {

        public async static Task<SupervisorDetailsDTO> GetSupervisorAsync(HttpClient http, string id)
        {
            Console.WriteLine($"api/Supervisor/GetSupervisor/{id}");
            return await http.GetFromJsonAsync<SupervisorDetailsDTO>($"api/Supervisor/GetSupervisor/{id}");
        }
    }

}
using PB.Core;
using System.Net.Http.Json;

namespace PB.Client.Services

{
    public static class UniversityService
    {

        public async static Task<ICollection<EducationDetailsDTO>> GetAllEducations(HttpClient http)
        {
            return await http.GetFromJsonAsync<EducationDetailsDTO[]>("api/University/GetAllEducations");
        }
    }

}
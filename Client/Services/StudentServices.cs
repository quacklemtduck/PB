using PB.Core;
using System.Net.Http.Json;

namespace PB.Client.Services

{
    public static class StudentServices
    {

        public async static Task<StudentDetailsDTO> GetStudentAsync(HttpClient http, int id)
        {
            Console.WriteLine($"api/Student/GetStudent/{id}");
            return await http.GetFromJsonAsync<StudentDetailsDTO>($"api/Students/GetStudent/{id}");
        }
    }

}
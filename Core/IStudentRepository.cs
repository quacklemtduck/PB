namespace PB.Core
{
    public interface IStudentRepository
    {
         Task<StudentDetailsDTO> CreateAsync(StudentCreateDTO student);
         Task<Option<StudentDetailsDTO>> ReadAsync(int studentId);
         Task<Response> UpdateAsync(int id, StudentUpdateDTO student);
    }
}
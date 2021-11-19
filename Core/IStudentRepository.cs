namespace Core
{
    public interface IStudentRepository
    {
         Task<StudentDetailsDTO> CreateAsync(StudentCreateDTO student);
         Task<StudentDetailsDTO> ReadAsync(int studentId);
         Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAsync();
         Task<Status> UpdateAsync(int id, StudentUpdateDTO student);
    }
}
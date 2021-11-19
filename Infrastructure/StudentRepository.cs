namespace PB.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {

        PBContext _context;

        public StudentRepository(PBContext context)
        {
            _context = context;
        }

        public Task<StudentDetailsDTO> CreateAsync(StudentCreateDTO student)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<StudentDetailsDTO>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDetailsDTO> ReadAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(int id, StudentUpdateDTO student)
        {
            throw new NotImplementedException();
        }
    }
}

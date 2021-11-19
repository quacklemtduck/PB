namespace PBInfrastructure
{
    public class StudentRepository : IStudentRepository
    {
        PBContext _context;

        public StudentRepository(PBContext context)
        {
            _context = context;
        }

        public Task<StudentDetailsDTO> CreateAsync(StudentCreateDTO student) {
            throw new NotImplementedException();
        }

        public Task<Option<StudentDetailsDTO>> ReadAsync(int studentId) {
            throw new NotImplementedException();
        }
    }
}
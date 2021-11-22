namespace PB.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {

        private readonly PBContext _context;

        public StudentRepository(PBContext context)
        {
            _context = context;
        }

        public async Task<StudentDetailsDTO> CreateAsync(StudentCreateDTO student)
        {
            var entity = new Student 
            {
                Name = student.Name
            };

            _context.Students.Add(entity);

            await _context.SaveChangesAsync();

            return new StudentDetailsDTO(
                        entity.Id,
                        entity.Name,
                        entity.Projects
            );
        }

        public Task<IReadOnlyCollection<StudentDetailsDTO>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<StudentDetailsDTO> ReadAsync(int studentId)
        {
            var students = from s in _context.Students
                           where s.Id == studentId
                           select new StudentDetailsDTO(
                               s.Id,
                               s.Name,
                               s.Projects
                           );

            return await students.FirstOrDefaultAsync();
        }

        public async Task<Response> UpdateAsync(int id, StudentUpdateDTO student)
        {
            var entity = await _context.Students.Include(s => s.Projects).FirstOrDefaultAsync(s => s.Id == student.Id);

            if (entity == null)
            {
                return NotFound;
            }

            entity.Name = student.Name;

            await _context.SaveChangesAsync();

            return Updated;
        }

        public async Task<Response> DeleteAsync(int studentId)
        {
        var entity = await _context.Students.FindAsync(studentId);

        if (entity == null)
        {
            return NotFound;
        }

        _context.Students.Remove(entity);
        await _context.SaveChangesAsync();

        return Deleted;
        }
    }
}

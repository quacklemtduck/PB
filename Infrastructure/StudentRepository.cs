namespace PB.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {

        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
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
                        entity.GetProjectIDs()
            );
        }

        public async Task<IReadOnlyCollection<StudentDetailsDTO>> ReadAllAsync()
        {
            return await _context.Students
                .Select(s => new StudentDetailsDTO(s.Id,s.Name,s.Projects.Select(s => s.Id).ToList<int>()))
                .ToListAsync();
        }

        public async Task<StudentDetailsDTO> ReadAsync(int studentId)
        {
            var students = from s in _context.Students
                           where s.Id == studentId
                           select new StudentDetailsDTO(
                               s.Id,
                               s.Name,
                               s.GetProjectIDs()
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

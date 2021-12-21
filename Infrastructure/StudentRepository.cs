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
                Name = student.Name,
                Education = await _context.Educations.FindAsync(student.EducationId),
                Email = student.Email
            };

            _context.Students.Add(entity);

            await _context.SaveChangesAsync();



            return new StudentDetailsDTO(
                        entity.Id,
                        entity.Name,
                        entity.Education.Name,
                        entity.Email,
                        entity.Projects.Select(p => p.Title).ToHashSet(),
                        entity.Applications.Select(a => a.Title).ToHashSet(),
                        entity.Education.University.Name
            );
        }

        public async Task<Option<StudentDetailsDTO>> ReadAsync(int studentId)
        {
            var students = from s in _context.Students
                           where s.Id == studentId
                           select new StudentDetailsDTO(
                               s.Id,
                               s.Name,
                               s.Education.Name,
                               s.Email,
                               s.Projects.Select(p => p.Title).ToHashSet(),
                               s.Applications.Select(a => a.Title).ToHashSet(),
                               s.Education.University.Name
                           );

            return await students.FirstOrDefaultAsync();
        }

        public async Task<Response> UpdateAsync(int id, StudentUpdateDTO student)
        {
            var entity = await _context.Students.Include(s => s.Projects).Include(s => s.Applications).FirstOrDefaultAsync(s => s.Id == student.Id);
            if (entity == null)
            {
                return NotFound;
            }
            entity.Name = student.Name;
            entity.Email = student.Email;

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


        private async Task<University?> getUniversityAsync(string? name) =>
        string.IsNullOrWhiteSpace(name) ? null : await _context.Universities.FirstOrDefaultAsync(s => s.Name == name) ?? new University { Name = name };


        private async IAsyncEnumerable<Project> GetProjectsAsync(IEnumerable<int> projects)
        {
            var existing = await _context.Projects.Where(p => projects.Contains(p.Id)).ToDictionaryAsync(p => p.Id);


            foreach (var project in projects)
            {
                yield return existing.TryGetValue(project, out var p) ? p : new Project { Id = project };
            }
        }


    }


}

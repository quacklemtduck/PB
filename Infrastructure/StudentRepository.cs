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
                University = await getUniversityAsync(student.University),
                Email = student.Email
            };

            _context.Students.Add(entity);

            await _context.SaveChangesAsync();



            return new StudentDetailsDTO(
                        entity.Id,
                        entity.Name,
                        entity.University?.Name,
                        entity.Email,
                        entity.Projects.Select(p => p.Title).ToHashSet(),
                        entity.Applications.Select(a => a.Title).ToHashSet()
            );
        }

        /*public async Task<IReadOnlyCollection<StudentDetailsDTO>> ReadAllAsync()
        {
            return await _context.Students
                .Select(s => new StudentDetailsDTO(s.Id, s.Name, s.University.Name, s.Email, s.Projects.Select(p => p.Title).ToHashSet(), s.Applications.Select(a => a.Title).ToHashSet()))
                .ToListAsync();
        }*/

        public async Task<Option<StudentDetailsDTO>> ReadAsync(int studentId)
        {
            var students = from s in _context.Students
                           where s.Id == studentId
                           select new StudentDetailsDTO(
                               s.Id,
                               s.Name,
                               s.University.Name,
                               s.Email,
                               s.Projects.Select(p => p.Title).ToHashSet(),
                               s.Applications.Select(a => a.Title).ToHashSet()
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
            //entity.University = await getUniversityAsync(student.University);
            entity.Email = student.Email;

            entity.Projects = await GetProjectsAsync(student.Projects).ToListAsync();


            //entity.Applications = await getApplicationsAsync(student.Applications).ToListAsync();


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


        private async IAsyncEnumerable<Application> getApplicationsAsync(IEnumerable<string> applications)
        {
            var existing = await _context.Applications.Where(a => applications.Contains(a.Title)).ToDictionaryAsync(a => a.Title);

            foreach (var application in applications)
            {
                yield return existing.TryGetValue(application, out var a) ? a : new Application { Title = application };
            }
        }

        private async IAsyncEnumerable<Project> GetProjectsAsync(IEnumerable<string> projects)
        {
            //if (projects == null) yield return null;
            var existing = await _context.Projects.Where(p => projects.Contains(p.Title)).ToDictionaryAsync(p => p.Title);


            foreach (var project in projects)
            {
                yield return existing.TryGetValue(project, out var p) ? p : new Project { Title = project };
            }
        }


    }


}

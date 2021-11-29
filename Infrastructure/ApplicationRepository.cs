namespace PB.Infrastructure
{
    public class ApplicationRepository : IApplicationRepository
    {

        PBContext _context;

        public ApplicationRepository(PBContext context)
        {
            _context = context;
        }

        public async Task<ApplicationDetailsDTO> CreateAsync(ApplicationCreateDTO application)
        {
            var entity = new Application{
                Title = application.Title,
                Description = application.Description,
                Student = await GetStudentAsync(application.studentId),
                Project = await GetProjectAsync(application.projectId)
            };
            _context.Applications.Add(entity);

            await _context.SaveChangesAsync();
            return new ApplicationDetailsDTO(entity.Id,entity.StudentID,entity.ProjectID,entity.Description,entity.Title);
        }

        public async Task<Option<ApplicationDetailsDTO>> ReadAsync(int applicationId)
        {
            var app = await _context.Applications.FirstOrDefaultAsync(a => a.Id == applicationId);
            return app == null ? null : new ApplicationDetailsDTO(app.Id,app.StudentID,app.ProjectID,app.Description,app.Title);
        }

        public async Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadAllAsync()
        {
            return await _context.Applications
                .Select(a => new ApplicationDetailsDTO(a.Id,a.StudentID,a.ProjectID,a.Description,a.Title))
                .ToListAsync();
        }

        public async Task<Response> UpdateAsync(int id, ApplicationUpdateDTO appliation)
        {
            var entity = _context.Applications.FirstOrDefault(s => s.Id == id);
            if (entity == null) return NotFound;
            
            entity.Description = appliation.Description;
            entity.Title = appliation.Title;
            
            await _context.SaveChangesAsync();
            return Updated;
        }

        private async Task<Project?> GetProjectAsync(int? id) =>
            await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
        private async Task<Student?> GetStudentAsync(int? id) =>
            await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
    }
}

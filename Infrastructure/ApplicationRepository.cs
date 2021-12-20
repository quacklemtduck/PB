namespace PB.Infrastructure
{
    public class ApplicationRepository : IApplicationRepository
    {

        ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
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
            return new ApplicationDetailsDTO(entity.Id,entity.StudentID,entity.ProjectID,entity.Description,entity.Title, _context.Students.Find(entity.StudentID).Name);
        }

        public async Task<Option<ApplicationDetailsDTO>> ReadAsync(int applicationId)
        {
            var app = await _context.Applications.FirstOrDefaultAsync(a => a.Id == applicationId);
            return app == null ? null : new ApplicationDetailsDTO(app.Id,app.StudentID,app.ProjectID,app.Description,app.Title, _context.Students.Find(app.StudentID).Name);
        }

        public async Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadAllAsync()
        {
            return await _context.Applications
                .Select(a => new ApplicationDetailsDTO(a.Id,a.StudentID,a.ProjectID,a.Description,a.Title, _context.Students.Find(a.StudentID).Name))
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

        public async Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadFromProject(int projectId)
        {
            var project = _context.Projects.Include(x => x.Applications).Where(x => x.Id == projectId).FirstOrDefault();
            //var project = await _context.Projects.FindAsync(projectId);
            var result = project.Applications.Select(x => new ApplicationDetailsDTO(x.Id, x.StudentID, x.ProjectID, x.Description, x.Title, _context.Students.Find(x.StudentID).Name)).ToList().AsReadOnly();
            Console.WriteLine($"--------------NUMBER OF APPLICATIONS: {project.Applications.Count()}");
            return result;
        }

        public async Task<Response> Approve(int id){
            var entity = await _context.Applications.Include(x => x.Project).Include(x => x.Student).Where(e => e.Id == id).FirstOrDefaultAsync();
            entity.Project.ChosenStudents.Add(entity.Student);
            if(entity == null) return Response.NotFound;
            _context.Applications.Remove(entity);
            await _context.SaveChangesAsync();
            return Response.Updated;
        }

        public async Task<Response> Decline(int id)
        {
            var entity = await _context.Applications.FindAsync(id);
            if(entity == null) return Response.NotFound;

            _context.Applications.Remove(entity);
            await _context.SaveChangesAsync();
            return Response.Deleted;
        }
    }
}

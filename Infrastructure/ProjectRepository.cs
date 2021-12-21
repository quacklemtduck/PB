namespace PB.Infrastructure
{

    public class ProjectRepository : IProjectRepository
    {

        ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project)
        {
            var entity = new Project
            {
                Title = project.Title,
                Description = project.Description,
                Supervisor = _context.Supervisors.Find(project.SupervisorId),
                Notification = project.Notification,
                Status = project.Status,
                //Educations = _context.Educations.Where(e => project.Educations.Any(e2 => e2 == e.Id)).ToList()
                Educations = await GetEducationsAsync(project.Educations).ToListAsync()
            };
            

            _context.Projects.Add(entity);

            //Adding dummy applications
            var students = _context.Students.Where(s => project.Educations.Any(e2 => e2 == s.EducationId)).ToList();
            foreach (var student in students)
            {
                Console.WriteLine("Adding application");
                _context.Applications.Add(new Application{Title="Dummy Application", Description="Hello, i would like to join your project", Student=student, Project=entity});
            }
                          //  .Select(s => _context.Applications.Add(new Application{Title="Dummy Application", Description="Hello, i would like to join your project", Student=s, Project=entity}));

            await _context.SaveChangesAsync();

            return new ProjectDetailsDTO(
                                 entity.Id,
                                 entity.Title,
                                 entity.Description,
                                 entity.Supervisor?.Name,
                                 entity.Notification,
                                 entity.ChosenStudents.Select(s => s.Id).ToHashSet(),
                                 entity.Applications.Select(a => a.Id).ToHashSet(),
                                 entity.Educations.Select(u => u.Id).ToHashSet(),
                                 entity.Status
                             );
        }

        public async Task<Response> DeleteAsync(int projectID)
        {
            var entity = await _context.Projects.FindAsync(projectID);

            if (entity == null)
            {
                return Response.NotFound;
            }

            _context.Projects.Remove(entity);
            await _context.SaveChangesAsync();

            return Response.Deleted;
        }

        public async Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync() =>
                (await _context.Projects
                       .Select(p => new ProjectListDTO(p.Id, p.Title, p.Description, p.Status, p.SupervisorID))
                       .ToListAsync())
                       .AsReadOnly();
        
        public async Task<IReadOnlyCollection<ProjectListDTO>> ListAllVisibleAsync() =>
                (await _context.Projects
                       .Where(p => p.Status == Status.Visible)
                       .Select(p => new ProjectListDTO(p.Id, p.Title, p.Description, p.Status, p.SupervisorID))
                       .ToListAsync())
                       .AsReadOnly();
        
        public async Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync(string SupervisorID) =>
                (await _context.Projects
                        .Where(p => SupervisorID == p.SupervisorID)
                       .Select(p => new ProjectListDTO(p.Id, p.Title, p.Description, p.Status, p.SupervisorID))
                       .ToListAsync())
                       .AsReadOnly();

        public async Task<Option<ProjectDetailsDTO>> ReadByIDAsync(int projectId)
        {
            
            var projects = from p in _context.Projects
                           where p.Id == projectId
                           select new ProjectDetailsDTO(
                               p.Id,
                               p.Title,
                               p.Description,
                               p.Supervisor == null ? null : p.Supervisor.Id,
                               p.Notification,
                               p.ChosenStudents.Select(s => s.Id).ToHashSet(),
                               p.Applications.Select(a => a.Id).ToHashSet(),
                               p.Educations.Select(u => u.Id).ToHashSet(),
                               p.Status
                           );


            return await projects.FirstOrDefaultAsync();
        }

        public async Task<Response> UpdateAsync(ProjectCreateDTO project)
        {
            var entity = await _context.Projects.Include(p => p.ChosenStudents).Include(p => p.Applications).Include(p => p.Educations).FirstOrDefaultAsync(p => p.Id == project.Id);

            if (entity == null)
            {
                return Response.NotFound;
            }
            entity.Title = project.Title;
            entity.Description = project.Description;
            entity.Notification = project.Notification;
            entity.Status = project.Status;
            entity.Educations = await GetEducationsAsync(project.Educations).ToListAsync();
            //entity.Educations = _context.Educations.Where(e => project.Educations.Any(e2 => e2 == e.Id)).ToList();

            await _context.SaveChangesAsync();

            return Response.Updated;
        }

        public async Task<Response> UpdateStatusAsync(ProjectVisibilityUpdateDTO dto)
        {
            var entity = await _context.Projects.FindAsync(dto.ID);
            if (entity == null) return Response.NotFound;
            entity.Status = dto.Status;
            
            await _context.SaveChangesAsync();

            return Response.Updated;
        }

        public async Task<Response> UpdateChosenStudentsAsync(ProjectChosenStudentsUpdateDTO dto){
            var entity = await _context.Projects.Include(p => p.ChosenStudents).FirstOrDefaultAsync(p => p.Id == dto.ID);

            if (entity == null) return Response.NotFound;

            entity.ChosenStudents = await GetStudentsAsync(dto.ChosenStudents).ToListAsync();

            await _context.SaveChangesAsync();

            return Response.Updated;
        }

        private async IAsyncEnumerable<Student> GetStudentsAsync(IEnumerable<int> students)
        {
            var existing = await _context.Students.Where(s => students.Contains(s.Id)).ToDictionaryAsync(s => s.Id);

            foreach (var student in students)
            {
                yield return existing.TryGetValue(student, out var s) ? s : new Student { Id = student };
            }
        }

        private async IAsyncEnumerable<Application> GetApplicationsAsync(IEnumerable<int> applications)
        {
            var existing = await _context.Applications.Where(a => applications.Contains(a.Id)).ToDictionaryAsync(a => a.Id);

            foreach (var application in applications)
            {
                //Console.WriteLine("===========>>Application Title: " + application);
                yield return existing.TryGetValue(application, out var a) ? a : new Application { Id = application };
            }
        }

        private async IAsyncEnumerable<Education> GetEducationsAsync(IEnumerable<int> educations)
        {
            var existing = await _context.Educations.Where(a => educations.Contains(a.Id)).ToDictionaryAsync(a => a.Id);

            foreach (var education in educations)
            {
                //Console.WriteLine("===========>>Application Title: " + application);
                yield return existing.TryGetValue(education, out var a) ? a : new Education { Id = education };
            }
        }
    }
}
namespace PB.Infrastructure
{

    public class ProjectRepository : IProjectRepository
    {

        PBContext _context;

        public ProjectRepository(PBContext context)
        {
            _context = context;
        }

        public async Task<ProjectDetailsDTO> CreateAsync(ProjectCreateDTO project)
        {
            var entity = new Project
            {
                Title = project.Title,
                Description = project.Description,
                Supervisor = await getSupervisorAsync(project.Supervisor),
                Deadline = convertStringToDateTime(project.Deadline),
                getNotification = project.getNotification,
                numberOfStudents = project.numberOfStudents,
                CollabStudents = await GetStudentsAsync(project.CollabStudents).ToListAsync(),
                Tags = await GetTagsAsync(project.Tags).ToListAsync(),
                Applications = await GetApplicationsAsync(project.Applications).ToListAsync(),
                Universities = await GetUniversitiesAsync(project.Universities).ToListAsync()
            };

            _context.Projects.Add(entity);

            await _context.SaveChangesAsync();

            return new ProjectDetailsDTO(
                                 entity.Id,
                                 entity.Title,
                                 entity.Description,
                                 entity.Supervisor?.Name,
                                 convertDateTimeToString(entity.Deadline),
                                 entity.getNotification,
                                 entity.numberOfStudents,
                                 entity.CollabStudents.Select(s => s.Name).ToHashSet(),
                                 entity.Tags.Select(t => t.TagName).ToHashSet(),
                                 entity.Applications.Select(a => a.Title).ToHashSet(),
                                 entity.Universities.Select(u => u.Name).ToHashSet()
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
                       .Select(p => new ProjectListDTO(p.Id, p.Title, convertDateTimeToString(p.Deadline)))
                       .ToListAsync())
                       .AsReadOnly();
        
        public async Task<IReadOnlyCollection<ProjectListDTO>> ListAllAsync(int SupervisorID) =>
                (await _context.Projects
                        .Where(p => SupervisorID == p.SupervisorID)
                       .Select(p => new ProjectListDTO(p.Id, p.Title, convertDateTimeToString(p.Deadline)))
                       .ToListAsync())
                       .AsReadOnly();

        public async Task<ProjectDetailsDTO> ReadByIDAsync(int projectId)
        {
            var projects = from p in _context.Projects
                           where p.Id == projectId
                           select new ProjectDetailsDTO(
                               p.Id,
                               p.Title,
                               p.Description,
                               p.Supervisor == null ? null : p.Supervisor.Name,
                               convertDateTimeToString(p.Deadline),
                               p.getNotification,
                               p.numberOfStudents,
                               p.CollabStudents.Select(s => s.Name).ToHashSet(),
                               p.Tags.Select(t => t.TagName).ToHashSet(),
                               p.Applications.Select(a => a.Title).ToHashSet(),
                               p.Universities.Select(u => u.Name).ToHashSet()
                           );

            return await projects.FirstOrDefaultAsync();
        }

        public async Task<Response> UpdateAsync(int ID, ProjectUpdateDTO project)
        {
            var entity = await _context.Projects.Include(p => p.CollabStudents).Include(p => p.Tags).Include(p => p.Applications).Include(p => p.Universities).FirstOrDefaultAsync(p => p.Id == project.ID);

            //var entity = await _context.Projects.FirstOrDefaultAsync(p => p.Id == project.ID);

            if (entity == null)
            {
                return Response.NotFound;
            }

                entity.Title = project.Title;
                entity.Description = project.Description;
                entity.Supervisor = await getSupervisorAsync(project.Supervisor);
                entity.Deadline = convertStringToDateTime(project.Deadline);
                entity.getNotification = project.getNotification;
                entity.numberOfStudents = project.numberOfStudents;
                entity.status = project.status;
                entity.CollabStudents = await GetStudentsAsync(project.CollabStudents).ToListAsync();
                entity.Tags = await GetTagsAsync(project.Tags).ToListAsync();
                //Console.WriteLine("-------> Applications: " + project.Applications);
                entity.Applications = await GetApplicationsAsync(project.Applications).ToListAsync();
                entity.Universities = await GetUniversitiesAsync(project.Universities).ToListAsync();


            await _context.SaveChangesAsync();

            return Response.Updated;
        }

        


        //help methods:

        private async IAsyncEnumerable<Tag> GetTagsAsync(IEnumerable<string> tags)
        {
            var existing = await _context.Tags.Where(t => tags.Contains(t.TagName)).ToDictionaryAsync(t => t.TagName);

            foreach (var tag in tags)
            {
                yield return existing.TryGetValue(tag, out var t) ? t : new Tag { TagName = tag };
            }
        }

        private async IAsyncEnumerable<Student> GetStudentsAsync(IEnumerable<string> students)
        {
            var existing = await _context.Students.Where(s => students.Contains(s.Name)).ToDictionaryAsync(s => s.Name);

            foreach (var student in students)
            {
                yield return existing.TryGetValue(student, out var s) ? s : new Student { Name = student };
            }
        }

        private async IAsyncEnumerable<Application> GetApplicationsAsync(IEnumerable<string> applications)
        {
            var existing = await _context.Applications.Where(a => applications.Contains(a.Title)).ToDictionaryAsync(a => a.Title);

            foreach (var application in applications)
            {
                //Console.WriteLine("===========>>Application Title: " + application);
                yield return existing.TryGetValue(application, out var a) ? a : new Application { Title = application };
            }
        }

        private async IAsyncEnumerable<University> GetUniversitiesAsync(IEnumerable<string> universities)
        {
            var existing = await _context.Universities.Where(u => universities.Contains(u.Name)).ToDictionaryAsync(u => u.Name);

            foreach (var university in universities)
            {
                yield return existing.TryGetValue(university, out var u) ? u : new University { Name = university };
            }
        }

        private async Task<Supervisor?> getSupervisorAsync(string? name) =>
        string.IsNullOrWhiteSpace(name) ? null : await _context.Supervisors.FirstOrDefaultAsync(s => s.Name == name) ?? new Supervisor { Name = name };

        public static string convertDateTimeToString(DateTime? dateTime){
            const string FMT = "O";
            DateTime nonNullableDateTime = dateTime ?? DateTime.Now.AddMonths(1);
            return nonNullableDateTime.ToString(FMT);


        }

        public static DateTime convertStringToDateTime(string deadline){
            const string FMT = "O";
            return DateTime.ParseExact(deadline, FMT, CultureInfo.InvariantCulture);
        }


    }
}
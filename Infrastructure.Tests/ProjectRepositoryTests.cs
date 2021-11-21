namespace PB.Infrastructure.Tests
{

    public class ProjectRepositoryTests : IDisposable
    {
        private readonly PBContext _context;
        private readonly ProjectRepository _repository;

        public ProjectRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<PBContext>();
            builder.UseSqlite(connection);
            var context = new PBContext(builder.Options);
            context.Database.EnsureCreated();

            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };
            //context.Supervisors.Add(supervisor);

            var application = new Application { Title = "Softwareudvikler søger nye udfordringer" };
            //context.Applications.Add(application);

            var student = new Student { Name = "Test" };
            context.Students.Add(student);


            DateTime deadline = DateTime.Parse("Dec 22, 2021");

            context.Projects.AddRange(
                new Project { Id = 1, Title = "Project1", Description = "This is project 1", Supervisor = supervisor, Deadline = deadline },
                new Project { Id = 2, Title = "Project2", Description = "This is project 2", Supervisor = supervisor, Deadline = deadline },
                new Project { Id = 3, Title = "Project3", Description = "This is project 3", Supervisor = supervisor, Deadline = deadline },
                new Project { Id = 4, Title = "Project4", Description = "This is project 4", Supervisor = supervisor, Deadline = deadline },
                new Project { Id = 5, Title = "Project5", Description = "This is project 5", Supervisor = supervisor, Deadline = deadline }
            );

            context.SaveChanges();

            _context = context;
            _repository = new ProjectRepository(_context);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public async Task Delete_returns_null(int projectID)
        {
            var response = await _repository.DeleteAsync(projectID);
            _context.SaveChanges();

            Project? foundProject =
                (from p in _context.Projects
                 where p.Id == projectID
                 select p).SingleOrDefault();

            Assert.Equal((Response.Deleted), response);
            Assert.Null(foundProject);
        }


        [Fact]
        public async Task DeleteAsync_given_non_existing_ID_returns_NotFound()
        {
            var response = await _repository.DeleteAsync(420);

            Assert.Equal((Response.NotFound), response);
        }

        [Fact]
        public async Task DeleteAsync_deletes_and_returns_Deleted()
        {
            var response = await _repository.DeleteAsync(2);

            var entity = await _context.Projects.FindAsync(2);

            Assert.Equal(Response.Deleted, response);
            Assert.Null(entity);
        }





        [Fact]
        public async Task ListAllAsync_returns_all_projects()
        {
            var projects = await _repository.ListAllAsync();


            Assert.Collection(projects,
                projects => Assert.Equal(new ProjectListDTO(1, "Project1", getDeadlineString()), projects),
                projects => Assert.Equal(new ProjectListDTO(2, "Project2", getDeadlineString()), projects),
                projects => Assert.Equal(new ProjectListDTO(3, "Project3", getDeadlineString()), projects),
                projects => Assert.Equal(new ProjectListDTO(4, "Project4", getDeadlineString()), projects),
                projects => Assert.Equal(new ProjectListDTO(5, "Project5", getDeadlineString()), projects)
            );
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_Project_returns_NotFound()
        {
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };

            var project = new ProjectUpdateDTO
            {
                ID = 42,
                Title = "Project5",
                Description = "This is project 5",
                Supervisor = supervisor.ToString(),
                Deadline = getDeadlineString(),
                getNotification = false,
                numberOfStudents = 2,
                CollabStudents = new HashSet<string>(),
                Tags = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Universities = new HashSet<string>()
            };

            var response = await _repository.UpdateAsync(42, project);

            Assert.Equal(NotFound, response);
        }

        [Fact]
        public async Task UpdateAsync_updates_existing_Project()
        {
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };


            var project = new ProjectUpdateDTO
            {
                ID = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Supervisor = "Supervisor1",
                Deadline = getDeadlineString(),
                getNotification = false,
                numberOfStudents = 2,
                CollabStudents = new HashSet<string>(),
                Tags = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Universities = new HashSet<string>()
            };

            var response = await _repository.UpdateAsync(5, project);

            Assert.Equal(Updated, response);
            var projectUpdated = await _repository.ReadByIDAsync(5);

            Assert.Empty(projectUpdated.CollabStudents);
            Assert.Empty(projectUpdated.Tags);
            Assert.Empty(projectUpdated.Applications);
            Assert.Empty(projectUpdated.Universities);
        }

        [Fact]
        public async Task UpdateAsync_adds_students_existing_Project()
        {
            var student = new Student { Name = "Test" };
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };
            var collabStudents = new HashSet<string>();
            collabStudents.Add(student.Name);

            var project = new ProjectUpdateDTO
            {
                ID = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Supervisor = "Supervisor1",
                Deadline = getDeadlineString(),
                getNotification = false,
                numberOfStudents = 2,
                //CollabStudents = new HashSet<string>() { student.Name },
                CollabStudents = collabStudents,
                Tags = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Universities = new HashSet<string>()
            };

            var response = await _repository.UpdateAsync(5, project);

            Assert.Equal(Updated, response);
            var projectUpdated = await _repository.ReadByIDAsync(5);
            
            Assert.Equal("newProject5" , projectUpdated.Title);
            Assert.Equal(1 , projectUpdated.CollabStudents.Count);
            Assert.True(projectUpdated.CollabStudents.Contains(student.Name));
            Assert.Equal(1, projectUpdated.CollabStudents.Count());

            Assert.Empty(projectUpdated.Tags);
            Assert.Empty(projectUpdated.Applications);
            Assert.Empty(projectUpdated.Universities);
        }

        [Fact]
        public async Task UpdateAsync_adds_application_existing_Project()
        {
            var application = new Application { Title = "Softwareudvikler søger nye udfordringer" };

            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };
        
            var applications = new HashSet<string>();
            applications.Add(application.Title);

            var project = new ProjectUpdateDTO
            {
                ID = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Supervisor = "Supervisor1",
                Deadline = getDeadlineString(),
                getNotification = false,
                numberOfStudents = 2,
                CollabStudents = new HashSet<string>(),
                Tags = new HashSet<string>(),
                Applications = applications,
                Universities = new HashSet<string>()
            };

            var response = await _repository.UpdateAsync(5, project);

            Assert.Equal(Updated, response);
            var projectUpdated = await _repository.ReadByIDAsync(5);

            Assert.Equal(1, projectUpdated.Applications.Count());
            Assert.True(projectUpdated.Applications.Contains(application.Title));
            Assert.Equal("newProject5", projectUpdated.Title);

            Assert.Empty(projectUpdated.Tags);
            Assert.Empty(projectUpdated.CollabStudents);
            Assert.Empty(projectUpdated.Universities);
        }

        [Fact]
        public async Task ReadByIDAsync_given_id_does_not_exist_returns_None()
        {
            var option = await _repository.ReadByIDAsync(42);

            Assert.Null(option);
        }

        [Fact]
        public async Task ReadByIDAsync_given_id_exists_returns_Project()
        {
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };

            var project = await _repository.ReadByIDAsync(1);

            Assert.True(project.Supervisor.Contains(supervisor.Name));
            Assert.Equal(1, project.ID);
            Assert.Equal(0, project.numberOfStudents);
            Assert.Equal("Supervisor1", project.Supervisor);
            Assert.Empty(project.CollabStudents);
            Assert.Equal(getDeadlineString(), project.Deadline);
            Assert.Equal("This is project 1", project.Description);
            Assert.False(project.getNotification);
            Assert.Empty(project.Tags);
            Assert.Empty(project.Universities);
            Assert.Empty(project.CollabStudents);

        }


        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private string getDeadlineString(){
            DateTime deadline = DateTime.Parse("Dec 22, 2021");
            return ProjectRepository.convertDateTimeToString(deadline);
        }

    }
}
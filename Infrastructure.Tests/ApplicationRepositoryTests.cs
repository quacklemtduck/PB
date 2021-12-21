namespace Infrastructure.Tests
{
    public class ApplicationRepositoryTests : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ApplicationRepository _repository;
        
        public ApplicationRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(connection);
            var options = new Option<OperationalStoreOptions>(new OperationalStoreOptions());
            var context = new ApplicationDbContext(builder.Options, options);
            context.Database.EnsureCreated();
            var student1 = new Student { Id = 1, Name = "Student1" };
            var student2 = new Student { Id = 2, Name = "Student2" };
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };
            var project1 = new Project { Id = 1, Title = "Project1", Description = "project 1", Supervisor = supervisor };
            var project2 = new Project { Id = 2, Title = "Project2", Description = "project 2", Supervisor = supervisor };

            context.Applications.AddRange(
                new Application { Id = 1, Title = "title1", Description = "app 1", Student = student1, Project = project1 },
                new Application { Id = 2, Title = "title2", Description = "app 2", Student = student2, Project = project1 },
                new Application { Id = 3, Title = "title3", Description = "app 3", Student = student1, Project = project2 }
            );

            context.SaveChanges();

            _context = context;
            _repository = new ApplicationRepository(_context);
        }


        [Fact]
        public async Task CreateAsync_creates_new_student_with_generated_id()
        {
            var application = new ApplicationCreateDTO(2, 2, "title4"){ Description = "app 4"};
            var created = await _repository.CreateAsync(application);

            Assert.Equal(4, created.Id);
            Assert.Equal("title4", created.Title);
            Assert.Equal("app 4", created.Description);
            Assert.Equal(2, created.studentId);
            Assert.Equal(2, created.projectId);
        }

        [Fact]
        public async Task ReadAsync_given_id_exists_returns_Aplication()
        {
            var option = await _repository.ReadAsync(2);
            Assert.True(option.IsSome);
            
            var app = option.Value;
            Assert.Equal(2, app.Id);
            Assert.Equal("title2", app.Title);
            Assert.Equal("app 2", app.Description);
            Assert.Equal(2, app.studentId);
            Assert.Equal(1, app.projectId);
        }

        [Fact]
        public async Task ReadAsync_given_non_existing_id_returns_None()
        {
            var option = await _repository.ReadAsync(-1);

            Assert.True(option.IsNone);
        }

        [Fact]
        public async Task ReadAllAsync_returns_all_applications()
        {
            var applications = await _repository.ReadAllAsync();

            Assert.Collection(applications,
                applications => Assert.Equal(new ApplicationDetailsDTO(1, 1, 1, "app 1", "title1", "Student1"), applications),
                applications => Assert.Equal(new ApplicationDetailsDTO(2, 2, 1, "app 2", "title2", "Student2"), applications),
                applications => Assert.Equal(new ApplicationDetailsDTO(3, 1, 2, "app 3", "title3", "Student1"), applications)
            );
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
        {
            var application = new ApplicationUpdateDTO(-1,"app","title");
            var response = await _repository.UpdateAsync(application.Id, application);

            Assert.Equal(NotFound, response);
        }

        [Fact]
        public async Task UpdateAsync_given_existing_id_updates_supervisor()
        {
            var application = new ApplicationUpdateDTO(1,"app","title");
            var response = await _repository.UpdateAsync(application.Id, application);
            Assert.Equal(Updated, response);

            var updatedApplication = (await _repository.ReadAsync(1)).Value;
            Assert.Equal("title", updatedApplication.Title);
            Assert.Equal("app", updatedApplication.Description);
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
    }

}